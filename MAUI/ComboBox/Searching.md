---
layout: post
title: Searching in .NET MAUI ComboBox control | Syncfusion
description: Learn how to perform the searching operation in Syncfusion .NET MAUI ComboBox (SfComboBox) control and more.
platform: maui
control: SfComboBox
documentation: ug
---

# Searching in .NET MAUI ComboBox (SfComboBox)

The [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control provides rich text searching functionality. The `TextSearchMode` property of the [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) can be used to regulate how the control behaves when it receives user input.

## Search based on member path

The [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath) and [TextMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath) properties of ComboBox control specify the property path, by which the searching must be done when a custom data is bound to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource) property.

 * `DisplayMemberPath` - Specifies the property path whose value is displayed as text in the drop-down menu. The default value is `string.Empty`.

 * `TextMemberPath` - Specifies the property path whose value is used to perform searching based on user input received in the selection box portion of the `ComboBox` control. The default value is `string.Empty`. When `TextMemberPath` is `null` or `string.Empty`, searching will be performed based on `DisplayMemberPath`. 

N> `DisplayMemberPath` and `TextMemberPath` will be effective for the collection item that holds two or more properties in it.

N> When both the `DisplayMemberPath` and `TextMemberPath` properties have a `null` or `string.Empty` value, searching will be performed based on the class name with namespace of the item.

## Edit mode Searching based on TextMemberPath

In edit mode, searching will be performed based on the [TextMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath) property while entering the text into the selection box. When TextMemberPath is `null` or `string.Empty`, searching will be performed based on [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath). 

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="true"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="ID"
                    DisplayMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextMemberPath = "ID";

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox search based on TextMemberPath](Images/Searching/SearchTextMemberPath.png)

## Non-Editable mode Searching based on DisplayMemberPath

In non-editable mode, searching will be performed based on the [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath) property when user input is received in drop-down. 

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="ID" />

{% endhighlight %}

{% highlight C# %}

comboBox.DisplayMemberPath = "ID";

{% endhighlight %}
{% endtabs %}

For e.g. After typing `4` in drop-down.

The following image illustrates the result of the above code:

![.NET MAUI ComboBox search based on DisplayMemberPath](Images/Searching/SearchDisplayMemberPath.png)

N> Auto appending of text is supported only in `Editable` mode and `TextSearchMode` property should be `StartsWith`.

## Text Search Mode

The [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) property of the [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) can be used to regulate how the control behaves when it receives user input. The default text searching type is [StartWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_StartsWith), ignoring accent and it is case insensitive. The available text search modes are:

* StartsWith
* Contains

### Search with beginning text

Set the [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) property value to [StartWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_StartsWith) to search the matching items based on the starting text, and the first item which fits the user input in the drop-down list, will be highlighted.

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    TextSearchMode="StartsWith"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextSearchMode = ComboBoxTextSearchMode.StartsWith;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode StartsWith](Images/Searching/TextSearchModeStartsWith.png)

### Search with contains text

Set the [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) property value to [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_Contains) to search the matching items containing specific text, and the first item which fits the user input in the drop-down list, will be highlighted.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    WidthRequest="250"
                    IsEditable="True"
                    TextSearchMode="Contains"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name" />

{% endhighlight %}

{% highlight C# %}

comboBox.TextSearchMode = ComboBoxTextSearchMode.Contains;

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode Contains](Images/Searching/TextSearchModeContains.png)

### Custom searching

The ComboBox control provides support to apply your own custom search logic to highlight the item in the drop-down based on your search criteria by using the [SearchBehavior] property. The default value of `SearchBehavior` is `null`.

Now, let us create a custom searching class to apply our own search logic to ComboBox control by the following steps:

**Step 1:** Create a class that derives from the [IComboBoxSearchBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.IComboBoxSearchBehavior.html) interface. 

{% tabs %}
{% highlight C# %}

/// <summary>
/// Represents a custom searching behavior for `ComboBox` control. 
/// </summary>
public class StringLengthSearchingBehavior : IComboBoxSearchBehavior
{
   
}

{% endhighlight %}
{% endtabs %}

**Step 2:** Then, implement the [GetHighlightIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.IComboBoxSearchBehavior.html#Syncfusion_Maui_Inputs_IComboBoxSearchBehavior_GetHighlightIndex_Syncfusion_Maui_Inputs_SfComboBox_Syncfusion_Maui_Inputs_ComboBoxSearchInfo_) method of IComboBoxSearchBehavior interface to calculate the highlight index depending on the filtered items list and text entered in the ComboBox control that needs to be highlighted in drop-down. The `GetHighlightIndex` method contains the following arguments:

* [source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) - The owner of the search behavior, which holds information about ItemsSource, Items properties, and so on.
* [searchInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxSearchInfo.html) - Contains details about the filtered items list and the text entered in ComboBox control. You may compute the index that has to be highlighted in the drop-down list using these details.

The following example demonstrates how to highlight the first item that fully matches the typed length entered in the ComboBox control.

{% tabs %}
{% highlight C# %}

/// <summary>
/// Represents a custom searching behavior for `ComboBox` control. 
/// </summary>
public class StringLengthSearchingBehavior : IComboBoxSearchBehavior
{
    private int charLength;

    /// <summary>
    /// Return the highlight index that fully matches the typed length entered in the ComboBox control.
    /// </summary>
    public int GetHighlightIndex(SfComboBox source, ComboBoxSearchInfo searchInfo)
    {
        if (int.TryParse(searchInfo.Text, out this.charLength)) 
        {
           var fullMatch = searchInfo.FilteredItems.OfType<SocialMedia>().FirstOrDefault(i => i.Name.Length == charLength); 
           if (fullMatch != null)
           {
              return searchInfo.FilteredItems.IndexOf(fullMatch); 
           }
        }
       
        return -1;
    }
}

{% endhighlight %}
{% endtabs %}

**Step3:** Apply custom searching to the ComboBox control by using the `SearchBehavior` property. 

{% tabs %}
{% highlight XAML %}

<editors:SfComboBox IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
        <editors:SfComboBox.SearchBehavior>
            <local:StringLengthSearchingBehavior/>
        </editors:SfComboBox.SearchBehavior>
</editors:SfComboBox>

{% endhighlight %}
{% endtabs %}

For e.g. After typing `9` in selection box, the first item that fully matches the typed length will be highlighted.

![.NET MAUI ComboBox highlight the first item that fully matches the typed length](Images/Searching/CustomSearching.png)