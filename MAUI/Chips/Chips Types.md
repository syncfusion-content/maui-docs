---
layout: post
title: Chips Types in .NET MAUI Chips control | Syncfusion
description: Learn about Chips Types support in Syncfusion Essential Studio .NET MAUI Chips control, its elements and more.
platform: .NET MAUI
control: Chips
documentation: ug
---

# Chips Types in .NET MAUI Chips

## Input

Arranges the chips in a layout and enables the close button for each chip. Using the close button, a chip can be removed from children and layout as well. Additionally, it has support to add an option at the end of the layout, from which users can obtain the chip text for creating a chip at run time.

The following code illustrates how to get an input type chip.

{% highlight xaml %}
<chip:SfChipGroup 
                     Margin="200,100,0,0"  
                     ItemsSource="{Binding Employees}" 
                     DisplayMemberPath="Name" 
                     ChipType="Input">
<chip:SfChipGroup.InputView>
<Entry x:Name="entry"
			VerticalOptions="Center" HeightRequest="40"
			FontSize="15" 
			WidthRequest="110" 
			Completed="entry_Completed"
			Margin="10,10,0,0">
                </Entry>
</chip:SfChipGroup.InputView>

</chip:SfChipGroup>
	
{% endhighlight %}

{% highlight c# %}

[MainPage.cs]
...
private void entry_Completed(object sender, EventArgs e)
{
	var viewModel = this.BindingContext as ViewModel;
	var image = random.Next(1,20);
	var name = (sender as InputView).Text;
	viewModel.InputItems.Add(new Model() {PersonName=name, PersonImage=Images[image]});
	entry.Text = "";
}
..
[Model]

public class Employee
{

    public string Name { get; set; }

}

[ViewModel]

public class EmployeeViewModel : INotifyPropertyChanged
{

    private Employee selectedEmployee;

    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<string> items = new() { "Joseph", "Alazari", "Rocketuh", "Raja" };
    public ObservableCollection<string> Items
    {
        get { return items; }
        set
        {
            items = value;
            OnPropertyChanged(nameof(Items));
        }
    }

    private Employee selectedItem = new() { Name = "Joseph" };

    public Employee SelectedItems { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(nameof(SelectedItems)); } }

    public ObservableCollection<Employee> Employees
    {
        get
        {

         return employees;

        }
        set
        {
            employees = value;
            OnPropertyChanged(nameof(Employees));
        }

    }

     public Employee SelectedEmployee
    {
        get
        {
            return selectedEmployee;
        }
        set
        {
            selectedEmployee = value;
            OnPropertyChanged(nameof(SelectedEmployee));
        }
     }
    public Command ActionCommand { get; set; }

    private void ShowPopup(Object obj)
    {
        if (obj is Employee chip)
        {
            this.Result = chip.Name;
        }
    }

    private string result;
    public string Result
    {
        get { return result; }
        set { result = value; OnPropertyChanged(); }
    }

     public void OnPropertyChanged([CallerMemberName] string name = null) =>

     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public EmployeeViewModel()
    {
        this.Employees = new ObservableCollection<Employee>();

        Employees.Add(new Employee
        {
            Name = "Joseph",

        });

        Employees.Add(new Employee
        {
            Name = "Anne Joseph",

        });
        Employees.Add(new Employee
        {
            Name = "Andrew Fuller",

        });
        Employees.Add(new Employee
        {
            Name = "Emilio Alvaro",

        });
        Employees.Add(new Employee
        {
            Name = "Janet Leverling",

        });

        SelectedEmployee = Employees[0];

    }

}

{% endhighlight %}

![Input type in .NET MAUI SfChipGroup](images/items/Input.png)

## Choice

Allows users to select a single chip from a group of items. Selecting a chip will automatically deselect the previously selected chips. 

Here, we should add visual states to set ChipType to Choice.

The following code illustrates how to get choice typed ChipGroup.

{% tabs %}

