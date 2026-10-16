---
layout: post
title: Toggle Methods in .NET MAUI Bottom Sheet | Syncfusion®
description: Learn about toggle methods support in the Syncfusion® .NET MAUI Bottom Sheet (SfBottomSheet) control.
platform: maui
control: SfBottomSheet
documentation: UG
---

# Toggle Methods in .NET MAUI Bottom Sheet

The Bottom Sheet can be toggled using

* IsOpen property
* Show method
* Close method

## Opening and closing the sheet programmatically using property

The [IsOpen]() property allows you to open or close the Bottom Sheet programmatically. By default, the `IsOpen` property is set to `false`.

{% tabs %}

{% highlight xaml %}

<Grid>
    <bottomSheet:SfBottomSheet IsOpen="True">
        <bottomSheet:SfBottomSheet.BottomSheetContent>
            <!--Add your content here-->
        </bottomSheet:SfBottomSheet.BottomSheetContent>
    </bottomSheet:SfBottomSheet>
</Grid>

{% endhighlight %}
{% highlight c# %}

SfBottomSheet bottomSheet = new SfBottomSheet();
bottomSheet.IsOpen = true;

{% endhighlight %}
{% endtabs %}


## Opening and closing sheet programmatically using method

The [Show]() method is used to open the Bottom Sheet, and the [Close]() method is used to close the Bottom Sheet programmatically.

{% tabs %}

{% highlight xaml %}

<bottomSheet:SfBottomSheet x:Name="bottomSheet">
    <bottomSheet:SfBottomSheet.BottomSheetContent>
        <!--Add your content here-->
    </bottomSheet:SfBottomSheet.BottomSheetContent>
</bottomSheet:SfBottomSheet>

{% endhighlight %}
{% highlight c# %}

SfBottomSheet bottomSheet = new SfBottomSheet();

{% endhighlight %}
{% endtabs %}

Using `Show` and `Close` methods,

{% highlight c# %}

private void OnListViewItemTapped(object? sender, ItemTappedEventArgs e)
{
    bottomSheet.BottomSheetContent.BindingContext = e.Item;
    bottomSheet.Show();
}

private void CloseBottomSheet(object sender, EventArgs e)
{
    bottomSheet.Close();
}

{% endhighlight %}

![Toggle method](images/toggleMethod.gif)