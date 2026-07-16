---
layout: post
title: Installation Errors of Essential Studio .NET MAUI | Syncfusion
description: Learn about common installation errors for Syncfusion Essential Studio .NET MAUI and the steps to resolve them.
platform: MAUI
control: Installation and Deployment
documentation: UG

---

# Common Installation Errors

**Applies to:** Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> .NET MAUI installers (Online and Offline) on Windows.

This article describes the most common installation errors, their causes, and solutions.

* [Unlocking the license installer using the trial key](https://help.syncfusion.com/maui/installation/installation-errors#unlocking-the-license-installer-using-the-trial-key)
* [License has expired](https://help.syncfusion.com/maui/installation/installation-errors#license-has-expired)
* [Unable to find a valid license or trial](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-find-a-valid-license-or-trial)
* [Unable to install because of another installation](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-install-because-of-another-installation)
* [Unable to install due to controlled folder access](https://help.syncfusion.com/maui/installation/installation-errors#unable-to-install-due-to-controlled-folder-access)

## Unlocking the license installer using the trial key

### Problem

**Error message:** Sorry, the provided unlock key is a trial unlock key and cannot be used to unlock the licensed version of our Essential Studio<sup>®</sup> for .NET MAUI installer.

![Trial unlock key used on licensed installer dialog](Errors/Installation_Errors_img1.png)

### Reason

You are attempting to use a trial unlock key to unlock the licensed installer.

### Suggested solution

Only a licensed unlock key can unlock a licensed installer. To unlock the licensed installer, use the licensed unlock key. To generate the licensed unlock key, refer to this [article](https://support.syncfusion.com/kb/article/2757/how-to-generate-syncfusion-setup-unlock-key-from-syncfusion-support-account).


## License has expired

### Problem

**Error Message:** Your license for Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> for .NET MAUI has been expired since &lt;date&gt;. Please renew your subscription and try again.

> Note: `&lt;date&gt;` is replaced with the actual expiry date when the message is shown to the user.

**Online installer**

![Online installer license expired dialog](Errors/Installation_Errors_img2.png)

### Reason

This error message will appear if your license has expired.

### Suggested solution

You can choose from the options listed below.

1. Renew your subscription [here](https://www.syncfusion.com/account/my-renewals).
2. Get a new license [here](https://www.syncfusion.com/sales/products).
3. Reach out to our sales team by emailing <sales@syncfusion.com>.
4. Extend the 30-day trial period before it expires.


## Unable to find a valid license or trial

### Problem

**Error message:** Sorry, we are unable to find a valid license or trial for Essential Studio<sup>®</sup> for .NET MAUI under your account.

***Offline installer***

![Offline installer unable to find a valid license or trial dialog](Errors/Installation_Errors_img3.PNG)

***Online installer***

![Online installer unable to find a valid license or trial dialog](Errors/Installation_Errors_img6.PNG)

### Reason

The following are possible causes of this error:

* Your trial period has expired.
* You do not have a license or an active trial.
* You are not the license holder of your license.
* Your account administrator has not yet assigned you a license.

### Suggested solution

You can choose from the options listed below.

1. Get a new license [here](https://www.syncfusion.com/sales/products).
2. Contact your account administrator.
3. Send an email to <clientrelations@syncfusion.com> to request a license.
4. Reach out to our sales team by emailing <sales@syncfusion.com>.

## Unable to install because of another installation

### Problem

**Error message:** Another installation is in progress. You cannot start this installation without completing all other currently active installations. Click cancel to end this installer or retry after currently active installation have completed.

![Another installation in progress dialog](Errors/Installation_Errors_img4.png)

### Reason

You are trying to install while another installation is running on your machine.

### Suggested solution

To resolve the issue, end the active `msiexec.exe` process using Task Manager, then run the Syncfusion<sup>®</sup> installer again. If the problem persists, restart the computer and try again.

1. Open Windows Task Manager.

2. Go to the **Details** tab.

3. Select **msiexec.exe** (it may appear as **msiexec.exe *32** on 64-bit systems) and click **End task**.

![End msiexec.exe task in Windows Task Manager Details tab](Errors/Installation_Errors_img5.png)

## Unable to install due to controlled folder access

### Problem

#### Offline

**Error message:** Controlled folder access is enabled on your machine. The provided install or samples location (e.g., Public Documents) is protected by the controlled folder access settings.

![Offline installer controlled folder access blocked dialog](Errors/Installation_Errors_img7.png)

#### Online

**Error message:** Controlled folder access is enabled on your machine. The provided install, samples, or download location (e.g., Public Documents) is protected by the controlled folder access settings. (The Online installer references the additional download location, while the Offline installer does not.)

![Online installer controlled folder access blocked dialog](Errors/Installation_Errors_img8.png)

### Reason

Controlled folder access is enabled on your machine.

### Suggested solution

**Suggestion 1:**

1. Our demos are installed in the Public Documents folder by default.
2. Controlled folder access is enabled on your machine, so the demos cannot be installed in the Documents folder. If you need to install the demos in the Documents folder, follow the steps in this [link](https://support.microsoft.com/en-us/windows/allow-an-app-to-access-controlled-folders-b5b6627a-b008-2ca2-7931-7e51e912b034) and disable controlled folder access. You can also allow the Syncfusion installer through Controlled Folder Access instead of disabling it entirely.
3. You can re-enable controlled folder access after installing the Syncfusion<sup>®</sup> installer.

**Suggestion 2:**

1. If you do not want to disable controlled folder access, install the demos in another directory. In the installer, click **Browse** on the install location screen and choose a folder that is not protected by controlled folder access.
