---
layout: post
title: Liquid Glass Effect for .NET MAUI Accordion | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Accordion (SfAccordion) control.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Accordion (SfAccordion)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Accordion (SfAccordion) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Accordion control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `SfAccordion`, wrap it inside the `SfGlassEffectView`.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Accordion

Set the `EnableLiquidGlassEffect` property to `true` in the `SfAccordion` control. When enabled, the effect is applied to all accordion items and provides responsive interaction for a smooth and engaging user experience. 

### Step 3: Customize the background

To achieve a glass like background, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfAccordion` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14" %}
<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75" Offset="0.0"/>
            <GradientStop Color="#3282B8" Offset="0.5"/>
            <GradientStop Color="#1B262C" Offset="1.0"/>
        </LinearGradientBrush>
    </Grid.Background>

    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <syncfusion:SfAccordion Background="Transparent"
                                EnableLiquidGlassEffect="True">
            <syncfusion:SfAccordion.Items>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid  HeightRequest="48">
                            <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4"  >
                            <Grid Margin="16,6,0,0">
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions >
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="{OnPlatform Default=90,Android=90,WinUI=70, iOS=100,MacCatalyst=70 }"/>
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Border Grid.RowSpan="4"
                                        Grid.Row="0"
                                        Grid.Column="0"
                                        Padding="0"
                                        Margin="0,0,0,7">
                                    <Image  Source="emp_01.png" />
                                </Border>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="Chairman" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="Boston" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                       FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                       Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                           FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                           VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                ..........................
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion>
    </core:SfGlassEffectView>
</Grid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="21 22 23 24 25 30" %}
using Syncfusion.Maui.Core;
using Syncfusion.Maui.Accordion;

var gradientBrush = new LinearGradientBrush
{
    StartPoint = new Point(0, 0),
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection
    {
        new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0f },
        new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5f },
        new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0f }
    }
};

var grid = new Grid
{
    Background = gradientBrush
};

var glassView = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = LiquidGlassEffectType.Regular
};

var accordion = new SfAccordion
{
    Background = Colors.Transparent,
    EnableLiquidGlassEffect = true
};

var accordionItem = new AccordionItem();
var headerGrid = new Grid { HeightRequest = 48 };
headerGrid.Children.Add(new Label
{
    Text = "Robin Rane",
    Margin = new Thickness(16, 14, 0, 14),
    CharacterSpacing = 0.25,
    FontFamily = "Roboto-Regular",
    FontSize = 14
});

accordionItem.Header = headerGrid;
var contentGrid = new Grid
{
    ColumnSpacing = 10,
    RowSpacing = 2,
    BackgroundColor = Color.FromArgb("#f4f4f4")
};

var descriptionLabel = new Label
{
    Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision. Under his guidance, the company thrives and continues to make a significant impact in the industry.",
    Margin = new Thickness(16, 6, 0, 0),
    Padding = new Thickness(0, 10, 0, 10),
    LineBreakMode = LineBreakMode.WordWrap,
    FontSize = 14,
    CharacterSpacing = 0.25,
    VerticalTextAlignment = TextAlignment.Center
};

contentGrid.Children.Add(descriptionLabel);
accordionItem.Content = contentGrid;
accordion.Items.Add(accordionItem);
glassView.Content = accordion;
grid.Children.Add(glassView);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`