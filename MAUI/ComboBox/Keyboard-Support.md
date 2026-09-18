---
layout: post
title: Keyboard Support in .NET MAUI ComboBox | Syncfusion®
description: Learn how to configure and customize the keyboard displayed in the Syncfusion® .NET MAUI ComboBox control for different data entry requirements.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox keyboard, sfcombobox keyboard support, syncfusion combobox numeric keyboard, .net maui combobox email keyboard
---

# Keyboard Support in .NET MAUI ComboBox

## Overview

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control supports the `Keyboard` property. Use it to select the keyboard displayed when the editable ComboBox editor receives focus.

## XAML Example

The following example configures an editable ComboBox for alphanumeric employee ID entry while displaying employee names.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="employeeId"
                    IsEditable="True"
                    Placeholder="Enter an employee ID"
                    Keyboard="Text"
                    DisplayMemberPath="Name"
                    TextMemberPath="ID"
                    ItemsSource="{Binding Employees}" />

{% endhighlight %}
{% highlight C# %}

var viewModel = new EmployeeViewModel();

var employeeId = new SfComboBox
{
    IsEditable = true,
    Placeholder = "Enter an employee ID",
    Keyboard = Keyboard.Text,
    DisplayMemberPath = "Name",
    TextMemberPath = "ID",
    ItemsSource = viewModel.Employees
};

Content = employeeId;

{% endhighlight %}
{% highlight C# tabtitle="ViewModel" %}

using System.Collections.ObjectModel;

public class Employee
{
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public string Designation { get; set; }
    public string ID { get; set; }
}

public class EmployeeViewModel
{
    public ObservableCollection<Employee> Employees { get; set; }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Employee>
        {
            new Employee
            {
                Name = "Anne Dodsworth",
                ProfilePicture = "people_circle1.png",
                Designation = "Developer",
                ID = "E001"
            },
            new Employee
            {
                Name = "Andrew Fuller",
                ProfilePicture = "people_circle8.png",
                Designation = "Team Lead",
                ID = "E002"
            }
        };
    }
}

{% endhighlight %}
{% endtabs %}