---
layout: post
title: License Activation using Syncfusion .NET CLI | Syncfusion®
description: Learn here about how to activate and view Syncfusion® licenses for .NET MAUI projects using the Syncfusion® .NET CLI (sf) license commands.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Activate Syncfusion<sup>®</sup> licenses

The CLI detects the Syncfusion<sup>®</sup> controls used in a project, downloads the matching license keys from your Syncfusion<sup>®</sup> account, and registers the keys in the project's startup code. For example, when a sample is created with the Cartesian Chart control, the CLI registers the license for `Syncfusion.Maui.Charts` in `MauiProgram.cs` so the build runs without a license warning.

N> Open the Command Prompt or Terminal in the target sample's project directory before running the license activation command. The license operation is project-specific, and the command path must point to the intended sample.

## Sign in requirements

License activation requires a Syncfusion<sup>®</sup> account. The CLI uses the account to check your entitlements and download the license keys for the Syncfusion<sup>®</sup> packages detected in the project. You can sign in during activation, or ahead of time with `sf login`.

## Sign in and sign out

To sign in to your Syncfusion<sup>®</sup> account, run:

```bash
sf login
```

The CLI opens your default browser on the Syncfusion<sup>®</sup> sign-in page. Complete sign in, and the CLI stores a local session for future license operations. The session is reused by `sf license activate`, so you sign in only once per machine until you sign out.

To sign out and clear the local sign-in session, run:

```bash
sf logout
```

After signing out, the next license operation prompts you to sign in again. Signing out does not affect the license keys already registered in your projects.

## Activate a license through the interactive menu

1. Open the Command Prompt or Terminal in the target sample's project directory.

2. Run `sf` to open the main menu.

3. Under **License management**, select **Activate license**.

    ![Activate license option in the Syncfusion .NET CLI](images/cli-activate-license.png)

4. If you are not signed in, the CLI opens your default browser to the Syncfusion<sup>®</sup> sign-in page. Complete sign in with your Syncfusion<sup>®</sup> account.

    ![Syncfusion sign-in page in the browser](images/cli-license-sign-in.png)

5. After sign in, the CLI checks your entitlements, downloads the matching keys for the Syncfusion<sup>®</sup> controls in the sample, and registers the keys in `MauiProgram.cs`.

    ![License registered successfully in the Syncfusion .NET CLI](images/cli-license-registered.png)

6. Rebuild the application so the newly registered license is applied.

## Activate a license using a direct command

Run the activation command from the sample's project directory:

```bash
sf license activate
```

Pass `--path` to point the CLI at a specific project directory or `.csproj` file:

```bash
sf license activate --path ./MyApp
sf license activate --path ./MyApp/MyApp.csproj
```

Use `--yes` to accept the trial EULA prompt without asking:

```bash
sf license activate --yes
```

Use `--file` to activate from an existing key file. With no value, the CLI reads `./syncfusion-license.txt` from the project directory. With an absolute path, the CLI uses the specified file instead:

```bash
sf license activate --file
sf license activate --file C:\Users\<username>\keys\syncfusion-license.txt
```

N> When a license key is supplied through `--file`, the CLI skips sign in and download and registers the keys already in the file. The file path must be absolute.

## View installed licenses

To see the licenses cached for the current project, run:

```bash
sf license view
```

The command reads the cached metadata, lists each product, the license type, the status, and the expiry date, and warns when a Syncfusion<sup>®</sup> package in the project is not covered.

![View installed licenses in the Syncfusion .NET CLI](images/cli-view-installed-license-menu.png)

The cached output reports the registered email, platform, major version, and one row per product.

![Installed license details in the Syncfusion .NET CLI](images/cli-view-installed-license.png)

## License options

| Option | Description |
| --- | --- |
| `-p`, `--path` | The project directory or `.csproj`/`.vbproj` to scan for Syncfusion<sup>®</sup> packages. Defaults to the current directory |
| `-y`, `--yes` | Accept the trial EULA prompt automatically during activation |
| `--file` | Activate from an existing key file. With no value, the CLI reads `./syncfusion-license.txt` from the project directory. With an absolute path, the CLI uses the specified file |
| `--json` | Emit one JSON document instead of table output |

## FAQs

**Where does the CLI register the license for .NET MAUI?**

In `MauiProgram.cs`, immediately before `MauiApp.CreateBuilder()`.

**Can I use my own key file?**

Yes. Run `sf license activate --file C:\Users\<username>\keys\syncfusion-license.txt` with an absolute path. The CLI reads the keys from the file and registers them in the project's startup code without contacting the license service.

**What happens if I am not signed in during activation?**

The CLI opens your default browser on the Syncfusion<sup>®</sup> sign-in page. After you complete sign in, activation continues. To sign in ahead of time, run `sf login`.

## See also

* [Create a .NET MAUI project](/maui/dotnet-cli/create-project)
* [Manage packages in an existing project](/maui/dotnet-cli/manage-packages)
* [Syncfusion<sup>®</sup> licensing overview](https://help.syncfusion.com/common/essential-studio/licensing/overview)
