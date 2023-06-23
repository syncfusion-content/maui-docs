---
layout: post
title: Change Number Format in .NET MAUI NumericEntry | Syncfusion
description: Learn here about changing the number format of Syncfusion .NET MAUI NumericEntry (SfNumericEntry) control and more.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# Value Formatting with .NET MAUI NumericEntry

This section explains how to change the value format of the [NumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html) control using the `CustomFormat` properties.

## Currency, percentage and decimal format

The value of the `NumericEntry` control can be formatted using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) property. By default, the value is formatted based on the current culture's decimal format. The default value of the `CustomFormat` properties is **null**.

The following example shows how to set the `CurrencyFormatter`, `DecimalFormatter`, and `PercentFormatter` for the `NumberFormatter` property. 

Using the **N**, **C**, and **P** format values, we can apply numeric, currency, and percent custom formats in the `CustomFormat` property. 

N> You can apply various custom formats available in  [this page](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings), which are supported for the `double` type.

{% tabs %}
{% highlight xaml %}

// Format stock price in currency.
<editors:SfNumericEntry CustomFormat="C2"/>

// Format product discount in percent.
<editors:SfNumericEntry CustomFormat="P2"/>

// Format worked hours in decimal.
<editors:SfNumericEntry CustomFormat="N2"/>

{% endhighlight %}
{% highlight c# %}

// Format stock price in currency.
stockPrice.CustomFormat = "C2";

// Format product discount in percent.
productDiscount.CustomFormat = "P2";

// Format worked hours in decimal.
hoursWorked.CustomFormat = "N2";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize format by NumberFormatter](Formatting_images/maui-numeric-entry-numberformatter.png)

## Format the integer digits

You can change the decimal digits of the value in the `NumericEntry` control using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) properties. 

For the `CustomFormat` property, use the **0** format specifier to set the minimum number of decimal digits.  

N> **0** (Zero placeholder) replaces the zero with the corresponding digit present in the value; otherwise, zero appends with the leftmost position of the value. 

{% tabs %}
{% highlight xaml %}

// Format stock price in currency.
<editors:SfNumericEntry CustomFormat = "$00000.00"/>

// Format product discount in percentage.
<editors:SfNumericEntry CustomFormat = "00000.00%"/>

// Format worked hours in decimal.
<editors:SfNumericEntry CustomFormat = "00000.00"/>

{% endhighlight %}
{% highlight c# %}

// Format stock price in currency.
stockPrice.CustomFormat = "$00000.00";

// Format product discount in percentage.
productDiscount.CustomFormat = "00000.00%";

// Format worked hours in decimal.
hoursWorked.CustomFormat = "00000.00";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize decimal digits](Formatting_images/maui-numeric-entry-change-decimal-digits.png)

## Format the fractional digits

You can change the fractional digits of the value in the `NumericEntry` control using the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) Properties.

For the `CustomFormat` property, use the **0** format specifier to set the minimum number of fractional digits.  

N> **0** (Zero placeholder) replaces the zero with the corresponding digit in the value.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry CustomFormat = "$000.000"/>
<editors:SfNumericEntry CustomFormat = "00.000%"/>
<editors:SfNumericEntry CustomFormat = "00.000"/>

{% endhighlight %}
{% highlight c# %}

stockPrice.CustomFormat = "$000.000";
productDiscount.CustomFormat = "00.000%";
hoursWorked.CustomFormat = "00.000";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize fractional digits](Formatting_images/maui-numeric-entry-change-fractional-digits.png)

## Apply custom format

You can apply custom formats to the `NumericEntry` control using the **0** and **#** format specifiers. Using these format specifiers, you can set the minimum and the maximum number of fractional digits in the [CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat) property.

   * **0** (Zero placeholder) replaces the zero with the corresponding digit present in the value; otherwise, zero appends with the leftmost position of the value. 

   * **#** (Digit placeholder) replaces the number sign symbol with the corresponding digit present in the value; otherwise, no digit will append to the value.

In the following example, the value of the `CustomFormat` property is **#.00##**, hence it will allow a maximum of `4` fractional digits and a minimum of `2` fractional digits.

{% tabs %}
{% highlight xaml %}

<editors:SfNumericEntry CustomFormat = "$00.00##"/>
<editors:SfNumericEntry CustomFormat = "00.00##%"/>
<editors:SfNumericEntry CustomFormat = "00.00##"/>

{% endhighlight %}
{% highlight c# %}

stockPrice.CustomFormat = "$00.00##";
productDiscount.CustomFormat = "00.00##%";
hoursWorked.CustomFormat = "00.00##";

{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry customize fractional digits](Formatting_images/maui-numeric-entry-apply-customformat.png)


## Culture support

The culture support allows the control to be configured for a specific language. To configure this, use the `culture` property.

{% tabs %}
{% highlight c# %}

CultureInfo culture = new CultureInfo("en-US");
NumericEntry.Culture = culture;
         
{% endhighlight %}
{% endtabs %}

![.NET MAUI NumericEntry culture based custom format](Formatting_images/maui-numeric-entry-culture_support.png)

