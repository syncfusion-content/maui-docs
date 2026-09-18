---
layout: post
title: Keyboard Support in .NET MAUI Autocomplete | Syncfusion®
description: Learn how to configure the keyboard displayed by the Syncfusion® .NET MAUI Autocomplete editor.
platform: maui
control: SfAutocomplete
documentation: ug
keywords: .net maui autocomplete keyboard, sfautocomplete keyboard support, syncfusion autocomplete numeric keyboard, .net maui autocomplete email keyboard
---

# Keyboard Support in .NET MAUI Autocomplete

## Overview

The [SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control supports the `Keyboard` property. Use it to select the keyboard displayed when the editor receives focus based on the expected input.

## XAML Example

The following example displays a text keyboard for an employee name lookup.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="employeeName"
                        Placeholder="Enter an employee name"
                        Keyboard="Text"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        ItemsSource="{Binding Employees}" />

{% endhighlight %}
{% highlight C# %}

var viewModel = new EmployeeViewModel();

SfAutocomplete autocomplete = new SfAutocomplete
{
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    Placeholder = "Enter an employee name",
    Keyboard = Keyboard.Text,
    ItemsSource = viewModel.Employees
};

Content = autocomplete;

{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

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

