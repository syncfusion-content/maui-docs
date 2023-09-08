---
layout: post
title: Display options in .NET MAUI Segmented control | Syncfusion
description: Learn about the Display options in Syncfusion .NET MAUI Segmented(SfSegmented) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfSegmentedControl
documentation: ug
---
 
# Display options in .NET MAUI Segmented (SfSegmented) control

Depending on the application, different scenarios may require icons, text, or a combination of both for effective communication. The segmented control supports these three options.

## Text
By default, the segmented items is diplayed as text

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding ItemCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    ObservableCollection<SfSegmentItem> itemList = new ObservableCollection<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private ObservableCollection<SfSegmentItem> itemCollection;

    public ViewModel()
    {
        itemCollection = new ObservableCollection<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public ObservableCollection<SfSegmentItem> ItemCollection
    {
        get { return itemCollection; }
        set { itemCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Image
You can display images in the segmented items of the control.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding ItemCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    ObservableCollection<SfSegmentItem> itemList = new ObservableCollection<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private ObservableCollection<SfSegmentItem> itemCollection;

    public ViewModel()
    {
        itemCollection = new ObservableCollection<SfSegmentItem>()
        {
                new SfSegmentItem(){Text = "\ue700", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue701", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue702", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue703", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
        };
    }

    public ObservableCollection<SfSegmentItem> ItemCollection
    {
        get { return itemCollection; }
        set { itemCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Image with text
You can display images and the text in the segmented items of the control.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding ItemCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    ObservableCollection<SfSegmentItem> itemList = new ObservableCollection<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private ObservableCollection<SfSegmentItem> itemCollection;

    public ViewModel()
    {
        itemCollection = new ObservableCollection<SfSegmentItem>()
        {
            new SfSegmentItem() {  ImageSource="jackson.png", Text="Jackson" },
            new SfSegmentItem() { ImageSource ="gabriella.png" , Text="Gabriella"},
            new SfSegmentItem() { ImageSource="liam.png", Text="Liam"},
            new SfSegmentItem() { ImageSource ="nora.png", Text="Nora" },
            new SfSegmentItem() { ImageSource ="lita.png" , Text="Lita"},
        };
    }

    public ObservableCollection<SfSegmentItem> ItemCollection
    {
        get { return itemCollection; }
        set { itemCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

