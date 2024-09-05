---
layout: post
title: Accordion Events in .NET MAUI Accordion control | Syncfusion
description: Learn all about Accordion Events support in the Syncfusion .NET MAUI Accordion (SfAccordion) control and more.
platform: MAUI
control: SfAccordion
documentation: ug
--- 

# Accordion Events in .NET MAUI Accordion (SfAccordion)

There are four built-in events in the SfAccordion control namely:

* [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding)
* [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded)
* [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing)
* [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsed)

### Expanding Event

The [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding) event will be triggered when the accordion item is being expanded. It can cancel expansion with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be cancelled.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html#Syncfusion_Maui_Accordion_ExpandingAndCollapsingEventArgs_Index): Gets the index of the current expanding accordion item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="1"%}
<syncfusion:SfAccordion x:Name="accordion" Expanding="accordion_Expanding">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void accordion_Expanding(object sender, Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs e)
{
    if (e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Expanded Event

The [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded) event is triggered when the accordion item is fully expanded. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="1" %}
<syncfusion:SfAccordion x:Name="accordion" Expanded="accordion_Expanded">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4"%}
private void accordion_Expanded(object sender, Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs e)
{
    // Get the index of current accordion item
    int index = e.Index;
}
{% endhighlight %}
{% endtabs %}

### Collapsing Event

The [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing) event will be triggered when the expander control is being collapsed.It can cancel collapsing with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be cancelled.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html#Syncfusion_Maui_Accordion_ExpandingAndCollapsingEventArgs_Index): Gets the index of the current collapsing accordion item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="1"%}
<syncfusion:SfAccordion x:Name="accordion" Collapsing="accordion_Collapsing">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void accordion_Collapsing(object sender, Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs e)
{
    if (e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Collapsed Event 

The [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsed) event is triggered when the accordion item is collapsed. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="1"%}
<syncfusion:SfAccordion x:Name="accordion" Collapsed="accordion_Collapsed">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4"%}
private void accordion_Collapsed(object sender, Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs e)
{
    // Get the index of current accordion item
    int index = e.Index;
}
{% endhighlight %}
{% endtabs %}