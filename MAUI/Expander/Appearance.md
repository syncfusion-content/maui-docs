---
layout: post
title: Appearance in .NET MAUI Expander control | Syncfusion
description: Learn here all about Appearance support in Syncfusion .NET MAUI Expander (SfExpander) control and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Appearance in .NET MAUI Expander (SfExpander)

The Expander allows to customize appearance of the Icon, and provides various functionalities to the users.

## Header icon position 

The `SfExpander` allows you to customize the position of the header icon by using the `HeaderIconPosition` property. By default, the header icon position is `Start`. 

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" HeaderIconPosition="End" />       
{% endhighlight %}
{% highlight c# %}
    expander.HeaderIconPosition = Syncfusion.Maui.Expander.IconPosition.End;
{% endhighlight %}
{% endtabs %}

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

The `SfExpander` allows you to customize the color of the expander icon by using the `IconColor` property. By default, the icon color is `Black`.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" IconColor="Brown"/>
{% endhighlight %}
{% highlight c# %}
    expander.IconColor = Colors.Brown;
{% endhighlight %}
{% endtabs %}

## Visual State Manager

The appearance of the `SfExpander` can be customized using the following two `VisualStates`:

* Expanded
* Collapsed

{% tabs %}
{% highlight xaml %}
<syncfusion:SfExpander AnimationDuration="200" IsExpanded="True" >
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
                                    FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                    VerticalOptions="Center" VerticalTextAlignment="Center"/>
            <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="Invoice Date" FontSize="14" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
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
                        <Setter Property="HeaderBackground" Value="Red"/>
                    </VisualState.Setters>
                </VisualState>
                <VisualState Name="Collapsed">
                    <VisualState.Setters>
                        <Setter Property="HeaderBackground" Value="Yellow"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateGroupList>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# %}
SfExpander expander = new SfExpander();
expander.IsExpanded = true;
expander.AnimationDuration = 200;

Grid headerGrid = new Grid();
headerGrid.RowDefinitions.Add(new RowDefinition { Height = 48 });
headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = 35 });
headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
Label headerIconLabel = new Label { Text = "\ue703" ,Margin=new Thickness(14, 2, 2, 2), FontSize=16, VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center, FontFamily= DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons": "AccordionFontIcons" };
Label headerTextLabel = new Label { Text = "Invoice Date",CharacterSpacing=0.25, FontSize = 14, FontFamily = "Roboto-Regular", VerticalOptions = LayoutOptions.CenterAndExpand };
headerGrid.Children.Add(headerIconLabel);
headerGrid.Children.Add(headerTextLabel);
headerGrid.SetColumn(headerTextLabel, 1);
expander.Header = headerGrid;

Grid contentGrid = new Grid();
Label contentLabel = new Label { Text = "11:03 AM, 15 January 2019", FontSize = 14, FontFamily = "Roboto-Regular", VerticalOptions = LayoutOptions.CenterAndExpand };
contentGrid.Children.Add(contentLabel);
expander.Content = contentGrid;

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState expanded = new VisualState
{
    Name = "Expanded"
};
expanded.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Colors.Red });

VisualState collapsed = new VisualState
{
    Name = "Collapsed"
};
collapsed.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Colors.Yellow });

commonStateGroup.States.Add(expanded);
commonStateGroup.States.Add(collapsed);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(expander, visualStateGroupList);
this.Content = expander;
{% endhighlight %}
{% endtabs %}

![.Net MAUI Expander in collapsed state with VSM](Images/maui-expander-with-collapsed-vsm.png)

![.Net MAUI Expander in expanded state with VSM](Images/maui-expander-with-expanded-vsm.png)

