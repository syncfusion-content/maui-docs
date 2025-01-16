---
layout: post
title: Installation Errors of Essential Studio® | .NET MAUI |Syncfusion®
description: Learn here some information about the Essential Studio® installation errors and steps for resolving it.
platform: maui
control: Installation and Deployment
documentation: ug

---

# Common Installation Errors

This article describes the most common installation errors, as well as the causes and solutions to those errors.

* [Unlocking the license installer using the trial key](https://help.syncfusion.com/maui/installation/installation-errors#unlocking-the-license-installer-using-the-trial-key)
* [License has expired](https://help.syncfusion.com/maui/installation/installation-errors#license-has-expired)
* [Unable to find a valid license or trial](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-find-a-valid-license-or-trial)
* [Unable to install because of another installation](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-install-because-of-another-installation)
* [Unable to install due to controlled folder access](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-install-due-to-controlled-folder-access)

## Unlocking the license installer using the trial key

### Problem

**Error Message:** Sorry, the provided unlock key is a trial unlock key and cannot be used to unlock the licensed version of our Essential Studio<sup>®</sup> for .NET MAUI installer.

![Alert Message](Errors/Installation_Errors_img1.png)

### Reason

You are attempting to use a Trial unlock key to unlock the licensed installer.

### Suggested solution

Only a licensed unlock key can unlock a licensed installer. So, to unlock the Licensed installer, use the Licensed unlock key. To generate the licensed unlock key, refer to [this](https://support.syncfusion.com/kb/article/2757/how-to-generate-syncfusion-setup-unlock-key-from-syncfusion-support-account) article.


## License has expired

### Problem

**Error Message:** Your license for Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> for .NET MAUI has been expired since {date}. Please renew your subscription and try again.

**Online Installer**

![Warning Message](Errors/Installation_Errors_img2.png)

### Reason

This error message will appear if your license has expired.

### Suggested solution

You can choose from the options listed below. 

1. You can renew your subscription [here](https://www.syncfusion.com/account/my-renewals). 
2. You can get a new license [here](https://www.syncfusion.com/sales/products). 
3. You can reach out to our sales team by emailing <sales@syncfusion.com>. 
4. You can also extend the 30-day trial period after your trial license has expired.


## Unable to find a valid license or trial

### Problem

**Error Message:** Sorry, we are unable to find a valid license or trial for Essential Studio<sup>®</sup> for .NET MAUI under your account.

<em>**Offline installer**</em>

![Alert Message](Errors/Installation_Errors_img3.PNG)

<em>**Online installer**</em>

![Warning Message](Errors/Installation_Errors_img6.PNG)

### Reason

The following are possible causes of this error:

* When your trial period expired
* When you don't have a license or an active trial
* You are not the license holder of your license 
* Your account administrator has not yet assigned you a license.

### Suggested solution

You can choose from the options listed below. 

1. You can get a new license [here](https://www.syncfusion.com/sales/products). 
2. Contact your account administrator. 
3. Send an email to  <clientrelations@syncfusion.com> to request a license. 
4. You can reach out to our sales team by emailing  <sales@syncfusion.com>.

## Unable to install because of another installation

### Problem

**Error Message:** Another installation is in progress. You cannot start this installation without completing all other currently active installations. Click cancel to end this installer or retry to attempt after currently active installation completed to install again.

![Warning Message](Errors/Installation_Errors_img4.png)

### Reason

You are trying to install when another installation is already running in your machine.

### Suggested solution

Open and kill the msiexec process in the task manager and then continue to install Syncfusion<sup>®</sup>. If the problem is still present, restart the computer and try Syncfusion<sup>®</sup> installer. 

1. Open the Windows Task Manager.

2. Browse the Details tab.

3. Select the msiexec.exe and click **End task**.

![Task Manager](Errors/Installation_Errors_img5.png)

## Unable to install due to controlled folder access

### Problem

#### Offline:

**Error Message:** Controlled folder access seems to be enabled in your machine. The provided install or samples location (e.g., Public Documents) is protected by the controlled folder access settings.

![Warning Message](Errors/Installation_Errors_img7.png)

#### Online:

**Error Message:** Controlled folder access seems to be enabled in your machine. The provided install, samples, or download location (e.g., Public Documents) is protected by the controlled folder access settings.

![Warning Message](Errors/Installation_Errors_img8.png)

### Reason

You have enabled controlled folder access settings on your computer.

### Suggested solution

**Suggestion 1:**

1.	We will ship our demos in the public documents folder by default. 
2.	You have controlled folder access enabled on your machine, so our demos cannot be installed in the documents folder. If you need to install our demos in the Documents folder, follow the steps in this [link](https://support.microsoft.com/en-us/windows/allow-an-app-to-access-controlled-folders-b5b6627a-b008-2ca2-7931-7e51e912b034) and disable the controlled folder access.
3.	You can enable this option after the installing our Syncfusion<sup>®</sup> setup.

**Suggestion 2:**

1.	If you do not want to disable controlled folder access, you can install our demos in another directory.
