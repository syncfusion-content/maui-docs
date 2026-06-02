---
layout: post
title: Customization  in .NET MAUI Accordion control | Syncfusion
description: Learn all about Customization in the Syncfusion .NET MAUI Accordion (SfAccordion) control and more.
platform: MAUI
control: SfAccordion
documentation: ug
--- 


# Animation duration

The `SfAccordion` allows you to customize the expanding and collapsing duration of accordion items by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationDuration) property. By default, the animation duration is set to `200 milliseconds`. 

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AnimationDuration="150">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        accordion.AnimationDuration = 150;
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            Margin = new Thickness(16, 14, 0, 14),
            CharacterSpacing = 0.25,
            FontFamily = "Roboto-Regular",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var outerGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            ColumnSpacing = 10,
            RowSpacing = 2
        };

        var innerGrid = new Grid
        {
            Margin = new Thickness(16, 6, 0, 0),
            RowDefinitions =
            {
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 70 },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var imageBorder = new Border
        {
            Margin = new Thickness(0, 0, 0, 7),
            Content = new Image { Source = "emp_01.png" }
        };

        Grid.SetRow(imageBorder, 0);
        Grid.SetColumn(imageBorder, 0);
        Grid.SetRowSpan(imageBorder, 4);
        innerGrid.Children.Add(imageBorder);

        AddText(innerGrid, "Position", 0, 1, true);
        AddText(innerGrid, "Chairman", 0, 2);

        AddText(innerGrid, "Organization", 1, 1, true);
        AddText(innerGrid, "ABC Inc.", 1, 2);

        AddText(innerGrid, "Date Of Birth", 2, 1, true);
        AddText(innerGrid, "09/17/1973", 2, 2);

        AddText(innerGrid, "Location", 3, 1, true);
        AddText(innerGrid, "Boston", 3, 2);

        // Description
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. "Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            Padding = new Thickness(0, 10),
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center,
            FontFamily = "Roboto-Regular",
            FontSize = 14,
            CharacterSpacing = 0.25
        };

        Grid.SetRow(description, 4);
        Grid.SetColumnSpan(description, 3);
        innerGrid.Children.Add(description);

        // Phone row
        var phoneStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Margin = new Thickness(0, 0, 0, 12),
            Children =
            {
                new Label
                {
                    Text = "\ue700",
                    FontSize = 16,
                    FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : "AccordionFontIcons",
                    VerticalTextAlignment = TextAlignment.Center
                },
                new Label
                {
                    Text = "(617) 555-1234",
                    FontSize = 14,
                    CharacterSpacing = 0.25,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };

        Grid.SetRow(phoneStack, 5);
        Grid.SetColumnSpan(phoneStack, 3);
        innerGrid.Children.Add(phoneStack);
        outerGrid.Children.Add(innerGrid);
        return outerGrid;
    }

    private void AddText(Grid grid, string text, int row, int column, bool withMargin = false)
    {
        var label = new Label
        {
            Text = text,
            FontFamily = "Roboto-Regular",
            Margin = withMargin ? new Thickness(6, 0, 0, 0) : Thickness.Zero
        };

        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        grid.Children.Add(label);
    }
}
{% endhighlight %}
{% endtabs %}

# Animation easing

