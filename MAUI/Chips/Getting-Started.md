---
layout: post
title: Getting Started with .NET MAUI Chips control | Syncfusion
description: Learn here about getting started with Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: maui
control: Chips
documentation: ug
---

# Getting Started with .NET MAUI Chips

This section guides you through setting up and configuring a [Chips](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html) in your .NET MAUI application. Follow the steps below to add a basic Chips to your project.

To quickly get started with the .NET MAUI Chips, watch this video.

{% youtube "https://www.youtube.com/watch?v=hr4GmmvS9EE" %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Handler 

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace AutocompleteSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }      
    }
}   

{% endhighlight %} 

## Step 4: Add a Basic Chips control

Step 1: Add the NuGet to the project

Step 2: Add the namespace as shown in the following code snippet

{% tabs %}

{% highlight xaml %}

    xmlns:chip="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

Step 3: Set the control to content in `ContentPage.`

## For SfChip

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>    
    <chip:SfChip x:Name="chips" />
</ContentPage.Content>

{% endhighlight %}

{% highlight c# %}
          
SfChip chips = new SfChip(); 
Content = chips;  

{% endhighlight %}

{% endtabs %}

## For SfChipGroup

Initialize an empty [`SfChipGroup`] as shown in the following code snippet

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>
	<Grid>
		<chip:SfChipGroup/>
	</Grid>
</ContentPage.Content>


{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

	Grid grid = new Grid();
	SfChipGroup chipGroup = new SfChipGroup();
	grid.Children.Add(chipGroup);
	this.Content = grid;
		
{% endhighlight %}

{% endtabs %}

## Set layout for the control

The chips control creates chip for each object and arranges chips in a StackLayout with horizontal orientation. Any layout can be used to arrange the chips in the chips control.In the following example, the `FlexLayout` has been used. 

{% tabs %}

{% highlight xaml %}

<ContentPage.Content>
	<Grid>
		<chip:SfChipGroup DisplayMemberPath="Name">
			<chip:SfChipGroup.ChipLayout>
				<FlexLayout 
					HorizontalOptions="Start" 
					VerticalOptions="Center" 
					/> 
			</chip:SfChipGroup.ChipLayout>
		</chip:SfChipGroup> 
	</Grid>
</ContentPage.Content>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

	Grid grid = new Grid();
	SfChipGroup chipGroup = new SfChipGroup();
	chipGroup.DispalyMemberpath="Name",
	grid.Children.Add(chipGroup);
	FlexLayout layout = new FlexLayout()
	{
		HorizontalOptions = LayoutOptions.Start,
		VerticalOptions = LayoutOptions.Center,
	};
	chipGroup.ChipLayout = layout;
	this.Content = grid;
		
{% endhighlight %}

{% endtabs %}

## Populating business objects

Now, define a simple data model of person with the name and image properties. Create a view model class and initialize a collection of persons as shown in the following code sample.

{% highlight c# %}

namespace Chips
{
	//Model class for chips
	public class Person
	{
		public string Name
		{
			get;
			set;
		}
	}
}

{% endhighlight %}

{% highlight c# %}

using System.Collections.ObjectModel;
using System.ComponentModel;
namespace Chips
{
	//View model class for chips
	public class ViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<Person> employees;
		public ObservableCollection<Person> Employees
		{
			get { return employees; }
			set { Employees = value; OnPropertyChanged("Employees"); }
		}

		public ViewModel()
		{
			employees = new ObservableCollection<Person>();
			employees.Add(new Person() { Name = "John" });
			employees.Add(new Person() { Name = "James" });
			employees.Add(new Person() { Name = "Linda" });
			employees.Add(new Person() { Name = "Rose" });
			employees.Add(new Person() { Name = "Mark" });
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(property));
			}
		}
	}
}

{% endhighlight %}

Create an instance of ViewModel class,and then set it as the `BindingContext`. Bind the `ItemsSource` property with a collection, and then set the `DisplayMemberPath` property:

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
	<local:ViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>
<ContentPage.Content>
	<Grid>
		<chip:SfChipGroup 
			ItemsSource="{Binding Employees}" 
			ChipPadding="8,8,0,0" 
			DisplayMemberPath="Name"
			ChipBackground="white"
			ChipTextColor="Black"
			HorizontalOptions="Start" 
			VerticalOptions="Center">
		</chip:SfChipGroup>  
	</Grid>
</ContentPage.Content>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;

	Grid grid = new Grid();
	SfChipGroup chipGroup = new SfChipGroup();
	grid.Children.Add(chipGroup);
	this.BindingContext = new ViewModel();
	chipGroup.SetBinding(SfChipGroup.ItemsSourceProperty, "Employees");
	chipGroup.DisplayMemberPath = "Name";
	chipGroup.HorizontalOptions = LayoutOptions.Start;
	chipGroup.VerticalOptions = LayoutOptions.Center;
	chipGroup.ChipTextColor = Colors.Black;
	chipGroup.ChiBackground = Colors.White;
	chipGroup.ChipPadding = new Thickness(8, 8, 0, 0);
	this.Content = grid;
		
{% endhighlight %}

{% endtabs %}

![ChipGroup sample with display member path and itemsSource demo](images/getting-started/getting_started.png)

## Set types of chip group

The functionality of chips control differ based on its [ChipType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipType) property.
By default type of chips control have Input type. Input chip types have close button, using it chip can be can removed dynamically from children and the layout.

The following code example uses the [Action](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Action) type. In Action type, [Command](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_Command) property of [SfChipGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html) is executed when any chip in the group is tapped. Here the Employee name of corresponding chip is set as label text when the Command is executed.

{% tabs %}

{% highlight xaml %}

<ContentPage.BindingContext>
	<local:ViewModel/>
</ContentPage.BindingContext>
<ContentPage.Content>
	<StackLayout>
		<chip:SfChipGroup
			Command="{Binding ActionCommand}" 
			ItemsSource="{Binding Employees}"
			DisplayMemberPath="Name"
			ChipType="Action">
		</chip:SfChipGroup>
		<StackLayout Orientation="Horizontal">
		<Label 
			Text="Name:" 
			FontAttributes="Bold" 
			FontSize="14" />
		<Label 
			Text="{Binding Result}"
			FontAttributes="Bold" 
			FontSize="14" />
		</StackLayout>
	</StackLayout>  
</ContentPage.Content>


{% endhighlight %}

{% highlight c# %}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Chips
{
	public class ViewModel :INotifyPropertyChanged
	{
		private ICommand actionCommand;

		private ObservableCollection<Person> employees;

		private string result;

		public ICommand ActionCommand
    	{
			get { return actionCommand; }
			set { actionCommand = value; }
    	}
    
    	public ObservableCollection<Person> Employees
    	{
        	get { return employees; }
        	set { Employees = value; OnPropertyChanged("Employees"); }
    	}

		public string Result
		{
			get { return result; }
			set { result = value; OnPropertyChanged("Result"); }
		}

		public ViewModel()
		{
			ActionCommand = new Command(HandleAction);
			employees = new ObservableCollection<Person>();
			employees.Add(new Person() { Name = "John" });
			employees.Add(new Person() { Name = "James" });
			employees.Add(new Person() { Name = "Linda" });
			employees.Add(new Person() { Name = "Rose" });
			employees.Add(new Person() { Name = "Mark" });
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(property));
			}
		}

		private void HandleAction(object obj)
		{
			Result = (obj as Person).Name.ToString();
		}
	}
}

{% endhighlight %}

{% endtabs %}

![ChipGroup sample with display member path and itemsSource demo](images/getting-started/action.png)

N> You can find the getting started sample of .NET MAUI SfChipGroup from this [link.](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-Chips)

N> You can refer to our [.NET MAUI Chips](https://www.syncfusion.com/maui-controls/maui-chips) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Chips Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Chips) that shows you how to render the Chips in .NET MAUI.
