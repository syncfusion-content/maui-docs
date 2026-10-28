# Knowledge: CLI architecture and platform integration

Source: docs/architecture.md (retrieved 2026-10-14)

- Platform assemblies reference only Core. Shared transactional creation, project format helpers, process execution and package-only operations live in `Core/Desktop`.
- Direct commands and the interactive wizard collect input, validate it into shared request types and call the same operation services.
- `FileRollback` makes `ControlInstaller` transactional: created files are deleted and modified files are restored when an operation fails.
- `Syncfusion/syncfusion.json` records SHA-256 hashes of generated files. `update` preserves customer-modified files unless `--force`.
- `Program.Main` maps Ctrl+C to exit code 130.
- Global options are added to every subcommand because System.CommandLine 2.0 does not inherit root options.

Source: docs/desktop-platforms.md (retrieved 2026-10-14)

- Desktop provider assemblies own catalogs, themes, language-specific generation and initialization APIs.
- Static tests, builds and runtime checks are distinct levels of evidence; see that document before claiming a configuration works.
