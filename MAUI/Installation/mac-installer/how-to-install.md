---
layout: post
title: Installing Syncfusion® .NET MAUI Mac installer - Syncfusion®
description: Learn how to install Syncfusion® .NET MAUI Mac installer after downloading from our Syncfusion® website.
platform: MAUI
control: Installation and Deployment
documentation: UG
---

# Steps to Resolve the Warning Message in Catalina OS or Later

   While running .NET MAUI Mac Installers on Catalina macOS or later, the below alert will be displayed.

   ![Alert](images/Mac_Catalina_MacOS_Alert1.png)  
     
   If you receive this alert, follow the below steps for the easiest solution.   

   1.	Right-click the downloaded DMG file.
   2.	Select the "Open With" option and choose "DiskImageMounter (Default)". The following pop-up appears.

		![Pop-up](images/Mac_Catalina_MacOS_Alert2.png)

   3.	Click "Open" to access the installer window.

## Step-by-Step installation

The steps below show how to install .NET MAUI Mac installer.

1. Locate the downloaded DMG file and open it by double-clicking.

   ![Welcome wizard](images/Mac_Installer1.png)

2. This action will mount the disk image and create a virtual drive on your desktop or in the Finder sidebar.

   ![License agreement](images/Mac_Installer2.png)
   
3. Copy the mounted disk file.

   ![License agree confirmation](images/Mac_Installer3.png)
   
4. Paste it into the "Applications" folder shortcut.

   ![License agree confirmation](images/Mac_Installer4.png)
   
   N> An Unlock key is not required to install the Mac installer. The Syncfusion<sup>®</sup> Mac installer can be used for development purposes without registering the Unlock key.


5. Open the folder to explore the Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> Mac installer.

   ![Destination](images/Mac_Installer5.png)

6. To remove the DMG file, right-click on the virtual drive on your desktop or in the Finder sidebar and select "Eject." Also delete the folder from the Applications.

   ![Install location](images/Mac_Installer6.png)

## License key registration in samples

After the installation, a license key is required to register the demo source included in the Mac installer. To learn about license registration for the .NET MAUI Mac installer, please refer to this.

Register the license key in [App.xaml.cs](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application#net-maui) constructor before InitializeComponent().