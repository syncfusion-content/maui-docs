---
layout: post
title: Column in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Column support in Syncfusion® .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Column in .NET MAUI Kanban Board (SfKanban)

## Customizing Column Size

By default, columns are sized smartly to arrange the default elements of the cards with better readability. However, you can define the minimum and maximum width for the columns in [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) using [`MinimumColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumColumnWidth) and [`MaximumColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumColumnWidth) properties respectively. 

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban MinimumColumnWidth ="300" MaximumColumnWidth ="340">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

kanban.MinimumColumnWidth = 300;
kanban.MaximumColumnWidth = 340;

{% endhighlight %}

{% endtabs %}

You can also define the exact column width using [`ColumnWidth`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnWidth) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html).

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban ColumnWidth ="250">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

kanban.ColumnWidth = 250;

{% endhighlight %}

{% endtabs %}

## Categorizing Columns

To categorize columns based on a specific property, you must explicitly define the property path using the [`ColumnMappingPath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath) property. However, only the properties of [`KanbanModel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanModel.html) can be assigned to [`ColumnMappingPath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath). By default, [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) will categorize the items using the Category property of KanbanModel.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban ColumnMappingPath="ID">
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %} 

kanban.ColumnMappingPath = "ID";

{% endhighlight %}

{% endtabs %}

### Category for a column

You can assign a specific category to a column by setting the [Categories](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_Categories) property of the [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html). This will display cards with the specified category under the corresponding column. For example, to map the `In Progress` category to the `In Progress` column

{% tabs %}

{% highlight xaml %}

<kanban:KanbanColumn x:Name="progressColumn" Categories="In Progress" />

{% endhighlight %}

{% highlight C# %} 

progressColumn.Categories = new List<object>() { "In Progress" };

{% endhighlight %}

{% endtabs %}

## Headers

Header shows the category `Title`, `Items count`, `Min` and `Max` informations of a column. The UI of the header can be replaced entirely using [`HeaderTemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_HeaderTemplate) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html). The following code snippet and screenshot illustrates this.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban.HeaderTemplate >
    <DataTemplate>
        <StackLayout WidthRequest="300" HeightRequest="40"  BackgroundColor="Silver">
            <Label Margin="10" Text="{Binding Title}" TextColor="Purple" HorizontalOptions="Start" />
        </StackLayout>
    </DataTemplate>
</kanban:SfKanban.HeaderTemplate>

{% endhighlight %}

