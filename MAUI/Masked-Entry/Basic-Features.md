---
layout: post
title: Basic Features in .NET MAUI Masked Entry control | Syncfusion
description:  Learn here all about Basic Features support in Syncfusion .NET MAUI Masked Entry (SfMaskedEntry) control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Basic Features in .NET MAUI Masked Entry (SfMaskedEntry)

## Setting ClearButtonVisibility

ClearButtonVisibility, of type ClearButtonVisibility, controls whether a clear button is displayed, which enables the user to clear the text. The default value of this property is `ClearButtonVisibility.Never`.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="(000) 000-0000"
                          ClearButtonVisibility = "Visible" />

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";  
maskedEntry.ClearButtonVisibility = Visible;

{% endhighlight %}
{% endtabs %}

![ClearButtonVisibility](MaskedEntry_Images/MaskedEntry_ClearButtonVisibility.png)

## Setting CursorPosition

Cursor position in the masked entry can either be obtained or updated using `CursorPosition` property in SfMaskedEntry.

## Setting FontSize
The Masked Entry control provides the user to customize the font size of the text inside the entry part using `FontSize` property of type double.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="(000) 000-0000" Value="1234"
                          FontSize="18"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";  
maskedEntry.Value = 1234;
maskedEntry.FontSize = 18;   

{% endhighlight %}
{% endtabs %}

![FontSize](MaskedEntry_Images/MaskedEntry_FontSize.png)

## Setting FontAttributes

The Masked Entry control provides the user to customize the font attribute of the text inside the entry part using `FontAttributes` property of type FontAttributes.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="(000) 000-0000" Value="1234"
                          FontAttributes="Bold"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";  
maskedEntry.Value = 1234;
maskedEntry.FontAttributes = FontAttributes.Bold;   

{% endhighlight %}
{% endtabs %}

![FontAttributes](MaskedEntry_Images/MaskedEntry_FontAttributes.png)

## Setting FontFamily

The Masked Entry control provides the user to customize the font family of the text inside the entry part using `FontFamily` property of type string.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="(000) 000-0000" Value="1234"
                          FontFamily="Lobster-Regular"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";  
maskedEntry.Value = 1234;
maskedEntry.FontFamily = "Lobster-Regular";  

{% endhighlight %}
{% endtabs %}

![FontFamily](MaskedEntry_Images/MaskedEntry_FontFamily.png)

## Setting Keyboard

The Masked Entry control provides the user to specifies the virtual keyboard that's displayed when entering text using `Keyboard` property of type Keyboard.


## Setting Placeholder

The Masked Entry control provides the user to defines the text that's displayed when the Mask and Value is empty using `Placeholder` property of type `string.` The default value of the Placeholder property is string.Empty.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"                         
                          Placeholder="Enter the value"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.Placeholder = "Enter the value";   

{% endhighlight %}
{% endtabs %}

![Placeholder](MaskedEntry_Images/MaskedEntry_Placeholder.png)

## Setting PlaceholderColor

The `SfMaskedEntry` control provides the user to customize the color of the placeholder text using `PlaceholderColor` property of type `Color.` The default value of the PlaceholderColor property is Colors.Gray.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"                         
                          Placeholder="Enter the value"
                          PlaceholderColor="Green"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.Placeholder = "Enter the value"; 
maskedEntry.PlaceholderColor =  Colors.Green;   

{% endhighlight %}
{% endtabs %}

![PlaceholderColor](MaskedEntry_Images/MaskedEntry_PlaceholderColor.png)

## Setting TextColor

The `SfMaskedEntry` control provides the user to customize the color of the entered text using `TextColor` property of type `Color.` The default value of the TextColor property is Colors.Black.

{% tabs %}
{% highlight XAML %}

<syncfusion:SfMaskedEntry WidthRequest="200"
                          MaskType="Simple"
                          Mask="(000) 000-0000" Value="1234"
                          TextColor="Green"/>

{% endhighlight %}
{% highlight C# %}

maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = "200";
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";  
maskedEntry.Value = 1234;
maskedEntry.TextColor =  Colors.Green;   

{% endhighlight %}
{% endtabs %}

![TextColor](MaskedEntry_Images/MaskedEntry_TextColor.png)



