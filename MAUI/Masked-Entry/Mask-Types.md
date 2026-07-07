---
layout: post
title: Mask Types in .NET MAUI Masked Entry control | Syncfusion®
description: Learn more about the various mask types available in the Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control, including Simple and RegEx, and how to use them effectively.
platform: maui
control: SfMaskedEntry
documentation: ug
---

# Mask Types in .NET MAUI Masked Entry

## Prerequisites

Before using the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), ensure the following are set up:

1. Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.
2. Register the Syncfusion license in your application. Refer to the [Syncfusion licensing documentation](https://help.syncfusion.com/maui/licensing/overview) for more details.

    ```csharp
    using Syncfusion.Licensing;

    public class App : Application
    {
        public App()
        {
            // Replace the license key with your own.
            SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
            InitializeComponent();
        }
    }
    ```

3. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`:

    ```csharp
    using Syncfusion.Maui.Core.Hosting;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
    ```

4. Add the following namespace declaration to your XAML page and `using` directive to your C# files:

    ```xml
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    ```

    ```csharp
    using Syncfusion.Maui.Inputs;
    ```

For a step-by-step setup, refer to the [Getting Started](getting-started.md) documentation.

The [MaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_MaskType) property of type [MaskedEntryMaskType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html) defines the masking format applied to the user input. The default value is `MaskedEntryMaskType.Simple`.

The following table summarizes the differences between the available mask types:

| Mask type | When to use | Format syntax | [ValueMaskFormat](formatting-value.md) |
| --- | --- | --- | --- |
| `Simple` | Fixed-format input such as phone numbers, dates, or product keys. | Mask elements (for example, `0`, `9`, `L`, `>`). | Supported. |
| `RegEx` | Custom validation patterns such as email addresses, IP addresses, or custom rules. | Standard .NET regular expressions. | Not supported (the mask is treated as a regex). |

The available mask types are:

- [Simple](#simple) — fixed-format masks built from mask elements.
- [RegEx](#regex) — masks that use standard regular-expression patterns.

## Simple

Masks that use a combination of letters, digits, and special characters fall into the Simple group. Simple masks are mainly used for fixed-length inputs, such as phone numbers, dates, or product keys. The mask is built from the mask elements listed below.

The [PromptChar](basic-features.md#setting-promptchar) and [ValueMaskFormat](formatting-value.md) properties are only supported by the `Simple` mask type.

### Simple mask elements

<table>
<tr>
<th>
Elements</th><th>
Description</th></tr>
<tr>
<td>
0</td><td>
Digit, required. This element accepts any single digit between 0 and 9.</td></tr>
<tr>
<td>
9</td><td>
Digit or space, optional. This element does not allow sign characters.</td></tr>
<tr>
<td>
#</td><td>
Digit or space, optional. Plus (+) and minus (-) signs are allowed.</td></tr>
<tr>
<td>
L</td><td>
Letter, required. Restricts input to the ASCII letters a-z and A-Z. This mask element is equivalent to <code>[a-zA-Z]</code> in regular expressions.</td></tr>
<tr>
<td>
?</td><td>
Letter, optional. Restricts input to the ASCII letters a-z and A-Z. This mask element is equivalent to <code>[a-zA-Z]?</code> in regular expressions.</td></tr>
<tr>
<td>
C</td><td>
Character, optional. Accepts any printable ASCII character.</td></tr>
<tr>
<td>
A</td><td>
Alphanumeric, required. Accepts any digit (0-9) or ASCII letter (a-z, A-Z).</td></tr>
<tr>
<td>
&lt;</td><td>
Shift down. Converts all the characters that follow to lowercase.</td></tr>
<tr>
<td>
&gt;</td><td>
Shift up. Converts all the characters that follow to uppercase.</td></tr>
</table>

### Simple mask example

The following example formats input as a U.S. phone number using the Simple mask `(000) 000-0000`:

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="Simple"
                          Mask="(000) 000-0000"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "(000) 000-0000";

{% endhighlight %}
{% endtabs %}

The mask renders the input as `(123) 456-7890` when the user types the digits `1234567890`.

The following example uses the `>` shift modifier to convert input to uppercase:

```xaml
<editors:SfMaskedEntry WidthRequest="200"
                       MaskType="Simple"
                       Mask=">AAAA-AAAA"/>
```

Typing `abcd1234` is rendered as `ABCD-1234`.

![Mask type simple in MAUI MaskedEntry](MaskedEntry_Images/maui_mask_type_simple.gif)

## RegEx

RegEx masks use standard regular-expression patterns to validate input, for example `[0-9A-Z]` for alphanumeric values or `[A-Za-z0-9._%-]+@[A-Za-z0-9]+\.[A-Za-z]{2,3}` for an email address.

> **Note:** When `MaskType` is `RegEx`, the [ValueMaskFormat](formatting-value.md) property is not applied because the mask is treated as a regular expression.

### RegEx mask elements

The following table lists the most common regular-expression elements supported by the RegEx mask type:

<table>
<tr>
<th>
Elements</th><th>
Description</th></tr>
<tr>
<td>
[ABC]</td><td>
Character class. Accepts any single character included in the specified set of characters.</td></tr>
<tr>
<td>
[^ABC]</td><td>
Negated character class. Accepts any single character not included in the specified set of characters.</td></tr>
<tr>
<td>
[0-9A-Z]</td><td>
Range. Accepts any digit between 0-9 and any letter between A-Z.</td></tr>
<tr>
<td>
^</td><td>
Anchor. Matches the start of the input string (or line, in multiline mode).</td></tr>
<tr>
<td>
$</td><td>
Anchor. Matches the end of the input string (or line, in multiline mode).</td></tr>
<tr>
<td>
.</td><td>
Wildcard. Matches any character except the newline character (<code>\n</code>).</td></tr>
<tr>
<td>
\d</td><td>
Digit. Accepts any digit. Same as <code>[0-9]</code>.</td></tr>
<tr>
<td>
\D</td><td>
Non-digit. Accepts any non digit. Same as <code>[^0-9]</code>.</td></tr>
<tr>
<td>
\w</td><td>
Word character. Same as <code>[a-zA-Z_0-9]</code>.</td></tr>
<tr>
<td>
\W</td><td>
Non-word character. Same as <code>[^a-zA-Z_0-9]</code>.</td></tr>
<tr>
<td>
\s</td><td>
Whitespace. Accepts any whitespace character such as space or tab.</td></tr>
<tr>
<td>
\S</td><td>
Non-whitespace. Accepts any non-whitespace character.</td></tr>
<tr>
<td>
\b</td><td>
Word boundary. Matches the position between a word and a non-word character.</td></tr>
<tr>
<td>
(ABC)</td><td>
Grouping. Groups the enclosed pattern as a single unit.</td></tr>
<tr>
<td>
(?=ABC)</td><td>
Positive lookahead. Asserts that the following group matches without consuming characters.</td></tr>
<tr>
<td>
(?!ABC)</td><td>
Negative lookahead. Asserts that the following group does not match.</td></tr>
<tr>
<td>
(?<=ABC)</td><td>
Positive lookbehind. Asserts that the preceding group matches.</td></tr>
<tr>
<td>
(?<!ABC)</td><td>
Negative lookbehind. Asserts that the preceding group does not match.</td></tr>
<tr>
<td>
{n}</td><td>
Quantifier. Accepts the input exactly <code>n</code> times.</td></tr>
<tr>
<td>
{n,}</td><td>
Quantifier. Accepts the input <code>n</code> or more times.</td></tr>
<tr>
<td>
{n,m}</td><td>
Quantifier. Accepts the input between <code>n</code> and <code>m</code> times.</td></tr>
<tr>
<td>
+</td><td>
Quantifier. Accepts one or more matches of the preceding element.</td></tr>
<tr>
<td>
*</td><td>
Quantifier. Accepts zero or more matches of the preceding element.</td></tr>
<tr>
<td>
?</td><td>
Quantifier. Accepts zero or one occurrence of the preceding element.</td></tr>
<tr>
<td>
|</td><td>
Alternation. Acts like a Boolean OR; matches the expression before or after the pipe.</td></tr>
<tr>
<td>
\\</td><td>
Escape. Escapes a metacharacter so it is matched literally (for example, <code>\\.</code> matches a dot).</td></tr>
</table>

### RegEx mask example

The following example validates an email address using the RegEx mask `[A-Za-z0-9._%-]+@[A-Za-z0-9]+\.[A-Za-z]{2,3}`:

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry WidthRequest="200"
                          ClearButtonVisibility="WhileEditing"
                          MaskType="RegEx"
                          Mask="[A-Za-z0-9._%-]+@[A-Za-z0-9]+\.[A-Za-z]{2,3}"/>

{% endhighlight %}
{% highlight c# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.RegEx;
maskedEntry.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+\\.[A-Za-z]{2,3}";

{% endhighlight %}
{% endtabs %}

The mask accepts strings such as `user@example.com` and rejects incomplete or malformed values.

![Mask type RegEx in MAUI MaskedEntry](MaskedEntry_Images/maui_mask_type_regex.gif)

## See Also

* [Getting Started with .NET MAUI Masked Entry](getting-started.md)
* [Basic Features in .NET MAUI Masked Entry](basic-features.md)
* [Formatting Value in .NET MAUI Masked Entry](formatting-value.md)
* [Validation in .NET MAUI Masked Entry](validation.md)
* [Events in .NET MAUI Masked Entry](events.md)
* [SfMaskedEntry API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html)