{% highlight C# %} 

var headerTemplate = new DataTemplate(() => 
{
    StackLayout root = new StackLayout()
    { 
        WidthRequest = 300, 
        HeightRequest = 40, 
        BackgroundColor = Color.Silver 
    };
    Label label = new Label();
    label.Margin = new Thickness(10); 
    label.SetBinding(Label.TextProperty, new Binding("Title") );
    label.TextColor = Color.Purple;
    label.HorizontalOptions = LayoutOptions.Start; 
    root.Children.Add(label);
    return root;
});
kanban.HeaderTemplate = headerTemplate;

{% endhighlight %}

{% endtabs %}

## Expand/Collapse Column

Columns can be expanded/collapsed by tapping the toggle button which is placed at top right corner of the Kanban header. [`IsExpanded`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_IsExpanded) property of [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) is used to programmatically expand/collapse the Kanban column. The following code example describes the above behavior.   

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban.Columns>
    <kanban:KanbanColumn x:Name="column1" Title="To Do" IsExpanded="false" />
    <kanban:KanbanColumn x:Name="column2" Title="In Progress" IsExpanded="false" />
</kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

KanbanColumn column1 = new KanbanColumn();
column1.IsExpanded = false; 
KanbanColumn column2 = new KanbanColumn();
column2.IsExpanded = false;

kanban.Columns.Add(column1);
kanban.Columns.Add(column2);

{% endhighlight %}

{% endtabs %}

## Enable/Disable Drag & Drop 

You can enable and disable the drag and drop operation of the cards for particular column using [`AllowDrag`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_AllowDrag) and [`AllowDrop`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_AllowDrop) properties of [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html).

The following code is used to disable the drag operation from progress column.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban.Columns>
    <kanban:KanbanColumn AllowDrag="false"/>
</kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

KanbanColumn progressColumn = new KanbanColumn();
progressColumn.AllowDrag = false;

{% endhighlight %}

{% endtabs %}

The following code is used to disable the drop operation of the cards into the progress column.

{% tabs %}

{% highlight xaml %}

<kanban:SfKanban.Columns>
    <kanban:KanbanColumn AllowDrop="false"/>
</kanban:SfKanban.Columns>

{% endhighlight %}

{% highlight C# %}

KanbanColumn progressColumn = new KanbanColumn();
progressColumn.AllowDrop = false; 

{% endhighlight %}

{% endtabs %}

## Items Count

[`ItemsCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_ItemsCount) property is used to get the total cards count in each column.

{% highlight C# %}

int count = todoColumn.ItemsCount;         

{% endhighlight %}


## Work In-Progress Limit

[`MinimumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MinimumLimit) and [`MaximumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MaximumLimit) properties are used to define the minimum and maximum number of items in a column. If the actual items count is exceeded or lesser than the specified limits, the error bars are used to indicate this violation. Following properties of [`ErrorBarSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_ErrorBarSettings) are used to customize the appearance of error bar.

* [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_Fill), of type `Brush`, used to change the default color of the error bar.
* [MaxValidationFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_MaxValidationFill), of type `Brush`, used to change the maximum validation color of the error bar.
* [MinValidationFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_MinValidationFill), of type `Brush`, used to change the minimum validation color of the error bar.
* [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanErrorBarSettings.html#Syncfusion_Maui_Kanban_KanbanErrorBarSettings_Height),of type `double`, used to change the height of the error bar.

{% tabs %}

{% highlight xaml %}

<kanban:KanbanColumn x:Name="todoColumn" Title="To Do" MinimumLimit="2" MaximumLimit="1">
</kanban:KanbanColumn>

{% endhighlight %}

{% highlight C# %}

todoColumn.MinimumLimit = 2; 
todoColumn.MaximumLimit = 1;   

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight xaml %}

<kanban:KanbanColumn x:Name="todoColumn" Title="To Do" MinimumLimit="3" MaximumLimit="5">
    <kanban:KanbanColumn.ErrorBarSettings>
        <kanban:KanbanErrorBarSettings Fill="Green" MinValidationFill="Orange" MaxValidationFill="Red" Height="4"/>
    </kanban:KanbanColumn.ErrorBarSettings>
</kanban:KanbanColumn>

{% endhighlight %}

{% highlight C# %}

KanbanColumn todoColumn = new KanbanColumn();
todoColumn.Title = "To Do";
todoColumn.MaximumLimit = 5;
todoColumn.MinimumLimit = 3;
KanbanErrorBarSettings kanbanErrorBarSettings = new KanbanErrorBarSettings()
{
    Fill = Colors.Green,
    MaxValidationFill = Colors.Red,
    MinValidationFill = Colors.Orange,
    Height = 4,
};
todoColumn.ErrorBarSettings = kanbanErrorBarSettings;
kanban.Columns.Add(todoColumn);

{% endhighlight %}

{% endtabs %}

## Customize column appearance

The .NET MAUI Kanban control allows you to customize the column's background, no card template UI, placeholder style, and more.

### Customize the column background

Use the `Background` property of the [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) to customize the background color of each column in the Kanban control.

{% tabs %}

{% highlight XAML %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="KanbanGettingStarted.MainPage"
             xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
             xmlns:local="clr-namespace:KanbanGettingStarted">

    <ContentPage.BindingContext>
        <local:KanbanViewModel />
    </ContentPage.BindingContext>

    <kanban:SfKanban x:Name="kanban"
                     AutoGenerateColumns="False"
                     HorizontalOptions="Center"
                     VerticalOptions="Center"
                     HeightRequest="700"
                     ItemsSource="{Binding Cards}">
        <kanban:KanbanColumn Title="To Do"
                             Categories="Open,Postponed"
                             MinimumLimit="5"
                             MaximumLimit="15"
                             Background="#D6EAF5">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="In Progress"
                             Categories="In Progress"
                             MinimumLimit="3"
                             MaximumLimit="8"
                             Background="#FFF8DC">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Code Review"
                             Categories="Code Review"
                             MinimumLimit="5"
                             MaximumLimit="10"
                             Background="#FFE4E1">
            <kanban:KanbanColumn.NoCardTemplate>
                <DataTemplate>
                    <VerticalStackLayout VerticalOptions="Start"
                                         Margin="0,210,0,0">
                        <Image Source="image2.png"
                               HeightRequest="100"
                               WidthRequest="100"
                               Background="#FFE4E1" />
                        <Label Text="No code reviews pending"
                               Margin="0,8,0,0"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               FontSize="14"
                               FontAttributes="Bold"
                               TextColor="#000000" />
                    </VerticalStackLayout>
                </DataTemplate>
            </kanban:KanbanColumn.NoCardTemplate>
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Done"
                             Categories="Closed"
                             MinimumLimit="8"
                             Background="#DCEDDC">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
    </kanban:SfKanban>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.kanban.Workflows = new List<KanbanWorkflow>()
		{
			new KanbanWorkflow("Open", new List<object>() { "In Progress", "Closed", "Closed No Changes", "Won't Fix" }),
			new KanbanWorkflow("Postponed", new List<object>() { "Open", "In Progress", "Closed", "Closed No Changes", "Won't Fix" }),
			new KanbanWorkflow("Code Review", new List<object>() { "In Progress", "Closed", "Postponed" }),
			new KanbanWorkflow("In Progress", new List<object>() { "Code Review", "Postponed" }),
		};
	}
}

{% endhighlight %}

{% highlight C# tabtitle="KanbanViewModel.cs" %}

public class KanbanViewModel
{
	public KanbanViewModel()
	{
		this.Cards = this.GetCardDetails();
	}

	public ObservableCollection<KanbanModel> Cards { get; set; }

	private ObservableCollection<KanbanModel> GetCardDetails()
	{
		var cardsDetails = new ObservableCollection<KanbanModel>();

		cardsDetails.Add(new KanbanModel()
		{
			ID = 6,
			Title = "Xamarin - 6",
			ImageURL = "People_circle2.png",
			Category = "Open",
			Description = "Show the retrieved data from the server in Grid control.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 21,
			Title = "Xamarin - 21",
			Category = "Open",
			ImageURL = "People_circle11.png",
			Description = "Improve the performance of editing functionality.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 3,
			Title = "iOS - 3",
			ImageURL = "People_circle3.png",
			Category = "Postponed",
			Description = "Fix the filtering issues reported in Safari.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 11,
			Title = "iOS - 21",
			ImageURL = "People_circle4.png",
			Category = "Postponed",
			Description = "Add input validation for editing.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 15,
			Title = "Android - 15",
			Category = "Open",
			ImageURL = "People_circle5.png",
			Description = "Arrange web meetings for customers.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Story", "Kanban" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 4,
			Title = "UWP - 4",
			ImageURL = "People_circle7.png",
			Category = "Code Review",
			Description = "Enhance editing functionality.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Story", "Kanban" }
		});

		
		cardsDetails.Add(new KanbanModel()
		{
			ID = 13,
			Title = "UWP - 13",
			ImageURL = "People_circle9.png",
			Category = "In Progress",
			Description = "Add responsive support to applications.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Story", "Kanban" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 17,
			Title = "Xamarin - 17",
			Category = "In Progress",
			ImageURL = "People_circle10.png",
			Description = "Fix the issues reported in the IE browser.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 21,
			Title = "Xamarin - 21",
			Category = "In Progress",
			ImageURL = "People_circle11.png",
			Description = "Improve the performance of editing functionality.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 19,
			Title = "iOS - 19",
			Category = "In Progress",
			ImageURL = "People_circle12.png",
			Description = "Fix the issues reported by the customer.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug" }
		});
	  
	   cardsDetails.Add(new KanbanModel()
		{
			ID = 6,
			Title = "Xamarin - 6",
			ImageURL = "People_circle2.png",
			Category = "In Progress",
			Description = "Show the retrieved data from the server in Grid control.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 13,
			Title = "UWP - 13",
			ImageURL = "People_circle18.png",
			Category = "Closed",
			Description = "Fix cannot open user's default database SQL error.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Internal", "Release" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 14,
			Title = "Android - 14",
			Category = "Closed",
			ImageURL = "People_circle19.png",
			Description = "Arrange a web meeting with the customer to get the login page requirement.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Feature" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 15,
			Title = "Xamarin - 15",
			Category = "Closed",
			ImageURL = "People_circle20.png",
			Description = "Login page validation.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 16,
			Title = "Xamarin - 16",
			ImageURL = "People_circle21.png",
			Category = "Closed",
			Description = "Test the application in the IE browser.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug" }
		});

		return cardsDetails;
	}
}

{% endhighlight %}

{% endtabs %}

### Customize no card appearance using DataTemplate

Use the `NoCardTemplate` property of the [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) to define a custom UI for columns that have no cards. This allows you to display meaningful text or messages when a column is empty.

The following example shows how to define a custom **no card** template using a `DataTemplate`

{% tabs %}

{% highlight XAML % hl_lines="21"}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="KanbanGettingStarted.MainPage"
             xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban"
             xmlns:local="clr-namespace:KanbanGettingStarted">

    <ContentPage.BindingContext>
        <local:KanbanViewModel />
    </ContentPage.BindingContext>

    <kanban:SfKanban x:Name="kanban"
                     AutoGenerateColumns="False"
                     HorizontalOptions="Center"
                     VerticalOptions="Center"
                     HeightRequest="700"
                     ItemsSource="{Binding Cards}">
        <kanban:KanbanColumn Title="To Do"
                             Categories="Open,Postponed"
                             MinimumLimit="5"
                             MaximumLimit="15"
                             Background="#D6EAF5">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="In Progress"
                             Categories="In Progress"
                             MinimumLimit="3"
                             MaximumLimit="8"
                             Background="#FFF8DC">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Code Review"
                             Categories="Code Review"
                             MinimumLimit="5"
                             MaximumLimit="10"
                             Background="#FFE4E1">
            <kanban:KanbanColumn.NoCardTemplate>
                <DataTemplate>
                    <VerticalStackLayout VerticalOptions="Start"
                                         Margin="0,210,0,0">
                        <Image Source="image2.png"
                               HeightRequest="100"
                               WidthRequest="100"
                               Background="#FFE4E1" />
                        <Label Text="No code reviews pending"
                               Margin="0,8,0,0"
                               HorizontalOptions="Center"
                               VerticalOptions="Center"
                               FontSize="14"
                               FontAttributes="Bold"
                               TextColor="#000000" />
                    </VerticalStackLayout>
                </DataTemplate>
            </kanban:KanbanColumn.NoCardTemplate>
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Done"
                             Categories="Closed"
                             MinimumLimit="8"
                             Background="#DCEDDC">
            <kanban:KanbanColumn.PlaceholderStyle>
                <kanban:KanbanPlaceholderStyle SelectionIndicatorBackground="#FAC7AD"
                                               Background="#FAC7AD" />
            </kanban:KanbanColumn.PlaceholderStyle>
        </kanban:KanbanColumn>
    </kanban:SfKanban>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.kanban.Workflows = new List<KanbanWorkflow>()
		{
			new KanbanWorkflow("Open", new List<object>() { "In Progress", "Closed", "Closed No Changes", "Won't Fix" }),
			new KanbanWorkflow("Postponed", new List<object>() { "Open", "In Progress", "Closed", "Closed No Changes", "Won't Fix" }),
			new KanbanWorkflow("Code Review", new List<object>() { "In Progress", "Closed", "Postponed" }),
			new KanbanWorkflow("In Progress", new List<object>() { "Code Review", "Postponed" }),
		};
	}
}

