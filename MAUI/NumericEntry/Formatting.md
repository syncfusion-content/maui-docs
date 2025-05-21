---
layout: post
title: Change Number Format in .NET MAUI NumericEntry | Syncfusion®
description: Learn about changing the number format of the Syncfusion® .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# Value Formatting with .NET MAUI NumericEntry

This section explains how to change the value format of the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control using the `CustomFormat` properties.

## Currency, Percentage, and Decimal Format

The value of the `NumericEntry` control can be formatted using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) property. By default, the value is formatted based on the current culture's decimal format. The default value of the `CustomFormat` is `null`.

The following example demonstrates how to set the `CurrencyFormatter`, `DecimalFormatter`, and `PercentFormatter` for the `NumberFormatter` property.

Using **N**, **C**, and **P** format values, you can apply numeric, currency, and percent custom formats in the `CustomFormat` property.

N> You can apply various custom formats available on [this page](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings), which are supported for the `double` type.

{% tabs %}
{% highlight xaml %}

// Format stock price in currency.
<editors:SfNumericEntry CustomFormat="C2" WidthRequest="200" />

// Format product discount in percent.
<editors:SfNumericEntry CustomFormat="P2" WidthRequest="200" />

// Format worked hours in decimal.
<editors:SfNumericEntry CustomFormat="N2" WidthRequest="200" />


{% endhighlight %}
{% highlight c# %}

// Format stock price in currency.
var stockPrice = new SfNumericEntry
{
    CustomFormat = "C2",
    WidthRequest = 200
};

// Format product discount in percent.
var productDiscount = new SfNumericEntry
{
    CustomFormat = "P2",
    WidthRequest = 200
};

// Format worked hours in decimal.
var hoursWorked = new SfNumericEntry
{
    CustomFormat = "N2",
    WidthRequest = 200
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize format by NumberFormatter](Formatting_images/maui-numeric-entry-numberformatter.png)

## Format the Integer Digits

The decimal digits of the value in the `NumericEntry` control can be changed using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) properties.

For the `CustomFormat` property, use the **0** format specifier to set the minimum number of decimal digits.  

N> **0** (Zero placeholder) replaces the zero with the corresponding digit present in the value; otherwise, zero appends to the leftmost position of the value.

{% tabs %}
{% highlight xaml %}

// Format stock price in currency.
<editors:SfNumericEntry CustomFormat="$00000.00" WidthRequest="200"/>

// Format product discount in percentage.
<editors:SfNumericEntry CustomFormat="00000.00%" WidthRequest="200"/>

// Format worked hours in decimal.
<editors:SfNumericEntry CustomFormat="00000.00" WidthRequest="200"/>

{% endhighlight %}
{% highlight c# %}

// Format stock price in currency.
var stockPrice = new SfNumericEntry
{
    CustomFormat = "$00000.00",
    WidthRequest = 200
};

// Format product discount in percentage.
var productDiscount = new SfNumericEntry
{
    CustomFormat = "00000.00%",
    WidthRequest = 200
};

// Format worked hours in decimal.
var hoursWorked = new SfNumericEntry
{
    CustomFormat = "00000.00",
    WidthRequest = 200
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize decimal digits](Formatting_images/maui-numeric-entry-change-decimal-digits.png)

## Format the Fractional Digits

The fractional digits of the value in the `NumericEntry` control can be altered using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) properties.

For the `CustomFormat` property, use the **0** format specifier to set the minimum number of fractional digits.  

N> **0** (Zero placeholder) replaces the zero with the corresponding digit in the value.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry CustomFormat="$000.000" WidthRequest="200"/>
<editors:SfNumericEntry CustomFormat="00.000%" WidthRequest="200"/>
<editors:SfNumericEntry CustomFormat="00.000" WidthRequest="200"/>