You can customize the rate of change of a parameter over time or the animation style of an accordion item by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing) property. By default, the animation easing is set to `Linear`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AnimationEasing="SinOut">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        accordion.AnimationEasing = Syncfusion.Maui.Expander.ExpanderAnimationEasing.SinOut;
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            Margin = new Thickness(16, 14, 0, 14),
            CharacterSpacing = 0.25,
            FontFamily = "Roboto-Regular",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var outerGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            ColumnSpacing = 10,
            RowSpacing = 2
        };

        var innerGrid = new Grid
        {
            Margin = new Thickness(16, 6, 0, 0),
            RowDefinitions =
            {
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 70 },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var imageBorder = new Border
        {
            Margin = new Thickness(0, 0, 0, 7),
            Content = new Image { Source = "emp_01.png" }
        };

        Grid.SetRow(imageBorder, 0);
        Grid.SetColumn(imageBorder, 0);
        Grid.SetRowSpan(imageBorder, 4);
        innerGrid.Children.Add(imageBorder);

        AddText(innerGrid, "Position", 0, 1, true);
        AddText(innerGrid, "Chairman", 0, 2);

        AddText(innerGrid, "Organization", 1, 1, true);
        AddText(innerGrid, "ABC Inc.", 1, 2);

        AddText(innerGrid, "Date Of Birth", 2, 1, true);
        AddText(innerGrid, "09/17/1973", 2, 2);

        AddText(innerGrid, "Location", 3, 1, true);
        AddText(innerGrid, "Boston", 3, 2);

        // Description
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. "Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            Padding = new Thickness(0, 10),
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center,
            FontFamily = "Roboto-Regular",
            FontSize = 14,
            CharacterSpacing = 0.25
        };

        Grid.SetRow(description, 4);
        Grid.SetColumnSpan(description, 3);
        innerGrid.Children.Add(description);

        // Phone row
        var phoneStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Margin = new Thickness(0, 0, 0, 12),
            Children =
            {
                new Label
                {
                    Text = "\ue700",
                    FontSize = 16,
                    FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : "AccordionFontIcons",
                    VerticalTextAlignment = TextAlignment.Center
                },
                new Label
                {
                    Text = "(617) 555-1234",
                    FontSize = 14,
                    CharacterSpacing = 0.25,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };

        Grid.SetRow(phoneStack, 5);
        Grid.SetColumnSpan(phoneStack, 3);
        innerGrid.Children.Add(phoneStack);
        outerGrid.Children.Add(innerGrid);
        return outerGrid;
    }

    private void AddText(Grid grid, string text, int row, int column, bool withMargin = false)
    {
        var label = new Label
        {
            Text = text,
            FontFamily = "Roboto-Regular",
            Margin = withMargin ? new Thickness(6, 0, 0, 0) : Thickness.Zero
        };

        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        grid.Children.Add(label);
    }
}
{% endhighlight %}
{% endtabs %}

# Auto scroll position

The `SfAccordion` allows you to customize the scroll position of the expanded accordion item using the [AutoScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition) property. By default, the auto-scroll position is set to `MakeVisible`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        AutoScrollPosition="Top">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        accordion.AutoScrollPosition = AccordionAutoScrollPosition.Top;
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            Margin = new Thickness(16, 14, 0, 14),
            CharacterSpacing = 0.25,
            FontFamily = "Roboto-Regular",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var outerGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            ColumnSpacing = 10,
            RowSpacing = 2
        };

        var innerGrid = new Grid
        {
            Margin = new Thickness(16, 6, 0, 0),
            RowDefinitions =
            {
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 70 },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var imageBorder = new Border
        {
            Margin = new Thickness(0, 0, 0, 7),
            Content = new Image { Source = "emp_01.png" }
        };

        Grid.SetRow(imageBorder, 0);
        Grid.SetColumn(imageBorder, 0);
        Grid.SetRowSpan(imageBorder, 4);
        innerGrid.Children.Add(imageBorder);

        AddText(innerGrid, "Position", 0, 1, true);
        AddText(innerGrid, "Chairman", 0, 2);

        AddText(innerGrid, "Organization", 1, 1, true);
        AddText(innerGrid, "ABC Inc.", 1, 2);

        AddText(innerGrid, "Date Of Birth", 2, 1, true);
        AddText(innerGrid, "09/17/1973", 2, 2);

        AddText(innerGrid, "Location", 3, 1, true);
        AddText(innerGrid, "Boston", 3, 2);

        // Description
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. "Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            Padding = new Thickness(0, 10),
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center,
            FontFamily = "Roboto-Regular",
            FontSize = 14,
            CharacterSpacing = 0.25
        };

        Grid.SetRow(description, 4);
        Grid.SetColumnSpan(description, 3);
        innerGrid.Children.Add(description);

        // Phone row
        var phoneStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Margin = new Thickness(0, 0, 0, 12),
            Children =
            {
                new Label
                {
                    Text = "\ue700",
                    FontSize = 16,
                    FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : "AccordionFontIcons",
                    VerticalTextAlignment = TextAlignment.Center
                },
                new Label
                {
                    Text = "(617) 555-1234",
                    FontSize = 14,
                    CharacterSpacing = 0.25,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };

        Grid.SetRow(phoneStack, 5);
        Grid.SetColumnSpan(phoneStack, 3);
        innerGrid.Children.Add(phoneStack);
        outerGrid.Children.Add(innerGrid);
        return outerGrid;
    }

    private void AddText(Grid grid, string text, int row, int column, bool withMargin = false)
    {
        var label = new Label
        {
            Text = text,
            FontFamily = "Roboto-Regular",
            Margin = withMargin ? new Thickness(6, 0, 0, 0) : Thickness.Zero
        };

        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        grid.Children.Add(label);
    }
}
{% endhighlight %}
{% endtabs %}