{% highlight xaml %}
<chip:SfChipGroup    x:Name="sfChipGroup"
                     Margin="200,100,0,0"  
                     ItemsSource="{Binding Employees}" 
                     DisplayMemberPath="Name" 
                     ChipType="Choice">
			
<VisualStateManager.VisualStateGroups>
    <VisualStateGroup x:Name="CommonStates">
        <VisualState x:Name="Normal">
            <VisualState.Setters>
                <Setter Property="ChipTextColor" Value="Black" />
                <Setter Property="ChipBackground" Value="white" />
            </VisualState.Setters>
        </VisualState>
        <VisualState x:Name="Selected">
            <VisualState.Setters>
                <Setter Property="ChipTextColor" Value="White" />
                <Setter Property="ChipBackground" Value="#512dcd" />
            </VisualState.Setters>
        </VisualState>
    </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
</chip:SfChipGroup>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

public MainPage()
	{
		InitializeComponent();

        VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
        VisualState normalState = new VisualState() { Name="Normal"};

        VisualStateGroup commonStateGroup = new VisualStateGroup();
        if (sfChipGroup.ChipType == SfChipsType.Choice)
        {
            
            normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Black });
            normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Colors.White });
        }


        VisualState selectedState = new VisualState
        {
            Name = "Selected"
        };
        selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Green });
        selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Colors.Violet });

        commonStateGroup.States.Add(normalState);
        commonStateGroup.States.Add(selectedState);
        visualStateGroupList.Add(commonStateGroup);

        VisualStateManager.SetVisualStateGroups(sfChipGroup, visualStateGroupList);

        }

{% endhighlight %}

{% endtabs %}

{% highlight c# %}

[Model]

public class Employee
{

    public string Name { get; set; }

}

[ViewModel]

public class EmployeeViewModel : INotifyPropertyChanged
{

    private Employee selectedEmployee;

    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<string> items = new() { "Joseph", "Alazari", "Rocketuh", "Raja" };
    public ObservableCollection<string> Items
    {
        get { return items; }
        set
        {
            items = value;
            OnPropertyChanged(nameof(Items));
        }
    }

    private Employee selectedItem = new() { Name = "Joseph" };

    public Employee SelectedItems { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(nameof(SelectedItems)); } }

    public ObservableCollection<Employee> Employees
    {
        get
        {

         return employees;

        }
        set
        {
            employees = value;
            OnPropertyChanged(nameof(Employees));
        }

    }

     public Employee SelectedEmployee
    {
        get
        {
            return selectedEmployee;
        }
        set
        {
            selectedEmployee = value;
            OnPropertyChanged(nameof(SelectedEmployee));
        }
     }
    public Command ActionCommand { get; set; }

    private void ShowPopup(Object obj)
    {
        if (obj is Employee chip)
        {
            this.Result = chip.Name;
        }
    }

    private string result;
    public string Result
    {
        get { return result; }
        set { result = value; OnPropertyChanged(); }
    }

     public void OnPropertyChanged([CallerMemberName] string name = null) =>

     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public EmployeeViewModel()
    {
        this.Employees = new ObservableCollection<Employee>();

        Employees.Add(new Employee
        {
            Name = "Joseph",

        });

        Employees.Add(new Employee
        {
            Name = "Anne Joseph",

        });
        Employees.Add(new Employee
        {
            Name = "Andrew Fuller",

        });
        Employees.Add(new Employee
        {
            Name = "Emilio Alvaro",

        });
        Employees.Add(new Employee
        {
            Name = "Janet Leverling",

        });

        SelectedEmployee = Employees[0];

        ActionCommand = new Command(ShowPopup);

    }

}

{% endhighlight %}

![Choice typed in .NET MAUI SfChipGroup](images/items/Choice.png)

### ChoiceMode

[`Single`] - At least, one item must be in selected state and the selected item cannot be deselected, if [`ChoiceMode`] is Single.

