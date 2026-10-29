#!/usr/bin/env python3
"""Exercise every Blazor wizard option in a real Unix PTY; cancel before creation.
Requires: pip install pexpect pyte. Usage: python scripts/validate-blazor-interactive.py
--cli /absolute/path/sf.dll --output /absolute/path/evidence [--dotnet dotnet]
This checks option-value coverage, not every Cartesian product or native Windows UI.
"""
import argparse
import json
import os
from pathlib import Path
import re
import subprocess
import pexpect
import pyte

parser = argparse.ArgumentParser(description=__doc__)
parser.add_argument('--cli', required=True)
parser.add_argument('--output', required=True)
parser.add_argument('--dotnet', default='dotnet')
parser.add_argument('--case-name', action='append', help='Run named scenarios only')
args = parser.parse_args()
output = Path(args.output).resolve()
output.mkdir(parents=True, exist_ok=True)
controls = ['AI AssistView', 'Block Editor', 'Charts', 'Diagram', 'Document Editor',
            'File Manager', 'Gantt', 'Grid', 'Kanban', 'PDF Viewer', 'Pivot Table',
            'Query Builder', 'Rich Text Editor', 'Scheduler', 'Spreadsheet']
themes = ['Fluent 2', 'Bootstrap 5.3', 'Material 3', 'Tailwind 3', 'Bootstrap 5']
base = dict(app=0, render=0, interactivity=0, auth=0, https=0, setup=1, theme=0,
            controls=list(range(len(controls))), post=0)
cases = [dict(base, name='all-controls-web')]
for key, count in [('app', 2), ('render', 3), ('interactivity', 2), ('auth', 2),
                   ('https', 2), ('setup', 2), ('theme', 5), ('post', 2)]:
    for value in range(count):
        cases.append(dict(base, **{key: value}, name=f'{key}-{value}'))
for index, control in enumerate(controls):
    cases.append(dict(base, controls=[index], name=f'control-{index}'))
for theme in range(len(themes)):
    cases.append(dict(base, app=1, theme=theme, name=f'wasm-theme-{theme}'))
cases.extend([dict(base, app=1, setup=0, name='wasm-empty'),
              dict(base, app=1, https=1, name='wasm-https-no'),
              dict(base, app=1, post=1, name='wasm-build')])
if args.case_name:
    cases = [case for case in cases if case['name'] in args.case_name]
    if len(cases) != len(args.case_name):
        parser.error('Unknown or repeated scenario name')
results = []
for case in cases:
    screen = pyte.Screen(160, 60)
    stream = pyte.Stream(screen)
    log_path = output / (case['name'] + '.ansi')
    with log_path.open('w', newline='') as log:
        class Capture:
            def write(self, data):
                log.write(data)
                stream.feed(data)
            def flush(self):
                log.flush()
        env = dict(os.environ, TERM='xterm-256color')
        env.pop('NO_COLOR', None)
        child = pexpect.spawn(args.dotnet, [str(Path(args.cli).resolve()), 'new', 'blazor',
                              '--path', str(output / 'projects')],
                              env=env, encoding='utf-8', timeout=30, dimensions=(60, 160))
        child.logfile_read = Capture()
        def text():
            return '\n'.join(line.rstrip() for line in screen.display)
        def wait(title):
            child.expect_exact(title)
            try:
                while True:
                    child.read_nonblocking(65536, timeout=.04)
            except pexpect.TIMEOUT:
                pass
        def choose(title, index):
            wait(title)
            if index:
                child.send('\x1b[B' * index)
            child.send('\r')
        try:
            choose('Application type:', case['app'])
            app_template = 'blazorwasm' if case['app'] else 'blazor'
            help_text = subprocess.check_output([args.dotnet, 'new', app_template, '--help'], text=True)
            frameworks = [name for name in ['net10.0', 'net9.0', 'net8.0', 'net11.0']
                          if re.search(r'\b' + re.escape(name) + r'\b', help_text)]
            if len(frameworks) > 1:
                choose('Target framework:', 0)
            if not case['app']:
                choose('Render mode:', case['render'])
                choose('Interactivity:', case['interactivity'])
                choose('Authentication:', case['auth'])
            if case['app'] or not case['auth']:
                choose('HTTPS:', case['https'])
            wait('Project name:')
            child.send('WizardEvidence' + str(len(results)) + '\r')
            choose('Select project setup:', case['setup'])
            if case['setup']:
                wait('Which Syncfusion components would you like to include?')
                assert 'Selected: 0' in text(), text()
                assert 'Language:' not in text(), text()
                assert 'Theme:' not in text(), text()
                assert all(label in text() for label in controls), text()
                focus = 0
                for selected in case['controls']:
                    child.send('\x1b[B' * (selected - focus) + ' ')
                    focus = selected
                child.send('\r')
                choose('Theme:', case['theme'])
            choose('Post-create:', case['post'])
            wait('Proceed with project creation?')
            current = text()
            assert 'Language:' not in current, current
            if case['setup']:
                assert themes[case['theme']] in current, current
                assert current.index('Controls:') < current.index('Theme:'), current
            (output / (case['name'] + '.screen.txt')).write_text(current.rstrip() + '\n')
            child.send('n\r')
            child.expect(pexpect.EOF)
            assert child.exitstatus in (None, 130), child.exitstatus
            results.append(dict(case, result='passed', frameworks=frameworks))
            print('PASS', case['name'], flush=True)
        finally:
            child.close(force=True)
    (output / 'results.json').write_text(json.dumps(results, indent=2))
assert not list((output / 'projects').glob('**/*.csproj')), 'Cancellation unexpectedly created a project'
print(f'PASS {len(results)} terminal scenarios. All offered option values selected; creation cancelled.', flush=True)