{% endhighlight %}

{% highlight C# tabtitle="KanbanViewModel.cs" %}

public class KanbanViewModel
{
	public KanbanViewModel()
	{
		this.Cards = this.GetCardDetails();
	}

	public ObservableCollection<KanbanModel> Cards { get; set; }

	private ObservableCollection<KanbanModel> GetCardDetails()
	{
		var cardsDetails = new ObservableCollection<KanbanModel>();

		cardsDetails.Add(new KanbanModel()
		{
			ID = 6,
			Title = "Xamarin - 6",
			ImageURL = "People_circle2.png",
			Category = "Open",
			Description = "Show the retrieved data from the server in Grid control.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 21,
			Title = "Xamarin - 21",
			Category = "Open",
			ImageURL = "People_circle11.png",
			Description = "Improve the performance of editing functionality.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 3,
			Title = "iOS - 3",
			ImageURL = "People_circle3.png",
			Category = "Postponed",
			Description = "Fix the filtering issues reported in Safari.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 11,
			Title = "iOS - 21",
			ImageURL = "People_circle4.png",
			Category = "Postponed",
			Description = "Add input validation for editing.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 15,
			Title = "Android - 15",
			Category = "Open",
			ImageURL = "People_circle5.png",
			Description = "Arrange web meetings for customers.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Story", "Kanban" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 4,
			Title = "UWP - 4",
			ImageURL = "People_circle7.png",
			Category = "Code Review",
			Description = "Enhance editing functionality.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Story", "Kanban" }
		});

		
		cardsDetails.Add(new KanbanModel()
		{
			ID = 13,
			Title = "UWP - 13",
			ImageURL = "People_circle9.png",
			Category = "In Progress",
			Description = "Add responsive support to applications.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Story", "Kanban" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 17,
			Title = "Xamarin - 17",
			Category = "In Progress",
			ImageURL = "People_circle10.png",
			Description = "Fix the issues reported in the IE browser.",
			IndicatorFill = Colors.Brown,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 21,
			Title = "Xamarin - 21",
			Category = "In Progress",
			ImageURL = "People_circle11.png",
			Description = "Improve the performance of editing functionality.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Customer" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 19,
			Title = "iOS - 19",
			Category = "In Progress",
			ImageURL = "People_circle12.png",
			Description = "Fix the issues reported by the customer.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug" }
		});
	  
	   cardsDetails.Add(new KanbanModel()
		{
			ID = 6,
			Title = "Xamarin - 6",
			ImageURL = "People_circle2.png",
			Category = "In Progress",
			Description = "Show the retrieved data from the server in Grid control.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug", "Customer", "Breaking Issue" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 13,
			Title = "UWP - 13",
			ImageURL = "People_circle18.png",
			Category = "Closed",
			Description = "Fix cannot open user's default database SQL error.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug", "Internal", "Release" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 14,
			Title = "Android - 14",
			Category = "Closed",
			ImageURL = "People_circle19.png",
			Description = "Arrange a web meeting with the customer to get the login page requirement.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Feature" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 15,
			Title = "Xamarin - 15",
			Category = "Closed",
			ImageURL = "People_circle20.png",
			Description = "Login page validation.",
			IndicatorFill = Colors.Red,
			Tags = new List<string> { "Bug" }
		});

		cardsDetails.Add(new KanbanModel()
		{
			ID = 16,
			Title = "Xamarin - 16",
			ImageURL = "People_circle21.png",
			Category = "Closed",
			Description = "Test the application in the IE browser.",
			IndicatorFill = Colors.Purple,
			Tags = new List<string> { "Bug" }
		});

		return cardsDetails;
	}
}

