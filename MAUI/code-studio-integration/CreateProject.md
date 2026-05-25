---
layout: post
title: Create Project using Syncfusion Code Studio | .NET MAUI
description: Learn how to create a .NET MAUI project and add Syncfusion® controls using Code Studio.
platform: MAUI
component: Common
documentation: ug
---

# Creating a .NET MAUI Project with Syncfusion® Controls

This section explains how to create a .NET MAUI project in Syncfusion® Code Studio and integrate Syncfusion® controls using NuGet packages.

Due to Code Studio being a standalone IDE, Syncfusion® templates are not available through extensions. Instead, you can create a standard .NET MAUI project and add Syncfusion® controls via NuGet package installation.

---

## Step 1 - Create a New .NET MAUI Project

Follow the steps below to open your project and start working inside the Code Studio environment.

1. Open the application based on your OS
    * Windows: Go to the Start Menu, search for Syncfusion Code Studio, and launch it.
    * macOS: Open Applications or Launchpad, find Syncfusion Code Studio, and open it.
2. Access the File Menu - At the top menu bar, click “File”.

3. Select “Open Folder”

4. Choose your project folder

5. Or you can directly open your project folder using ‘Open Folder’ button under the Code Studio logo

---

### Result

Your selected project will open in the editor where you can:

* Browse files in the Explorer sidebar
* Edit and create source files
* Use AI-powered features like Chat, Autocomplete, Agent, Edit, and Quick Fix

<img src="code-studio-integration/Images/openfolder.png" alt="Open Folder" />

## Step 2 - Add Syncfusion® NuGet Packages

1. Open the **Solution Explorer**.  

2. Right-click on the project and select **Manage NuGet Packages**.  

    ![Manage NuGet](code-studio-integration/Images/manage-nuget.png)

3. Browse for required Syncfusion® packages (for example, `Syncfusion.Maui.Controls`).  

4. Select the required package and click **Install**.  

    ![Install Package](code-studio-integration/Images/install-package.png)

5. Wait for the installation to complete successfully.  

---

## Step 3 - Register Syncfusion® License

After adding the NuGet package, register your Syncfusion® license.

1. Open the `MauiProgram.cs` file.  

2. Add the following code inside the `CreateMauiApp` method:

```csharp
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

```

Replace "YOUR LICENSE KEY" with your valid license key.

N> For more details on generating and registering the license key, refer to:
https://help.syncfusion.com/common/essential-studio/licensing/overview

---

## Step 4 - Add a Syncfusion® Control

Open the MainPage.xaml file.

Declare the Syncfusion namespace:
```csharp
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
``
Add a control:

```xml
<syncfusion:SfDataGrid Text="Syncfusion DataGrid" />
```

### Step 5 - Build and Run the Application


1. Build the project.

2. Run the application using Run > Start Debugging or press F5.

3. Verify that the Syncfusion® control is rendered correctly.


You have successfully created a .NET MAUI project using Syncfusion® Code Studio and added Syncfusion® controls via NuGet. You can continue enhancing your application by adding more controls and features as needed.
