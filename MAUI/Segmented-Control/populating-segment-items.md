---
layout: post
title: Create Segment Content in .NET MAUI Segmented Control | Syncfusion<sup>&reg;</sup>
description: Learn about to manage the segment content in Syncfusion<sup>&reg;</sup> .NET MAUI Segmented control (SfSegmentedControl).
platform: maui
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
                                ItemsSource="{Binding SegmentItems}">
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
        segmentedControl.ItemsSource = viewModel.SegmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![Display text in .NET MAUI Segmented control.](images/populating-segment-items/text.png)

## Image
Create a segmented control with segments that contain the provided images by using the [SfSegmentItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentItem.html) collection, which is bound to the [Itemssource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSegmentedControl.html#Syncfusion_Maui_Buttons_SfSegmentedControl_ItemsSource) property.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
        <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding SegmentItems}">
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
        segmentedControl.ItemsSource = viewModel.SegmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
                new SfSegmentItem(){Text = "\ue700", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue701", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue702", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
                new SfSegmentItem(){Text = "\ue703", TextStyle = new SegmentTextStyle{ FontSize = 20, FontFamily = "Date Picker Icon" } },
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![Display image in .NET MAUI Segmented control.](images/populating-segment-items/image.png)

## Image with Text
Display images and text in the segmented items of the control.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding SegmentItems}">
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
        segmentedControl.ItemsSource = viewModel.SegmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
            new SfSegmentItem() {  ImageSource="jackson.png", Text="Jack" },
            new SfSegmentItem() { ImageSource="liam.png", Text="Liam" },
            new SfSegmentItem() { ImageSource ="nora.png", Text="Nora" },
            new SfSegmentItem() { ImageSource ="lita.png" , Text="Lita" },
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![Display image with text in .NET MAUI Segmented control.](images/populating-segment-items/image-text.png)

## Custom Font with Text
Display custom font with text in the segmented items of the control.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <buttons:SfSegmentedControl x:Name="segmentedControl"
                                    ItemsSource="{Binding SegmentItems}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.ItemsSource = viewModel.SegmentItems;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private List<SfSegmentItem> segmentItems;

    public ViewModel()
    {
        segmentItems = new List<SfSegmentItem>()
        {
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue700", Size = 20, FontFamily = "Date Picker Icon", Color = Colors.Black}, Text = "Day"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black }, Text = "Week"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue701", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black}, Text = "Month"},
            new SfSegmentItem() { ImageSource = new FontImageSource() { Glyph = "\ue703", Size = 20, FontFamily = "Date Picker Icon",  Color = Colors.Black}, Text = "Year"},
        };
    }

    public List<SfSegmentItem> SegmentItems
    {
        get { return segmentItems; }
        set { segmentItems = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![Display font with text in .NET MAUI Segmented control.](images/populating-segment-items/font-text.png)