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
<syncfusion:SfExpander x:Name="expander">
    <syncfusion:SfExpander.Header>
        <Grid>
            <Label  Text="Veg Pizza" VerticalTextAlignment="Center"/>
        </Grid>
    </syncfusion:SfExpander.Header>
    <syncfusion:SfExpander.Content>
        <Grid>
            <Label HeightRequest="50" Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products." VerticalTextAlignment="Center"/>
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
                        <Setter Property="HeaderBackground" Value="Green"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateGroupList>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# %}
SfExpander expander = new SfExpander();
expander.Header = new Label() 
{
    Text="Veg Pizza" 
};
expander.Content = new Label() 
{ 
    Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products."
};
    
VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

VisualState expanded = new VisualState
{
    Name = "Expanded"
};
expanded.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Color.Red });
expanded.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Color.Red });

VisualState collapsed = new VisualState
{
    Name = "Collapsed"
};
collapsed.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Color.Green });
collapsed.Setters.Add(new Setter { Property = SfExpander.HeaderBackgroundProperty, Value = Color.Green });
    
commonStateGroup.States.Add(expanded);
commonStateGroup.States.Add(collapsed);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(expander, visualStateGroupList);
this.Content = expander;
{% endhighlight %}
{% endtabs %}

![.Net MAUI Expander with VSM](Images/maui-expander-collapsed.png)
![.Net MAUI Expander with VSM](Images/maui-expander-expanded.png)