{% endhighlight %}

{% endtabs %}

### Customize the placeholder style

Use the `PlaceholderStyle` property of the [`KanbanColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html) to style the placeholder area where cards can be dropped during drag-and-drop operations. This enhances visual clarity and improves the user experience during interactions.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <kanban:KanbanPlaceholderStyle  x:Key="PlaceholderStyle"
                                    Background="Transparent"
                                    SelectionIndicatorBackground="Transparent"
                                    SelectionIndicatorStroke="{AppThemeBinding Light=#914C00, Dark=#FFB77F}">
        <kanban:KanbanPlaceholderStyle.SelectionIndicatorTextStyle>
            <kanban:KanbanTextStyle TextColor="{AppThemeBinding Light=#914C00, Dark=#FFB77F}" />
        </kanban:KanbanPlaceholderStyle.SelectionIndicatorTextStyle>
    </kanban:KanbanPlaceholderStyle>
</ContentPage.Resources>

<kanban:SfKanban x:Name="kanban"
                 AutoGenerateColumns="False"
                 HorizontalOptions="FillAndExpand"
                 VerticalOptions="FillAndExpand"
                 ItemsSource="{Binding Cards}">
    <kanban:SfKanban.Columns>
        <kanban:KanbanColumn Title="To Do"
                             Categories="Open"
                             PlaceholderStyle="{StaticResource PlaceholderStyle}">
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="In Progress"
                             Categories="In Progress"
                             PlaceholderStyle="{StaticResource PlaceholderStyle}">
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Code Review"
                             Categories="Code Review"
                             PlaceholderStyle="{StaticResource PlaceholderStyle}">
        </kanban:KanbanColumn>
        <kanban:KanbanColumn Title="Done"
                             Categories="Done"
                             PlaceholderStyle="{StaticResource PlaceholderStyle}">
        </kanban:KanbanColumn>
    </kanban:SfKanban.Columns>
</kanban:SfKanban>

{% endhighlight %}

{% highlight C# %}

kanban.AutoGenerateColumns = false; 
kanban.SetBinding(SfKanban.ItemsSourceProperty, "Cards");
kanban.ColumnMappingPath="TaskCategory"

KanbanPlaceholderStyle placeholderStyle = new KanbanPlaceholderStyle
{
    Background = Colors.Transparent,
    SelectionIndicatorBackground = Colors.Transparent,
    SelectionIndicatorStroke = Application.Current.Resources.TryGetValue("SelectionIndicatorStrokeColor", out var strokeColor)
        ? (Color)strokeColor
        : App.Current.RequestedTheme == AppTheme.Dark ? Color.FromArgb("#FFB77F") : Color.FromArgb("#914C00"),
    SelectionIndicatorTextStyle = new KanbanTextStyle
    {
        TextColor = App.Current.RequestedTheme == AppTheme.Dark ? Color.FromArgb("#FFB77F") : Color.FromArgb("#914C00")
    }
};

KanbanColumn openColumn = new KanbanColumn();
openColumn.Title = "To Do";
openColumn.PlaceholderStyle = placeholderStyle;
kanban.Columns.Add(openColumn);

KanbanColumn progressColumn = new KanbanColumn();
progressColumn.Title = "In Progress";
progressColumn.PlaceholderStyle = placeholderStyle;
kanban.Columns.Add(progressColumn);

KanbanColumn codeColumn = new KanbanColumn();
codeColumn.Title = "Code Review";
codeColumn.PlaceholderStyle = placeholderStyle;
kanban.Columns.Add(codeColumn);

KanbanColumn doneColumn = new KanbanColumn();
doneColumn.Title = "Done";
doneColumn.PlaceholderStyle = placeholderStyle;
kanban.Columns.Add(doneColumn);

{% endhighlight %}

{% highlight C# tabtitle="KanbanViewModel.cs" %}

public class KanbanViewModel
{
    public ObservableCollection<KanbanModel> Cards { get; set; }
    public KanbanViewModel()
    {
        Cards = new ObservableCollection<KanbanModel>();
        Cards.Add(new KanbanModel()
        {
            ID = 1,
            Title = "iOS - 1002",
            ImageURL = "People_Circle1.png",
            Category = "Open",
            Description = "Analyze customer requirements",
            IndicatorFill = Colors.Red,
            Tags = new List<string> { "Incident", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 6,
            Title = "Xamarin - 4576",
            ImageURL = "People_Circle2.png",
            Category = "Open",
            Description = "Show the retrieved data from the server in grid control",
            IndicatorFill = Colors.Green,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 13,
            Title = "UWP - 13",
            ImageURL = "People_Circle3.png",
            Category = "In Progress",
            Description = "Add responsive support to application",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 2543,
            Title = "IOS- 11",
            Category = "Code Review",
            ImageURL = "People_Circle4.png",
            Description = "Check login page validation",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
        Cards.Add(new KanbanModel()
        {
            ID = 123,
            Title = "UWP-21",
            Category = "Done",
            ImageURL = "People_Circle5.png",
            Description = "Check login page validation",
            IndicatorFill = Colors.Brown,
            Tags = new List<string> { "Story", "Customer" }
        });
    }

}

{% endhighlight %}

{% endtabs %}