{% endhighlight %}
{% highlight c# %}

var stockPrice = new SfNumericEntry
{
    CustomFormat = "$000.000",
    WidthRequest = 200
};

var productDiscount = new SfNumericEntry
{
    CustomFormat = "00.000%",
    WidthRequest = 200
};

var hoursWorked = new SfNumericEntry
{
    CustomFormat = "00.000",
    WidthRequest = 200
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize fractional digits](Formatting_images/maui-numeric-entry-change-fractional-digits.png)

## Apply Custom Format

Custom formats can be applied to the `NumericEntry` control using the **0** and **#** format specifiers. These specifiers allow setting minimum and maximum fractional digits in the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) property.

* **0** (Zero placeholder) replaces the zero with a corresponding digit in the value, or appends zero to the leftmost position if absent.
* **#** (Digit placeholder) replaces the symbol with a corresponding digit in the value, or appends no digits if absent.

In this example, the `CustomFormat` property is set to **#.00##**, allowing a maximum of `4` fractional digits and a minimum of `2`.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="stockPrice" CustomFormat="$00.00##" WidthRequest="200"/>
<editors:SfNumericEntry x:Name="productDiscount" CustomFormat="00.00##%" WidthRequest="200"/>
<editors:SfNumericEntry x:Name="hoursWorked" CustomFormat="00.00##" WidthRequest="200"/>

{% endhighlight %}
{% highlight c# %}

var stockPrice = new SfNumericEntry
{
    CustomFormat = "$00.00##",
    WidthRequest = 200
};

var productDiscount = new SfNumericEntry
{
    CustomFormat = "00.00##%",
    WidthRequest = 200
};

var hoursWorked = new SfNumericEntry
{
    CustomFormat = "00.00##",
    WidthRequest = 200
};

{% endhighlight %}
{% endtabs %}


![.NET MAUI NumericEntry customize fractional digits](Formatting_images/maui-numeric-entry-apply-customformat.png)

## Culture Support

Culture support configures the control for a specific language using the `culture` property.

{% tabs %}
{% highlight c# %}

CultureInfo culture = new CultureInfo("en-US");
NumericEntry.Culture = culture;
         
{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry culture-based custom format](Formatting_images/maui-numeric-entry-culture_support.png)

## Customize Percentage Display

When the [SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) is set to percentage format, it can display values in two ways:

`Value`: Displays the actual value with a percentage symbol.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="numericEntry" WidthRequest="200"
                        CustomFormat="p" 
                        Value="1000"  
                        PercentDisplayMode="Value">
</editors:SfNumericEntry>

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry= new SfNumericEntry();
sfNumericEntry.CustomFormat = "p";
sfNumericEntry.Value = 1000;
sfNumericEntry.PercentDisplayMode = PercentDisplayMode.Value;
sfNumericEntry.WidthRequest = 200;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry PercentDisplayMode](GettingStarted_images/percentdisplaymode_value.png)

`Compute`: Displays the computed value with a percentage symbol.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="numericEntry" WidthRequest="200"
                        CustomFormat="p" 
                        Value="1000"  
                        PercentDisplayMode="Value">
</editors:SfNumericEntry>

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry= new SfNumericEntry();
sfNumericEntry.Value = 1000;
sfNumericEntry.CustomFormat = "p";
sfNumericEntry.PercentDisplayMode = PercentDisplayMode.Value;
sfNumericEntry.WidthRequest = 200;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry PercentDisplayMode](GettingStarted_images/percentdisplaymode_compute.png)

N> The default value of `PercentDisplayMode` is `Compute`.

## Manage Maximum Decimal Digits

Specify the maximum number of digits displayed after the decimal point using the `MaximumNumberDecimalDigits` property.

N> The `MaximumNumberDecimalDigits` property must be positive and will not function when a CustomFormat is provided. The default value is 2.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry x:Name="numericEntry" WidthRequest="200"
                        Value="1000.23232"  
                        MaximumNumberDecimalDigits="3">
</editors:SfNumericEntry>

{% endhighlight %}
{% highlight C# %}

SfNumericEntry sfNumericEntry= new SfNumericEntry();
sfNumericEntry.WidthRequest = 200;
sfNumericEntry.Value = 1000.23232;
sfNumericEntry.MaximumNumberDecimalDigits = 3;

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry MaximumNumberDecimalDigits](GettingStarted_images/maximumnumberdecimaldigits.png)
