---
layout: post
title: Create segment content in .NET MAUI Segmented control | Syncfusion
description: Learn about to manage the segment content in Syncfusion .NET MAUI Segmented control (SfSegmentedControl).
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---
 
# Create Segment Content in .NET MAUI Segmented Control (SfSegmentedControl)

Depending on the application, different scenarios may require icons, text, or a combination of both for effective communication.

## Text
Create segmented control with segments having the given text.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                ItemsSource="{Binding ItemsCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    List<SfSegmentItem> itemList = new List<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemsCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> itemsCollection;

    public ViewModel()
    {
        itemsCollection = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> ItemsCollection
    {
        get { return itemsCollection; }
        set { itemsCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Image
Create segmented control with segments having the given images using `SfSegmentItem` collection bind to `Itemssource` property.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding ItemsCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    List<SfSegmentItem> itemList = new List<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemsCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> itemsCollection;

    public ViewModel()
    {
        itemsCollection = new List<SfSegmentItem>()
        {
                new SfSegmentItem(){Text = "\ue700", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue701", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue702", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue703", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
        };
    }

    public List<SfSegmentItem> ItemsCollection
    {
        get { return itemsCollection; }
        set { itemsCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Image with Text
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
                                    ItemsSource="{Binding ItemsCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    List<SfSegmentItem> itemList = new List<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemsCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> itemsCollection;

    public ViewModel()
    {
        itemsCollection = new List<SfSegmentItem>()
        {
            new SfSegmentItem() {  ImageSource="jackson.png", Text="Jackson" },
            new SfSegmentItem() { ImageSource ="gabriella.png" , Text="Gabriella"},
            new SfSegmentItem() { ImageSource="liam.png", Text="Liam"},
            new SfSegmentItem() { ImageSource ="nora.png", Text="Nora" },
            new SfSegmentItem() { ImageSource ="lita.png" , Text="Lita"},
        };
    }

    public List<SfSegmentItem> ItemsCollection
    {
        get { return itemsCollection; }
        set { itemsCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

## Custom Font with Text
You can display custom font with text in the segmented items of the control.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding ItemsCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    List<SfSegmentItem> itemList = new List<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.ItemsCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> itemsCollection;

    public ViewModel()
    {
        itemsCollection = new List<SfSegmentItem>()
        {
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue700", Size = 20, FontFamily = "Date Picker Icon", Color = Colors.Black}, Text = "Day"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black }, Text = "Week"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black}, Text = "Month"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue703", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black}, Text = "Year"},
        };
    }

    public List<SfSegmentItem> ItemsCollection
    {
        get { return itemsCollection; }
        set { itemsCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