[`SingleOrNone`] - Unlike [`Single`] it is possible to deselect the selected item and keep all the items in deselected state.

{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:core ="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:local="clr-namespace:Chips"
    x:Class="Chips.GettingStarted">
	<ContentPage.Content>
		<core:SfChipGroup Type="Choice" ChoiceMode="SingleOrNone">
			<core:SfChipGroup.Items>
				<core:SfChip Text="Extra Small"/>
				<core:SfChip Text="Small"/>
				<core:SfChip Text="Medium"/>
				<core:SfChip Text="Large"/>
				<core:SfChip Text="Extra Large"/>
			</core:SfChipGroup.Items>
		</core:SfChipGroup>
	</ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

namespace Chips
{
	public partial class GettingStarted: ContentPage
	{
		public GettingStarted()
		{
			InitializeComponent();
			Grid grid = new Grid();
			var chipGroup = new SfChipGroup(){Type = SfChipsType.Choice, ChoiceMode = ChoiceMode.SingleOrNone};
			grid.Children.Add(chipGroup);
			chipGroup.Items.Add(new SfChip(){Text="Extra Small"});
			chipGroup.Items.Add(new SfChip(){Text="Small"});
			chipGroup.Items.Add(new SfChip(){Text="Medium"});
			chipGroup.Items.Add(new SfChip(){Text="Large"});
			chipGroup.Items.Add(new SfChip(){Text="Extra Large"});
			this.Content = grid;
		}
	}
}

{% endhighlight %}

{% endtabs %}

## Filter

Allows users to select more than one chip in a group of chips. The selected chips are indicated by selection indicator in this type. The selection indicator can be customized using the [`SelectionIndicatorColor`] property. Use the [`SelectedItem`] property to get the list of selected chips.

This selection changes are notified by using [SelectionChanging] and [SelectionChanged] events.

Here, we should add visual states to set the ChipType to Filter.

The following code illustrates how to get filter typed ChipGroup.

{% tabs %}

{% highlight xaml %}

<chip:SfChipGroup    x:Name="sfChipGroup"
                     Margin="200,100,0,0"  
                     ItemsSource="{Binding Employees}" 
                     DisplayMemberPath="Name" 
					 SelectionIndicatorColor="White"
                     ChipType="Filter" >
			
<VisualStateManager.VisualStateGroups>
    <VisualStateGroup x:Name="CommonStates">
        <VisualState x:Name="Normal">
            <VisualState.Setters>
                <Setter Property="ChipTextColor" Value="Black" />
                <Setter Property="ChipBackground" Value="white" />
            </VisualState.Setters>
        </VisualState>
        <VisualState x:Name="Selected">
            <VisualState.Setters>
                <Setter Property="ChipTextColor" Value="White" />
                <Setter Property="ChipBackground" Value="#512dcd" />
            </VisualState.Setters>
        </VisualState>
    </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
</chip:SfChipGroup>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Core;

public MainPage()
	{
		InitializeComponent();

        VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
        VisualState normalState = new VisualState() { Name="Normal"};

        VisualStateGroup commonStateGroup = new VisualStateGroup();
        if (sfChipGroup.ChipType == SfChipsType.Filter)
        {
            normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Black });
            normalState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Colors.White });
        }


        VisualState selectedState = new VisualState
        {
            Name = "Selected"
        };
        selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipTextColorProperty, Value = Colors.Green });
        selectedState.Setters.Add(new Setter { Property = SfChipGroup.ChipBackgroundProperty, Value = Colors.Violet });

        commonStateGroup.States.Add(normalState);
        commonStateGroup.States.Add(selectedState);
        visualStateGroupList.Add(commonStateGroup);

        VisualStateManager.SetVisualStateGroups(sfChipGroup, visualStateGroupList);

    }

{% endhighlight %}

{% endtabs %}

