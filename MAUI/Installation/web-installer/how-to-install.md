---
layout: post
title: Installing Syncfusion .NET MAUI web installer | Syncfusion
description: Learn how to install the Syncfusion .NET MAUI web installer after downloading it from the Syncfusion website.
platform: MAUI
control: Installation and Deployment
documentation: UG
---

# Installing Syncfusion<sup>®</sup> .NET MAUI web installer

**Applies to:** Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI Web Installer on Windows.

For the Essential Studio<sup>®</sup> .NET MAUI product, Syncfusion<sup>®</sup> offers a web installer. This installer alleviates the burden of downloading a larger installer: you can simply download and run the online installer, which is smaller in size and will download and install the Essential Studio<sup>®</sup> products you have chosen. You can get the most recent version of the Essential Studio<sup>®</sup> web installer [here](https://www.syncfusion.com/account/downloads).

## Prerequisites

* Windows 10 or later (64-bit) with the latest Windows updates.
* An active internet connection. The web installer downloads the selected products at install time.
* Administrator rights on the machine (right-click the installer `.exe` and choose **Run as administrator**).
* A Syncfusion<sup>®</sup> account with a valid trial or licensed subscription. To create one, see [Create a Syncfusion account](https://www.syncfusion.com/account/register).
* A free disk space of at least 3 GB (the exact size is shown on the installer's **Download Size** and **Installation Size** links).

## Installation

Follow these steps to install the Essential Studio<sup>®</sup> .NET MAUI Web Installer:

1.  **Open installer:** Double-click the downloaded Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI Web Installer file to launch the Installer Wizard, which automatically extracts the package.

    ![Installer extraction wizard](images/Step-by-Step-Installation_img1.png)


    N> The installer wizard extracts the `syncfusionessentialmauiwebinstaller_{version}.exe` dialog, which displays the package's unzip operation.

2. 	**Welcome wizard:** The welcome dialog for the Syncfusion<sup>®</sup> .NET MAUI Web Installer will appear. Click the **Next** button.

    ![Web installer welcome wizard](images/Step-by-Step-Installation_img2.png)

  
3.  **Platform selection wizard:** Select the products to install from the **Available** tab. Use the **Install All** check box to select all products.

	**Available**

	![Platform selection wizard, Available tab](images/Step-by-Step-Installation_img3.png)

	If multiple products are installed in the same version, the **Installed** tab lists them. You can select which products to uninstall for the same version. Click **Next** to proceed.

	**Installed**

    ![Platform selection wizard, Installed tab](images/Step-by-Step-Installation_img24.png)

	N> If the required software for the selected product isn't installed, an **Additional Software Required** alert appears. You can continue and install the necessary software later.

	**Required software**

	![Additional software required alert](images/Step-by-Step-Installation_img5.png)


4.	**Uninstall previous versions:** If prior versions are installed for the selected products, an uninstall wizard displays a list of previously installed versions. Use the **Uninstall All** check box to select all versions for removal. Click **Next**.

	![Uninstall previous version wizard](images/Step-by-Step-Installation_img20.png)

	N> From the 2021 Volume 1 release, there is an option to uninstall previous versions from 18.1 while installing the new version.

5.	**Confirmation wizard:** Confirm the uninstallation of selected previous versions.

	![Confirmation pop-up to uninstall previous versions](images/Step-by-Step-Installation_img21.png)


6. 	**Product installation confirmation:** Modify the list of products to install/uninstall as needed and confirm.

    ![Confirmation wizard with list of products](images/Step-by-Step-Installation_img15.png)

	N> Click the **Download Size** and **Installation Size** links to approximate the download and installation size.


7.  **Configuration wizard:** Customize download, install, and demo locations, and adjust the additional settings per product. Click **Next** to install with the default settings.

    ![Configuration wizard with download, install, and demos locations](images/Step-by-Step-Installation_img8.png)

	**Additional settings**

    * Check the **Install Demos** check box to install Syncfusion<sup>®</sup> samples, or leave it unchecked if not needed.
    * Select the **Configure Syncfusion<sup>®</sup> controls in Visual Studio** check box to configure the Syncfusion<sup>®</sup> controls in the Visual Studio toolbox, or clear this check box when you do not want to configure the Syncfusion<sup>®</sup> controls in the Visual Studio toolbox during installation. Note that you must also select the **Register Syncfusion<sup>®</sup> assemblies in GAC** check box when you select this check box.
    * Select the **Configure Syncfusion<sup>®</sup> Extensions controls in Visual Studio** check box to configure the Syncfusion<sup>®</sup> Extensions in Visual Studio, or clear this check box when you do not want to configure the Syncfusion<sup>®</sup> Extensions in Visual Studio.
    * Check the **Create Desktop Shortcut** check box to add a desktop shortcut for the Syncfusion<sup>®</sup> Control Panel.
    * Check the **Create Start Menu Shortcut** check box to add a shortcut to the Start menu for the Syncfusion<sup>®</sup> Control Panel.

8.  **License terms:** Read thoroughly and check **I agree to the License Terms and Privacy Policy**. Click **Next**.

9.  **Login:** The login wizard will appear. You must enter your Syncfusion<sup>®</sup> email address and password. If you do not already have a Syncfusion<sup>®</sup> account, you can create one by clicking **Create an Account**. If you have forgotten your password, click **Forgot Password** to create a new one. Click the **Install** button.

    ![Login wizard with email and password fields](images/Step-by-Step-Installation_img9.png)

	I> Products will install based on your Syncfusion<sup>®</sup> license (Trial or Licensed).

10. **Progress display:** The progress of the download, installation, and uninstallation will be displayed.

    ![Download and installation progress](images/Step-by-Step-Installation_img10.png)

11. **Summary wizard:** When the installation is finished, the **Summary** wizard will appear. Here you can see the list of products that have been installed successfully and those that have failed. To close the Summary wizard, click **Finish**.

    ![Installation summary wizard](images/Step-by-Step-Installation_img11.png)

	* To open the Syncfusion<sup>®</sup> Control Panel, click **Launch Control Panel**.

12. **Control panel entries:** After installation, there will be two Syncfusion<sup>®</sup> Control Panel entries, as shown below. The Essential Studio<sup>®</sup> entry will manage all Syncfusion<sup>®</sup> products installed in the same version, while the Product entry will only uninstall the specific platform setup.

    ![Syncfusion Control Panel entries](images/Step-by-Step-Installation_img19.png)
	
## Uninstallation

The Syncfusion<sup>®</sup> .NET MAUI installer can be uninstalled in two ways.

* Uninstall using the Syncfusion<sup>®</sup> .NET MAUI web installer.
* Uninstall from the Windows Control Panel.

Follow either option below to uninstall the Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI installer.

**Option 1: Uninstall using the Syncfusion<sup>®</sup> .NET MAUI Web Installer**

Syncfusion<sup>®</sup> allows you to uninstall products of the same version directly from the Web Installer application. Select the products to be uninstalled from the list, and the Web Installer will uninstall them one by one.

![Web installer platform selection showing installed products](images/Step-by-Step-Installation_img4.png)

**Option 2: Uninstall from Windows Control Panel**

You can uninstall all installed products by selecting the **Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> {version}** entry (element 1 in the screenshot below) from the Windows Control Panel, or you can uninstall .NET MAUI alone by selecting the **Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> for .NET MAUI {version}** entry (element 2 in the screenshot below) from the Windows Control Panel.

![Windows Control Panel showing Syncfusion entries](images/Step-by-Step-Installation_img22.png)

N> If the **Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> for .NET MAUI {version}** entry is selected from the Windows Control Panel, only the Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI will be removed, and the default MSI uninstallation window will be displayed.


1.  **Welcome wizard:** The Syncfusion<sup>®</sup> .NET MAUI Web Installer's welcome wizard will be displayed. Click the **Next** button.

    ![Welcome wizard for uninstallation](images/Step-by-Step-Installation_img2.png)

2.  **Platform selection wizard:** From the **Installed** tab, select the products to be uninstalled. To select all products, check the **Uninstall All** check box. Click the **Next** button.

	**Installed**

	![Platform selection wizard, Installed tab for uninstallation](images/Step-by-Step-Installation_img4.png)

	You can also select the products to be installed from the **Available** tab. Click the **Next** button.

	**Available**

	![Platform selection wizard, Available tab for uninstallation](images/Step-by-Step-Installation_img25.png)

3.  If other products are selected for installation, an **Uninstall previous version** wizard will be displayed with previous version(s) installed for the selected products. View the list of installed previous versions for the selected products. Select the **Uninstall All** check box to select all versions. Click **Next**.

	![Uninstall previous version wizard during uninstallation](images/Step-by-Step-Installation_img26.png)

4.	A pop-up screen will be displayed to confirm the uninstallation of selected previous versions.

	![Confirmation pop-up to uninstall previous versions](images/Step-by-Step-Installation_img21.png)

5.  **Confirmation wizard:** This wizard will appear with the list of products to be uninstalled or installed. You can view and modify the list of products that will be uninstalled or installed.

    ![Confirmation for install or uninstall](images/Step-by-Step-Installation_img15.png)

	N> By clicking the **Download Size** and **Installation Size** links, you can determine the approximate size of the download and installation.

6.	**Configuration wizard:** Change the **Download**, **Install**, and **Demos** locations from here. You can also change the additional settings on a product-by-product basis. Click **Next** to install with the default settings.

    ![Configuration wizard for install or uninstall](images/Step-by-Step-Installation_img23.png)

7.	**License terms:** After reading the License Terms and Conditions, check the **I agree to the License Terms and Privacy Policy** check box. Click the **Next** button.

8.	**Login wizard:** Enter your Syncfusion<sup>®</sup> email address and password. If you do not have a Syncfusion<sup>®</sup> account, you can create one by clicking **Create an Account**. If you have forgotten your password, click **Forgot Password** to create a new one. Click the **Install** button.

    ![Login wizard for install or uninstall](images/Step-by-Step-Installation_img9.png)

	N> The products you have chosen will be installed or uninstalled based on your Syncfusion<sup>®</sup> license (Trial or Licensed).

9.	The download, installation, and uninstallation progress will be displayed.

    ![Download, installation, and uninstallation progress](images/Step-by-Step-Installation_img17.png)

10.	**Summary wizard:** Once the installation is finished, the **Summary** wizard will appear. Here, you can see the list of products that have been successfully and unsuccessfully installed or uninstalled. Click **Finish** to close the Summary wizard.

    ![Summary wizard for install or uninstall](images/Step-by-Step-Installation_img18.png)

	* To open the Syncfusion<sup>®</sup> Control Panel, click **Launch Control Panel**.

## Troubleshooting

If you encounter issues during installation, see [Installation Errors](https://help.syncfusion.com/maui/installation/installation-errors) for solutions to typical problems such as license key mismatch, blocked installations, and controlled folder access.