---
layout: post
title: Installing Syncfusion .NET MAUI Mac installer - Syncfusion
description: Learn here about how to install Syncfusion .NET MAUI Mac installer after downloading from our Syncfusion website.
platform: MAUI
control: Installation and Deployment
documentation: ug
---

# Steps to resolve the warning message in Catalina OS or later

   While running .NET MAUI Mac Installers on Catalina MacOS or later, the below alert will be displayed.

   ![Alert Image](images/Mac_Catalina_MacOS_Alert1.png)  
     
   If you receive this alert, follow the below steps for the easiest solution.   

   1.	Right-click the downloaded dmg file.
   2.	Select the "Open With" option and choose "DiskImageMounter (Default)". The following pop-up appears.

		![pop-up Image](images/Mac_Catalina_MacOS_Alert2.png)

   3.	When you click "Open" the installer window will be opened.

## Step-by-Step Installation

The steps below show how to install .NET MAUI Mac installer.

1. Locate the downloaded dmg file and open the file by double click on it.

   ![Welcome wizard](images/Mac_Installer1.png)

2. This action will automatically mount the disk image and create a virtual drive on your desktop or in the Finder sidebar.

   ![License Agreement](images/Mac_Installer2.png)
   
3. Copy the mounted disk file.

   ![License Agree Confirmation](images/Mac_Installer3.png)
   
4. And paste it in "Applications" folder shortcut.

   ![License Agree Confirmation](images/Mac_Installer4.png)
   
   N> The Unlock key is not required to install the Mac installer. The Syncfusion Mac installer can be used for development purposes without registering the Unlock key.


5. Now you can open the folder to explore the Syncfusion Essential Studio Mac installer.

   ![Destination](images/Mac_Installer5.png)

6. To remove the DMG file, Right-click on the virtual drive on your desktop or in the Finder sidebar and select "Eject." Also delete the folder from the Applications.

   ![Install Location](images/Mac_Installer6.png)

## License key registration in samples

After the installation, the license key is required to register the demo source that is included in the Mac installer. To learn about the steps for license registration for the .NET MAUI Mac installer, please refer to this.

Register the license key in [App.xaml.cs](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application#net-maui) constructor before InitializeComponent().