{% highlight c# %}

[Model]

public class Employee
{

    public string Name { get; set; }

}

[ViewModel]

public class EmployeeViewModel : INotifyPropertyChanged
{

    private Employee selectedEmployee;

    private ObservableCollection<Employee> employees;

    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<string> items = new() { "Joseph", "Alazari", "Rocketuh", "Raja" };
    public ObservableCollection<string> Items
    {
        get { return items; }
        set
        {
            items = value;
            OnPropertyChanged(nameof(Items));
        }
    }

    private Employee selectedItem = new() { Name = "Joseph" };

    public Employee SelectedItems { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(nameof(SelectedItems)); } }

    public ObservableCollection<Employee> Employees
    {
        get
        {

         return employees;

        }
        set
        {
            employees = value;
            OnPropertyChanged(nameof(Employees));
        }

    }

     public Employee SelectedEmployee
    {
        get
        {
            return selectedEmployee;
        }
        set
        {
            selectedEmployee = value;
            OnPropertyChanged(nameof(SelectedEmployee));
        }
    }
    public Command ActionCommand { get; set; }

    private void ShowPopup(Object obj)
    {
        if (obj is Employee chip)
        {
            this.Result = chip.Name;
        }
    }

    private string result;
    public string Result
    {
        get { return result; }
        set { result = value; OnPropertyChanged(); }
    }

     public void OnPropertyChanged([CallerMemberName] string name = null) =>

     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public EmployeeViewModel()
    {
        this.Employees = new ObservableCollection<Employee>();

        Employees.Add(new Employee
        {
            Name = "Joseph",

        });

        Employees.Add(new Employee
        {
            Name = "Anne Joseph",

        });
        Employees.Add(new Employee
        {
            Name = "Andrew Fuller",

        });
        Employees.Add(new Employee
        {
            Name = "Emilio Alvaro",

        });
        Employees.Add(new Employee
        {
            Name = "Janet Leverling",

        });

        SelectedEmployee = Employees[0];

    }

}

{% endhighlight %}

![Filter type SfChipGroup in .NET MAUI](images/items/Filter.png)

## Action

Action type of [`SfChipGroup`] executes the [`Command`] when clicking the chip in [`SfChipGroup`]. On its [`Command`] action, you can do our desired action.

The [`Command`] will execute only for action typed [`SfChipGroup`].

The following code illustrates how to get action typed ChipGroup.

{% tabs %}

{% highlight xaml %}
<ContentPage.BindingContext>
        <local:ViewModel></local:ViewModel>
    </ContentPage.BindingContext>
<chip:SfChipGroup
    Command="{Binding ActionCommand}" 
    ItemsSource="{Binding Employees}"
    DisplayMemberPath="Name"
    CloseButtonColor="Black"
    ChipType="Action">
</chip:SfChipGroup>
            <StackLayout Orientation="Horizontal">
<Label Margin="10,60,0,0"
	                Text="Name:" 
				    FontAttributes="Bold" 
				    FontSize="14" />
<Label Margin="10,60,0,0"
				Text="{Binding Result}"
				FontAttributes="Bold" 
				FontSize="14" />
            </StackLayout>
{% endhighlight %}

{% highlight c# %}
[Model]

public class Person
{
    public string Name
    {
        get;
        set;
    }
}

[ViewModel]

public class ViewModel : INotifyPropertyChanged
{
    private ICommand actionCommand;

    private ObservableCollection<Person> employees;

    private string result;

    public ICommand ActionCommand
    {
        get
        {
            return actionCommand;
        }
        set
        {
            actionCommand = value;
        }
    }

    public ObservableCollection<Person> Employees
    {
        get
        {
            return employees;
        }
        set
        {
            Employees = value;
            OnPropertyChanged("Employees");
        }
    }

    public string Result
    {
        get
        {
            return result;
        }
        set
        {
            result = value;
            OnPropertyChanged("Result");
        }
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

{% endhighlight %}

![Action typed in .NET MAUI SfChipGroup](images/items/Action.png)







