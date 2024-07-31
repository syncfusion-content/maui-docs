---
layout: post
title: Overview of Syncfusion license validation in CI services - Syncfusion
description: Learn here about how to register Syncfusion license key for Syncfusion application for license validation.
platform: MAUI
control: Essential Studio
documentation: ug
---

<style>
#license {
    font-size: .88em!important;
margin-top: 1.5em;     margin-bottom: 1.5em;
    background-color: #fbefca;
    padding: 10px 17px 14px
}
</style>


# Syncfusion license key validation in CI services

Syncfusion license key validation in CI services ensures that Syncfusion Essential Studio components are properly licensed during CI processes. Validating the license key at the CI level can prevent licensing errors during deployment. Set up the continuous integration process to fail in case the license key validation fails. Validate the passed parameters and the registered license key again to resolve the issue.

The following section shows how to validate the Syncfusion license key in CI services.

* Download and extract the LicenseKeyValidator.zip utility from the following link: [LicenseKeyValidator](https://s3.amazonaws.com/files2.syncfusion.com/Installs/LicenseKeyValidation/LicenseKeyValidator.zip).

* Open the LicenseKeyValidation.ps1 PowerShell script in a text\code editor.

![LicenseKeyValidation script](licensing-images/license-validation.png)

* Update the parameters in the LicenseKeyValidation.ps1 script file as described below. 

  **Platform:** Modify the value for /platform: to the actual platform "MAUI". 
  
  **Version:**  Change the value for /version: to the required version (e.g., "26.2.4").
  
  **License Key:** Replace the value for /licensekey: with your actual license key (e.g., "Your License Key"). 

## Azure Pipelines (YAML)

* Create a new [User-defined Variable](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/variables?view=azure-devops&tabs=yaml%2Cbatch#user-defined-variables) named `LICENSE_VALIDATION` in Azure Pipeline. Use the path of the LicenseKeyValidation.ps1 script file as a value (e.g., D:\LicenseKeyValidator\LicenseKeyValidation.ps1).

* Integrate the PowerShell task in pipeline and execute the script to validate the license key. 

The following example shows the syntax for Windows build agents.

{% tabs %}
{% highlight c# tabtitle="YAML" %}
pool:
  vmImage: 'windows-latest'

steps:

- task: PowerShell@2
  inputs:
    targetType: filePath
    filePath: $(LICENSE_VALIDATION) #Or the actual path to the LicenseKeyValidation.ps1 script.
  
  displayName: Syncfusion License Validation 
{% endhighlight %}
{% endtabs %}

## Azure Pipelines (Classic)

* Create a new [User-defined Variable](https://learn.microsoft.com/en-us/azure/devops/pipelines/process/variables?view=azure-devops&tabs=yaml%2Cbatch#user-defined-variables) named `LICENSE_VALIDATION` in Azure Pipeline. Use the path of the LicenseKeyValidation.ps1 script file as a value (e.g., D:\LicenseKeyValidator\LicenseKeyValidation.ps1).

* Include the PowerShell task in pipeline and execute the script to validate the license key. 

![LicenseKeyValidation script](licensing-images/license-validation-classic.png)

## GitHub actions

* To execute the script in PowerShell as part of a GitHub Actions workflow, include a step in the configuration file and update the path of the LicenseKeyValidation.ps1 script file (e.g., D:\LicenseKeyValidator\LicenseKeyValidation.ps1).

The following example shows the syntax for validating Syncfusion license key in GitHub actions.

{% tabs %}
{% highlight c# tabtitle="YAML" %}
  steps:
  - name: Syncfusion License Validation
    shell: pwsh
    run: |
	  ./path/LicenseKeyValidator/LicenseKeyValidation.ps1
{% endhighlight %}
{% endtabs %}

## Jenkins

* Create a [Environment Variable](https://www.jenkins.io/doc/pipeline/tour/environment) named 'LICENSE_VALIDATION'. Use Use the path of the LicenseKeyValidation.ps1 script file as a value (e.g., D:\LicenseKeyValidator\LicenseKeyValidation.ps1).

* Include a stage in Jenkins to execute the LicenseKeyValidation.ps1 script in PowerShell. 

The following example shows the syntax for validating Syncfusion license key in Jenkins pipeline.

{% tabs %}
{% highlight json %}
pipeline {
	agent any
	environment {
		LICENSE_VALIDATION = 'path\\to\\LicenseKeyValidator\\LicenseKeyValidation.ps1'
	}
	stages {
		stage('Syncfusion License Validation') {
			steps {
				sh 'pwsh ${LICENSE_VALIDATION}'
			}
		}
	}
}
{% endhighlight %}
{% endtabs %}

## Validate the License Key Using ValidateLicense() Method

* Register the license key properly by calling RegisterLicense("License Key") method with the license key. 

* Once the license key is registered, it can be validated by using ValidateLicense("Platform.MAUI") method. This ensures that the license key is valid for the platform and version you are using. For reference please check the following example.

{% tabs %}
{% highlight c# %}
using Syncfusion.Licensing;

//Register Syncfusion license key 
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

//Validate the registered license key
bool isValid = SyncfusionLicenseProvider.ValidateLicense(Platform.MAUI);
{% endhighlight %}
{% endtabs %}

![LicenseKeyValidationMethod](licensing-images/license-validation-method.png)

* If ValidateLicense() method returns true, registered license key is valid and can proceed with deployment.

* If ValidateLicense() method returns false, there will be invalid license errors in deployment due to either an invalid license key or an incorrect assembly or package version that is referenced in the project. Please ensure that all the referenced Syncfusion assemblies or NuGet packages are all on the same version as the license key’s version before deployment.
