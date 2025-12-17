---
layout: post
title: Liquid Glass Effect for .NET MAUI Expander | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Expander (SfExpander) control.
platform: MAUI
control: SfExpander
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Expander (SfExpander)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Expander (SfExpander) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Expander control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `SfExpander`, wrap it inside the `SfGlassEffectView`.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Expander

Set the `EnableLiquidGlassEffect` property to `true` in the `SfExpander` control. When enabled, the effect is applied to the header and content, providing a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfExpander` control:

{% tabs %}
{% highlight xaml tabtitle="ExpanderPage.xaml"%}
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
        <ScrollView>
            <StackLayout HorizontalOptions="{OnPlatform MacCatalyst=Center,WinUI=Center}">
                <Label Text="Invoice: #FRU037020142097"
                       HeightRequest="40"
                       FontSize="16"
                       FontFamily="Roboto-Regular"
                       Opacity="1.0"
                       VerticalTextAlignment="Center"
                       FontAttributes="Bold"
                       VerticalOptions="Center"
                       HorizontalOptions="Center"
                       Margin="{OnPlatform Default='8,12,8,8',WinUI='8,12,6,8',MacCatalyst='8,12,6,8'}"/>

                <!-- Expander 1: Invoice Date -->
                <syncfusion:SfExpander AnimationDuration="200"
                                       IsExpanded="True"
                                       Background="Transparent"
                                       EnableLiquidGlassEffect="True"
                                       Margin="{OnPlatform Default='8,0,8,8',WinUI='8,0,8,8',MacCatalyst='8,0,8,8'}">
                    <syncfusion:SfExpander.Header>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="48"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="35"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="&#xe703;" FontSize="16" Margin="14,2,2,2"
                                   FontFamily="AccordionFontIcons.ttf#"
                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Invoice Date" FontSize="14" Grid.Column="1" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid Padding="18,8,0,18">
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="11:03 AM, 15 January 2019" FontSize="14" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>

                <!-- Expander 2: Items -->
                <syncfusion:SfExpander AnimationDuration="200"
                                       IsExpanded="False"
                                       Background="Transparent"
                                       EnableLiquidGlassEffect="True"
                                       Margin="{OnPlatform Default='8,12,8,8',WinUI='8,12,8,8',MacCatalyst='8,12,8,8'}">
                    <syncfusion:SfExpander.Header>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="48"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="35"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="&#xe701;" FontSize="16" Margin="14,2,2,2"
                                   FontFamily="AccordionFontIcons.ttf#"
                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Item(s)" FontSize="14" Grid.Column="1" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid Padding="16,12,16,12">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto"/>
                                <RowDefinition Height="Auto"/>
                            </Grid.RowDefinitions>
                            <Grid Grid.Row="1">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="20"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="*"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label Text="Total Amount" CharacterSpacing="0.25" VerticalTextAlignment="Center" FontSize="14"/>
                                <Label Text="$36,220.00" CharacterSpacing="0.25" HorizontalTextAlignment="End" VerticalTextAlignment="Center" FontSize="14" Grid.Column="1"/>
                            </Grid>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>

                <!-- Expander 3: Payment Details -->
                <syncfusion:SfExpander AnimationDuration="200"
                                       IsExpanded="False"
                                       Background="Transparent"
                                       EnableLiquidGlassEffect="True"
                                       Margin="{OnPlatform Default='8,12,8,8',WinUI='8,12,8,8',MacCatalyst='8,12,8,8'}">
                    <syncfusion:SfExpander.Header>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="48"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="35"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="&#xe702;" FontSize="16" Margin="14,2,2,2"
                                   FontFamily="AccordionFontIcons.ttf#"
                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Payment Details" FontSize="14" Grid.Column="1" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid Padding="16,12,16,12" RowSpacing="6">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="20"/>
                                <RowDefinition Height="20"/>
                                <RowDefinition Height="20"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Card Payment"/>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Third-Party coupons" Grid.Row="1"/>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" Text="Total Amount Paid" Grid.Row="2"/>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" HorizontalOptions="End" Text="$31,200.00" Grid.Column="1"/>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" HorizontalOptions="End" Text="$5,000.00" Grid.Row="1" Grid.Column="1"/>
                            <Label FontSize="14" CharacterSpacing="0.25" FontFamily="Roboto-Regular" HorizontalOptions="End" Text="$36,200.00" Grid.Row="2" Grid.Column="1"/>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>

                <!-- Expander 4: Address -->
                <syncfusion:SfExpander AnimationDuration="200"
                                       IsExpanded="True"
                                       Background="Transparent"
                                       EnableLiquidGlassEffect="True"
                                       Margin="{OnPlatform Default='8,12,8,8',WinUI='8,12,8,8',MacCatalyst='8,12,8,8'}">
                    <syncfusion:SfExpander.Header>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="48"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="35"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Text="&#xe704;" FontSize="16" Margin="14,2,2,2"
                                   FontFamily="AccordionFontIcons.ttf#"
                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" Text="Address" Grid.Column="1" VerticalOptions="Center"/>
                        </Grid>
                    </syncfusion:SfExpander.Header>
                    <syncfusion:SfExpander.Content>
                        <Grid Padding="16,12,16,12" RowSpacing="1">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto"/>
                                <RowDefinition Height="Auto"/>
                                <RowDefinition Height="Auto"/>
                            </Grid.RowDefinitions>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" Text="Alex" FontAttributes="Bold"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" Text="No.8 Blossom St, Washington, DC 20019" Grid.Row="1"/>
                            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" Text="(202) 547-3555" Grid.Row="2"/>
                        </Grid>
                    </syncfusion:SfExpander.Content>
                </syncfusion:SfExpander>
            </StackLayout>
        </ScrollView>
    </core:SfGlassEffectView>
</Grid>
{% endhighlight %}
{% highlight c# tabtitle="ExpanderPage.xaml.cs" %}
using Syncfusion.Maui.Core;
using Syncfusion.Maui.Expander;

// Gradient background
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

var root = new Grid { Background = gradientBrush };

// Glass effect host
var glass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = LiquidGlassEffectType.Regular
};

var scroll = new ScrollView();
var stack = new VerticalStackLayout
{
    HorizontalOptions = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst
        ? LayoutOptions.Center
        : LayoutOptions.Fill
};

// Title
stack.Add(new Label
{
    Text = "Invoice: #FRU037020142097",
    HeightRequest = 40,
    FontSize = 16,
    FontFamily = "Roboto-Regular",
    Opacity = 1.0,
    VerticalTextAlignment = TextAlignment.Center,
    FontAttributes = FontAttributes.Bold,
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.CenterAndExpand,
    Margin = DeviceInfo.Platform switch
    {
        DevicePlatform.WinUI => new Thickness(8,12,6,8),
        DevicePlatform.MacCatalyst => new Thickness(8,12,6,8),
        _ => new Thickness(8,12,8,8)
    }
});

// Single Expander: Invoice Date
stack.Add(new SfExpander
{
    AnimationDuration = 200,
    IsExpanded = true,
    Background = Colors.Transparent,
    EnableLiquidGlassEffect = true,
    Margin = new Thickness(8,0,8,8),
    Header = new Grid
    {
        RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = 48 } },
        ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition{ Width = 35 }, new ColumnDefinition{ Width = GridLength.Star } },
        Children =
        {
            new Label { Text = "\uE703", FontSize = 16, Margin = new Thickness(14,2,2,2), FontFamily = "AccordionFontIcons.ttf#", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center },
            new Label { Text = "Invoice Date", FontSize = 14, CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", VerticalOptions = LayoutOptions.Center, GridColumn = 1 }
        }
    },
    Content = new Grid
    {
        Padding = new Thickness(18,8,0,18),
        Children =
        {
            new Label { Text = "11:03 AM, 15 January 2019", FontSize = 14, CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", VerticalOptions = LayoutOptions.Center }
        }
    }
});

scroll.Content = stack;

glass.Content = scroll;
root.Children.Add(glass);
this.Content = root;
{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`