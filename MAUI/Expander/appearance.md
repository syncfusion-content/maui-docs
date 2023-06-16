---
layout: post
title: Appearance in .NET MAUI Expander control | Syncfusion
description: Learn here all about Appearance support in Syncfusion .NET MAUI Expander (SfExpander) control and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Appearance in .NET MAUI Expander (SfExpander)

The .NET MAUI SfExpander comes with built-in support for customizing the appearance of the header.

## Header icon position 

The `SfExpander` allows you to customize the position of the header icon by using the `HeaderIconPosition` property. By default, the header icon position is `End`. 

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" HeaderIconPosition="Start" />
{% endhighlight %}
{% highlight c# %}
    expander.HeaderIconPosition = Syncfusion.Maui.Expander.ExpanderIconPosition.Start;
{% endhighlight %}
{% endtabs %}

![.NET MAUI Expander with HeaderIconPosition Start](Images/appearance/maui-expander-with-headericonposition.png)

## Header background color customization

The `SfExpander` allows you to customize the background color of the expander header by using the `HeaderBackgroundColor` property.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" HeaderBackground="Pink"/>
{% endhighlight %}
{% highlight c# %}
    expander.HeaderBackground = Colors.Pink;
{% endhighlight %}
{% endtabs %}

## Icon color customization

The `SfExpander` allows you to customize the color of the expander icon by using the `HeaderIconColor` property.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" HeaderIconColor="Brown"/>
{% endhighlight %}
{% highlight c# %}
    expander.HeaderIconColor = Colors.Brown;
{% endhighlight %}
{% endtabs %}

## Visual State Manager

The appearance of the `SfExpander` can be customized using the following two `VisualStates`:

* Expanded
* Collapsed

{% tabs %}
{% highlight xaml hl_lines="26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43" %}
<syncfusion:SfExpander x:Name="expander1" IsExpanded="True" >
    <syncfusion:SfExpander.Header>
        <Grid >
            <Grid.RowDefinitions>
                <RowDefinition Height="48"/>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="35"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Label Text="&#xe703;" FontSize="16" Margin="14,2,2,2"
                                    TextColor="{Binding Path=HeaderIconColor,Source={x:Reference expander1}}"
                                    FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                    VerticalOptions="Center" VerticalTextAlignment="Center"/>
            <Label CharacterSpacing="0.25" TextColor="{Binding Path=HeaderIconColor,Source={x:Reference expander1}}" FontFamily="Roboto-Regular"  Text="Invoice Date" FontSize="14" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
            </Grid>
    </syncfusion:SfExpander.Header>
    <syncfusion:SfExpander.Content>
        <Grid Padding="18,8,0,18" >
            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="11:03 AM, 15 January 2019" FontSize="14" VerticalOptions="CenterAndExpand"/>
        </Grid>
    </syncfusion:SfExpander.Content>
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroupList>
            <VisualStateGroup>
                <VisualState Name="Expanded">
                    <VisualState.Setters>
                            <Setter Property="HeaderBackground" Value="#6750A4"/>
                            <Setter Property="HeaderIconColor" Value="#FFFFFF"/>
                        </VisualState.Setters>
                </VisualState>
                <VisualState Name="Collapsed">
                    <VisualState.Setters>
                            <Setter Property="HeaderBackground" Value="#141C1B1F"/>
                            <Setter Property="HeaderIconColor" Value="#49454F"/>
                        </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateGroupList>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfExpander>
{% endhighlight %}
{% endtabs %}

![Expanded and collapsed visual states in .NET MAUI Expander](Images/appearance/maui-expander-with-vsm.png)

You can download the entire source of this demo [here](https://github.com/SyncfusionExamples/customize-the-appearance-using-visual-state-manager-in-.net-maui-expander).