# Bring an accordion item into view

The `BringIntoView` method is used to bring a specific item into view by scrolling to it programmatically.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void Button_Clicked(object sender, EventArgs e)
{
    accordion.BringIntoView(accordion.Items[15]);
}
{% endhighlight %}
{% endtabs %}

# Expand mode

You can expand single or multiple items using the [ExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode) property. By default, the expanded mode is set to `Single`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        ExpandMode="Multiple">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        accordion.ExpandMode = AccordionExpandMode.Multiple;
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            Margin = new Thickness(16, 14, 0, 14),
            CharacterSpacing = 0.25,
            FontFamily = "Roboto-Regular",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var outerGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            ColumnSpacing = 10,
            RowSpacing = 2
        };

        var innerGrid = new Grid
        {
            Margin = new Thickness(16, 6, 0, 0),
            RowDefinitions =
            {
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 70 },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var imageBorder = new Border
        {
            Margin = new Thickness(0, 0, 0, 7),
            Content = new Image { Source = "emp_01.png" }
        };

        Grid.SetRow(imageBorder, 0);
        Grid.SetColumn(imageBorder, 0);
        Grid.SetRowSpan(imageBorder, 4);
        innerGrid.Children.Add(imageBorder);

        AddText(innerGrid, "Position", 0, 1, true);
        AddText(innerGrid, "Chairman", 0, 2);

        AddText(innerGrid, "Organization", 1, 1, true);
        AddText(innerGrid, "ABC Inc.", 1, 2);

        AddText(innerGrid, "Date Of Birth", 2, 1, true);
        AddText(innerGrid, "09/17/1973", 2, 2);

        AddText(innerGrid, "Location", 3, 1, true);
        AddText(innerGrid, "Boston", 3, 2);

        // Description
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. "Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            Padding = new Thickness(0, 10),
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center,
            FontFamily = "Roboto-Regular",
            FontSize = 14,
            CharacterSpacing = 0.25
        };

        Grid.SetRow(description, 4);
        Grid.SetColumnSpan(description, 3);
        innerGrid.Children.Add(description);

        // Phone row
        var phoneStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Margin = new Thickness(0, 0, 0, 12),
            Children =
            {
                new Label
                {
                    Text = "\ue700",
                    FontSize = 16,
                    FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : "AccordionFontIcons",
                    VerticalTextAlignment = TextAlignment.Center
                },
                new Label
                {
                    Text = "(617) 555-1234",
                    FontSize = 14,
                    CharacterSpacing = 0.25,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };

        Grid.SetRow(phoneStack, 5);
        Grid.SetColumnSpan(phoneStack, 3);
        innerGrid.Children.Add(phoneStack);
        outerGrid.Children.Add(innerGrid);
        return outerGrid;
    }

    private void AddText(Grid grid, string text, int row, int column, bool withMargin = false)
    {
        var label = new Label
        {
            Text = text,
            FontFamily = "Roboto-Regular",
            Margin = withMargin ? new Thickness(6, 0, 0, 0) : Thickness.Zero
        };

        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        grid.Children.Add(label);
    }
}
{% endhighlight %}
{% endtabs %}

# Item spacing 

The `SfAccordion` allows you to customize the vertical spacing between the accordion items by using the [ItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing) property. 

{% tabs %}
{% highlight xaml hl_lines="2" %}
<syncfusion:SfAccordion x:Name="accordion"
                        ItemSpacing="6.0d">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            <syncfusion:AccordionItem.Header>
                <Grid HeightRequest="48">
                    <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" />
                </Grid>
            </syncfusion:AccordionItem.Header>
            <syncfusion:AccordionItem.Content>
                <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4">
                    <Grid Margin="16,6,0,0" RowDefinitions="25,25,25,25,70,Auto" ColumnDefinitions="100,100,*">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontFamily" Value="Roboto-Regular" />
                            </Style>
                        </Grid.Resources>
                        <Border Grid.RowSpan="4" Grid.Row="0" Grid.Column="0" Padding="0" Margin="0,0,0,7">
                            <Image Source="emp_01.png" />
                        </Border>
                        <Label Text="Position" Grid.Row="0" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Chairman" Grid.Row="0" Grid.Column="2" />
                        <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2" />
                        <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2" />
                        <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0" />
                        <Label Text="Boston" Grid.Row="3" Grid.Column="2" />
                        <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3" LineBreakMode="WordWrap" FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                               Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry." />
                        <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                            <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2" FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}' VerticalOptions="Center" VerticalTextAlignment="Center" />
                            <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14" />
                        </StackLayout>
                    </Grid>
                </Grid>
            </syncfusion:AccordionItem.Content>
        </syncfusion:AccordionItem>
        ..........................
    </syncfusion:SfAccordion.Items>
