---
layout: post
title: Installing Syncfusion .NET MAUI Mac installer | Syncfusion
description: Learn how to install the Syncfusion .NET MAUI Mac installer after downloading it from the Syncfusion website.
platform: MAUI
control: Installation and Deployment
documentation: UG
---

# Installing Syncfusion<sup>®</sup> .NET MAUI Mac installer

**Applies to:** Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI Mac installer on macOS (Catalina or later).

## Prerequisites

* A Mac running macOS Catalina (10.15) or later.
* A user account with permission to install applications (administrator password may be required).
* A current version of the Syncfusion .NET MAUI Mac DMG installer. If you do not have it, see [Downloading the Syncfusion .NET MAUI Mac installer](https://help.syncfusion.com/maui/installation/mac-installer/how-to-download).

## Steps to resolve the warning message in Catalina OS or later

When you run the .NET MAUI Mac installer on macOS Catalina or later, the alert below will be displayed.

![macOS Catalina Gatekeeper alert for the Syncfusion DMG](images/Mac_Catalina_MacOS_Alert1.png)

If you receive this alert, follow the steps below for the easiest solution.

1. Right-click the downloaded DMG file.
2. Select **Open With** and choose **DiskImageMounter (Default)**. The pop-up below appears.

   ![Open With DiskImageMounter dialog](images/Mac_Catalina_MacOS_Alert2.png)

3. Click **Open** to access the installer window.

## Step-by-step installation

The steps below show how to install the .NET MAUI Mac installer.

1. Locate the downloaded DMG file and open it by double-clicking.

   ![DMG file opened in Finder](images/Mac_Installer1.png)

2. This action will mount the disk image and create a virtual drive on your desktop or in the Finder sidebar.

   ![Mounted DMG contents in Finder](images/Mac_Installer2.png)

3. Copy the mounted disk file.

   ![Copying the mounted disk file](images/Mac_Installer3.png)

4. Paste it into the **Applications** folder shortcut.

   ![Pasting the installer into the Applications folder](images/Mac_Installer4.png)

   > An unlock key is not required to install the Mac installer. The Syncfusion<sup>®</sup> Mac installer can be used for development purposes without registering the unlock key.

5. Open the folder to explore the Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> Mac installer.

   ![Essential Studio Mac installer in the Applications folder](images/Mac_Installer5.png)

6. To remove the DMG file, right-click the virtual drive on your desktop or in the Finder sidebar and select **Eject**. Also delete the installer file from the Applications folder.

   ![Eject the DMG from the Finder sidebar](images/Mac_Installer6.png)

## License key registration in samples

After installation, a license key is required to register the demo source included in the Mac installer. For license registration steps for the .NET MAUI Mac installer, see [How to register the Syncfusion license key in a .NET MAUI application](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application#net-maui).

Register the license key in the [`App.xaml.cs`](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application#net-maui) constructor, before `InitializeComponent()`.

## Troubleshooting

If you encounter issues during installation, see [Installation Errors](https://help.syncfusion.com/maui/installation/installation-errors) for solutions to typical problems.