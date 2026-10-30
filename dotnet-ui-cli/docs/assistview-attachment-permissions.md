# AssistView attachment platform configuration

New MAUI projects selecting AssistView (including its aliases) configure the following files. Empty projects and other controls do not receive these declarations. Both direct and interactive creation use NewProjectScaffolder; dry runs report the same affected files.

- AndroidManifest.xml: READ_EXTERNAL_STORAGE through API 32, WRITE_EXTERNAL_STORAGE through API 28, and READ_MEDIA_IMAGES. Modern Android uses scoped storage and system pickers; manifest entries do not grant runtime permissions automatically.
- iOS/Info.plist: NSPhotoLibraryUsageDescription, explaining that photos can be selected as message attachments. macOS sandbox entitlement keys in an iOS Info.plist do not grant file access. iOS document access uses the system picker.
- MacCatalyst/Info.plist: the same photo-library usage description.
- MacCatalyst/Entitlements.plist: pictures, Downloads, user-selected files read/write, and photos-library entitlements. The standard MAUI sandbox and network entitlements are preserved.

Existing keys and permissions are retained. Reapplying configuration does not duplicate entries. User consent and operating-system picker restrictions still apply; these declarations do not bypass them.

## Verification

- Configuration tests cover XML output, version limits, existing entries, idempotence, AssistView aliases, and no changes for empty/DataGrid projects.
- Full suite before the final four planning cases: 1,296 passed, one existing Diagram color test failed. That failure concerns Color.FromArgb in DiagramViewModel and is unrelated to permissions.
- Real CLI AssistView generation was attempted on Linux. Package compatibility restore stopped at NETSDK1147 because the maui-android workload is absent, before platform configuration could run. This is not a successful end-to-end generation check.
- Native Android/iOS/Mac Catalyst permission prompts, attachment selection, and Apple signing were not tested on this Linux host.
