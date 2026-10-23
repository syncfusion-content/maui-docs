#!/usr/bin/env python3
"""Dependency-free reader for the harness contract's YAML subset.

The harness must run on a bare Python 3.8+ install: no pip, no PyYAML, no
network. So harness.yaml is restricted to a documented subset, and this module
parses it. If PyYAML happens to be installed it is used instead (better
fidelity), and the subset is a strict sub-language of real YAML either way -
so a harness.yaml written for this parser is always valid YAML.

Supported subset:
  * nested block mappings (2-space indent)
  * block sequences of scalars and of mappings
  * scalars: str, int, float, true/false, null/~, quoted strings
  * inline flow sequences: [a, b, c]
  * block scalars: | (literal) and > (folded)
  * '#' comments (outside quotes)

Not supported (rejected with a line number rather than mis-parsed):
  anchors/aliases, multi-document streams, complex keys, inline flow mappings.
"""

import re


class HYamlError(Exception):
    pass


# Escape sequences recognised inside double-quoted scalars.
_ESCAPES = {"n": "\n", "t": "\t", "r": "\r", "0": "\0", '"': '"', "\\": "\\"}


def _scalar(tok, lineno):
    t = tok.strip()
    if not t:
        return ""
    if t in ("null", "~", "Null", "NULL"):
        return None
    if t in ("true", "True", "TRUE", "yes", "on"):
        return True
    if t in ("false", "False", "FALSE", "no", "off"):
        return False
    if len(t) >= 2 and t[0] == t[-1] and t[0] in "\"'":
        body = t[1:-1]
        if t[0] == '"':
            body = re.sub(r'\\(.)', lambda m: _ESCAPES.get(m.group(1), m.group(1)), body)
        return body
    if t.startswith("[") and t.endswith("]"):
        inner = t[1:-1].strip()
        if not inner:
            return []
        return [_scalar(p, lineno) for p in _split_flow(inner, lineno)]
    if re.fullmatch(r"[*&][A-Za-z_][\w-]*", t):
        raise HYamlError(f"line {lineno}: anchors/aliases are not supported in harness.yaml")
    if t.startswith("{"):
        raise HYamlError(f"line {lineno}: inline flow mappings are not supported; use block style")
    if re.fullmatch(r"[-+]?\d+", t):
        return int(t)
    if re.fullmatch(r"[-+]?(\d+\.\d*|\.\d+)([eE][-+]?\d+)?", t):
        return float(t)
    return t


def _split_flow(s, lineno):
    parts, buf, quote, depth, esc = [], "", None, 0, False
    for ch in s:
        if quote:
            buf += ch
            if esc:
                esc = False
            elif ch == "\\" and quote == '"':
                esc = True
            elif ch == quote:
                quote = None
            continue
        if ch in "\"'":
            quote = ch
            buf += ch
        elif ch == "[":
            depth += 1
            buf += ch
        elif ch == "]":
            depth -= 1
            buf += ch
        elif ch == "," and depth == 0:
            parts.append(buf)
            buf = ""
        else:
            buf += ch
    if buf.strip():
        parts.append(buf)
    return parts


def _strip_comment(line):
    out, quote, esc = "", None, False
    for ch in line:
        if quote:
            out += ch
            if esc:
                esc = False
            elif ch == "\\" and quote == '"':
                esc = True
            elif ch == quote:
                quote = None
        elif ch in "\"'":
            quote = ch
            out += ch
        elif ch == "#":
            break
        else:
            out += ch
    return out.rstrip()


def _tokenize(text):
    """-> list of (lineno, indent, content) for significant lines."""
    rows = []
    for i, raw in enumerate(text.splitlines(), 1):
        if "\t" in raw[:len(raw) - len(raw.lstrip())]:
            raise HYamlError(f"line {i}: tab in indentation; harness.yaml requires spaces")
        content = _strip_comment(raw)
        if not content.strip():
            continue
        rows.append((i, len(content) - len(content.lstrip()), content.strip()))
    return rows


def loads(text):
    if _pyyaml:
        try:
            return _pyyaml.safe_load(text) or {}
        except Exception as e:  # noqa: BLE001 - surface any YAML error uniformly
            raise HYamlError(str(e))
    rows = _tokenize(text)
    value, idx = _parse_block(rows, 0, 0, text.splitlines())
    if idx != len(rows):
        raise HYamlError(f"line {rows[idx][0]}: unexpected indentation")
    return value if value is not None else {}


def _block_scalar(lines, start_lineno, base_indent, fold):
    """Collect an indented block following a | or > marker."""
    out, i = [], start_lineno  # start_lineno is 1-based index of the marker line
    while i < len(lines):
        raw = lines[i]
        if not raw.strip():
            out.append("")
            i += 1
            continue
        indent = len(raw) - len(raw.lstrip())
        if indent <= base_indent:
            break
        out.append(raw[base_indent + 2:] if len(raw) > base_indent + 2 else raw.strip())
        i += 1
    while out and not out[-1]:
        out.pop()
    return (" ".join(x for x in out if x) if fold else "\n".join(out)), i