</syncfusion:SfAccordion>
{% endhighlight %}
{% highlight c# hl_lines="8" %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var accordion = new SfAccordion();
        accordion.ItemSpacing = 6.0d;
        var accordionItems = new AccordionItem
        {
            Header = CreateHeader(),
            Content = CreateContent()
        };

        accordion.Items.Add(accordionItems);
        this.Content = accordion;
    }

    private View CreateHeader()
    {
        var headerGrid = new Grid
        {
            HeightRequest = 48
        };

        headerGrid.Children.Add(new Label
        {
            Text = "Robin Rane",
            Margin = new Thickness(16, 14, 0, 14),
            CharacterSpacing = 0.25,
            FontFamily = "Roboto-Regular",
            FontSize = 14
        });

        return headerGrid;
    }

    private View CreateContent()
    {
        var outerGrid = new Grid
        {
            BackgroundColor = Color.FromArgb("#f4f4f4"),
            ColumnSpacing = 10,
            RowSpacing = 2
        };

        var innerGrid = new Grid
        {
            Margin = new Thickness(16, 6, 0, 0),
            RowDefinitions =
            {
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 25 },
                new RowDefinition { Height = 70 },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = 100 },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Image
        var imageBorder = new Border
        {
            Margin = new Thickness(0, 0, 0, 7),
            Content = new Image { Source = "emp_01.png" }
        };

        Grid.SetRow(imageBorder, 0);
        Grid.SetColumn(imageBorder, 0);
        Grid.SetRowSpan(imageBorder, 4);
        innerGrid.Children.Add(imageBorder);

        AddText(innerGrid, "Position", 0, 1, true);
        AddText(innerGrid, "Chairman", 0, 2);

        AddText(innerGrid, "Organization", 1, 1, true);
        AddText(innerGrid, "ABC Inc.", 1, 2);

        AddText(innerGrid, "Date Of Birth", 2, 1, true);
        AddText(innerGrid, "09/17/1973", 2, 2);

        AddText(innerGrid, "Location", 3, 1, true);
        AddText(innerGrid, "Boston", 3, 2);

        // Description
        var description = new Label
        {
            Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. "Under his guidance, the company thrives and continues to make a significant impact in the industry.",
            Padding = new Thickness(0, 10),
            LineBreakMode = LineBreakMode.WordWrap,
            VerticalTextAlignment = TextAlignment.Center,
            FontFamily = "Roboto-Regular",
            FontSize = 14,
            CharacterSpacing = 0.25
        };

        Grid.SetRow(description, 4);
        Grid.SetColumnSpan(description, 3);
        innerGrid.Children.Add(description);

        // Phone row
        var phoneStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Margin = new Thickness(0, 0, 0, 12),
            Children =
            {
                new Label
                {
                    Text = "\ue700",
                    FontSize = 16,
                    FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : "AccordionFontIcons",
                    VerticalTextAlignment = TextAlignment.Center
                },
                new Label
                {
                    Text = "(617) 555-1234",
                    FontSize = 14,
                    CharacterSpacing = 0.25,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };

        Grid.SetRow(phoneStack, 5);
        Grid.SetColumnSpan(phoneStack, 3);
        innerGrid.Children.Add(phoneStack);
        outerGrid.Children.Add(innerGrid);
        return outerGrid;
    }

    private void AddText(Grid grid, string text, int row, int column, bool withMargin = false)
    {
        var label = new Label
        {
            Text = text,
            FontFamily = "Roboto-Regular",
            Margin = withMargin ? new Thickness(6, 0, 0, 0) : Thickness.Zero
        };

        Grid.SetRow(label, row);
        Grid.SetColumn(label, column);
        grid.Children.Add(label);
    }
}
{% endhighlight %}
{% endtabs %}

