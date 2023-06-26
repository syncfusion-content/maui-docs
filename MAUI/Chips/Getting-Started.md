---
layout: post
title: Getting Started with .NET MAUI Chips control | Syncfusion
description: Learn here about getting started with Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: .NET MAUI
control: Chips
documentation: ug
---

# Getting Started with .NET MAUI Chips

This section explains the steps required to create chips and arrange them in a layout for performing action. This section covers only the minimal features that you needed to know to get started with the chips.

## Adding .NET MAUI Chips reference

Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add Chips to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core), and then install it.

## Handler Registration

In the MauiProgram.cs file, register the handler for Syncfusion core.

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

### Adding the .NET MAUI Chips control

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

The functionality of chips control differ based on its [`ChipType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipType) property.
By default type of chips control have Input type. Input chip types have close button, using it chip can be can removed dynamically from children and the layout.

The following code example uses the [`Action`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html#Syncfusion_Maui_Core_SfChipsType_Action) type. In Action type, [`Command`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_Command) property of [`SfChipGroup`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html) is executed when any chip in the group is tapped. Here the Employee name of corresponding chip is set as label text when the Command is executed.

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