def _parse_block(rows, idx, indent, lines):
    if idx >= len(rows):
        return None, idx
    _, first_indent, first = rows[idx]
    if first_indent < indent:
        return None, idx
    if first.startswith("- "):
        return _parse_seq(rows, idx, first_indent, lines)
    return _parse_map(rows, idx, first_indent, lines)


def _parse_map(rows, idx, indent, lines):
    result = {}
    while idx < len(rows):
        lineno, ind, content = rows[idx]
        if ind < indent:
            break
        if ind > indent:
            raise HYamlError(f"line {lineno}: unexpected indent inside mapping")
        if content.startswith("- "):
            break
        if ":" not in content:
            raise HYamlError(f"line {lineno}: expected 'key: value', got {content!r}")
        key, _, rest = content.partition(":")
        key, rest = key.strip().strip("\"'"), rest.strip()
        idx += 1
        if rest in ("|", "|-", ">", ">-"):
            text, _ = _block_scalar(lines, lineno, ind, rest.startswith(">"))
            result[key] = text
            while idx < len(rows) and rows[idx][1] > ind:
                idx += 1
        elif rest:
            result[key] = _scalar(rest, lineno)
        elif idx < len(rows) and rows[idx][1] > ind:
            result[key], idx = _parse_block(rows, idx, rows[idx][1], lines)
        elif idx < len(rows) and rows[idx][1] == ind and rows[idx][2].startswith("- "):
            result[key], idx = _parse_seq(rows, idx, ind, lines)
        else:
            result[key] = None
    return result, idx


def _parse_seq(rows, idx, indent, lines):
    items = []
    while idx < len(rows):
        lineno, ind, content = rows[idx]
        if ind < indent or not content.startswith("- "):
            break
        if ind > indent:
            raise HYamlError(f"line {lineno}: unexpected indent inside sequence")
        item = content[2:].strip()
        idx += 1
        if ":" in item and not (item[0] in "\"'"):
            # sequence of mappings: first pair is inline, rest are deeper rows
            inline_key, _, inline_rest = item.partition(":")
            entry = {}
            k, v = inline_key.strip(), inline_rest.strip()
            if v in ("|", "|-", ">", ">-"):
                entry[k], _ = _block_scalar(lines, lineno, ind + 2, v.startswith(">"))
                while idx < len(rows) and rows[idx][1] > ind + 2:
                    idx += 1
            else:
                entry[k] = _scalar(v, lineno) if v else None
            if idx < len(rows) and rows[idx][1] > ind:
                deeper, idx = _parse_map(rows, idx, rows[idx][1], lines)
                if v == "" and isinstance(deeper, dict) and k in ("", None):
                    pass
                if entry.get(k) is None and isinstance(deeper, dict) and k in deeper:
                    entry.update(deeper)
                else:
                    entry.update(deeper if isinstance(deeper, dict) else {})
            items.append(entry)
        else:
            items.append(_scalar(item, lineno))
    return items, idx


def dumps(obj, indent=0):
    """Emit the same subset. Round-trips loads() output."""
    pad = " " * indent
    lines = []
    if isinstance(obj, dict):
        for k, v in obj.items():
            if isinstance(v, dict) and v:
                lines.append(f"{pad}{k}:")
                lines.append(dumps(v, indent + 2))
            elif isinstance(v, list) and v:
                lines.append(f"{pad}{k}:")
                lines.append(dumps(v, indent + 2))
            elif isinstance(v, (dict, list)):
                lines.append(f"{pad}{k}: {'{}' if isinstance(v, dict) else '[]'}")
            else:
                lines.append(f"{pad}{k}: {_emit(v)}")
    elif isinstance(obj, list):
        for item in obj:
            if isinstance(item, dict):
                inner = dumps(item, indent + 2).splitlines()
                if inner:
                    lines.append(f"{pad}- {inner[0].lstrip()}")
                    lines.extend(inner[1:])
            else:
                lines.append(f"{pad}- {_emit(item)}")
    return "\n".join(lines)


def _emit(v):
    if v is None:
        return "null"
    if isinstance(v, bool):
        return "true" if v else "false"
    if isinstance(v, (int, float)):
        return str(v)
    s = str(v)
    needs_quote = (
        s == ""
        or s[0] in "*&!|>%@`-?,[]{}#\"'"       # YAML indicator characters
        or re.search(r'[:#\[\]{}]|^\s|\s$', s)
        or s in ("true", "false", "null", "yes", "no", "on", "off", "~")
        or re.fullmatch(r'[-+]?[\d.]+([eE][-+]?\d+)?', s)   # keep numeric-looking strings as strings
    )
    if needs_quote or any(c in s for c in "\n\r\t"):
        body = (s.replace("\\", "\\\\").replace('"', '\\"')
                 .replace("\n", "\\n").replace("\r", "\\r").replace("\t", "\\t"))
        return '"' + body + '"'
    return s


try:
    import yaml as _pyyaml
except ImportError:
    _pyyaml = None
