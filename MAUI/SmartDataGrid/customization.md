---
layout: post
title: Customization in MAUI SmartDataGrid control | Syncfusion®
description: Learn here all about how to customize behavior and features of Syncfusion® .NET MAUI SmartDataGrid (SfSmartDataGrid) control and more.
platform: MAUI
control: SfSmartDataGrid
documentation: UG
keywords : maui datagrid, customization, assistview, prompts, smart actions
---

# Customization in MAUI SmartDataGrid (SfSmartDataGrid)

The [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) provides options to customize its behavior and appearance, including predefined suggestions, initial prompts, enabling or disabling smart actions, and programmatic control of the AssistView.

## Suggestion

The [SuggestedPrompts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_SuggestedPrompts) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) is used to provide a predefined list of suggestions that appear in the AssistView. These suggestions help users quickly select common actions without typing commands manually.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.AssistViewSettings>
        <syncfusion:DataGridAssistViewSettings SuggestedPrompts="{Binding Suggestions}"/>
    </syncfusion:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
public class OrderInfoRepository
{
    public ObservableCollection<ISuggestion> Suggestions { get; set; } = new ObservableCollection<ISuggestion>
    {
        new AssistSuggestion() {Text = "Which orders have a payment status of Not Paid?"},
        new AssistSuggestion() {Text ="What are the top 10 orders with the highest freight cost?"},
        new AssistSuggestion() {Text = "Which customers have placed the most orders?"},
        new AssistSuggestion() {Text = "What are the orders shipped to Brazil?"},
        new AssistSuggestion() {Text = "What is the total quantity of products ordered across all orders?"},
    };
}
{% endhighlight %}
{% endtabs %}

<img alt="maui-smart-datagrid-suggested-prompts" src="Images\Customization\maui-smart-datagrid-suggested-prompts.png" width="600"/>

## Prompt

The [Prompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_Prompt) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) defines an initial prompt that is automatically executed when the AssistView opens for the first time. 

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.AssistViewSettings>
        <syncfusion:DataGridAssistViewSettings Prompt="Sort by OrderDate ascending" />
    </syncfusion:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.Prompt = "Sort by OrderDate ascending";
{% endhighlight %}
{% endtabs %}

## EnableSmartActions

The [EnableSmartActions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_EnableSmartActions) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) determines whether actions are applied to the DataGrid. By default, this property is set to true, allowing operations such as sorting, grouping, filtering, and highlighting to be executed automatically. Setting it to false restricts these actions from being applied to the grid.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.AssistViewSettings>
        <syncfusion:DataGridAssistViewSettings EnableSmartActions="True" />
    </syncfusion:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.EnableSmartActions = true;
{% endhighlight %}
{% endtabs %}

## Show AssistView Programmatically

The [ShowAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_ShowAssistView_Microsoft_Maui_Controls_View_) and [CloseAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_CloseAssistView) methods in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) are used to display or hide the AssistView popup programmatically. By default, calling ShowAssistView() opens the AssistView popup relative to the default assist button. The ShowAssistView method also provides an optional parameter of type View; when a view is passed, the popup opens relative to the specified view instead of the default button.

{% tabs %}
{% highlight c# %}
// Show AssistView popup relative to the default assist button
SmartGrid.ShowAssistView();

// Show AssistView popup relative to a specific view (e.g., a button)
SmartGrid.ShowAssistView(<Relative View>);

// Close the AssistView popup
SmartGrid.CloseAssistView();

{% endhighlight %}
{% endtabs %}

## Apply Smart Actions Programmatically

The [GetResponseAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_GetResponseAsync_System_String_) method in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) is used to fetch a response programmatically without opening the AssistView popup. By passing a prompt to this method, the required action is applied directly to the DataGrid. 

{% tabs %}
{% highlight c# %}
SmartGrid.GetResponseAsync("Sort the OrderID by Descending");
{% endhighlight %}
{% endtabs %}


## Events

### AssistViewRequest

The [SfSmartDataGrid.AssistViewRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_AssistViewRequest) event is triggered whenever a user request is sent. This event provides the Prompt as an argument through [AssistViewRequestEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistViewRequestEventArgs.html) and includes a `Cancel` property. Setting Cancel to true prevents the request from being processed.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}" 
                       AssistViewRequest="OnAssistRequest">
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistRequest(object sender, AssistViewRequestEventArgs e)
{
    var prompt = e.Prompt;
    e.Cancel = True;
}
{% endhighlight %}
{% endtabs %}

### AssistViewOpening

The [DataGridAssistViewSettings.AssistViewOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_AssistViewOpening) event is triggered whenever the AssistView popup is about to open. This event provides [AssistViewOpeningEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistViewOpeningEventArgs.html), which includes a `Cancel` property. Setting Cancel to true prevents the AssistView popup from opening.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.AssistViewSettings>
        <syncfusion:DataGridAssistViewSettings AssistViewOpening="OnAssistOpening" />
    </syncfusion:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistOpening(object sender, AssistViewOpeningEventArgs e)
{
    e.Cancel = True;
}
{% endhighlight %}
{% endtabs %}

### AssistViewClosing

The [DataGridAssistViewSettings.AssistViewClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_AssistViewClosing) event is triggered whenever the AssistView popup is about to close. This event provides [AssistViewClosingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistViewClosingEventArgs.html), which includes a `Cancel` property. Setting Cancel to true prevents the AssistView popup from closing.

{% tabs %}
{% highlight xaml %}
<smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.AssistViewSettings>
        <syncfusion:DataGridAssistViewSettings AssistViewClosing="OnAssistClosing" />
    </syncfusion:SfSmartDataGrid.AssistViewSettings>
</smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistClosing(object sender, AssistViewClosingEventArgs e)
{
    e.Cancel = True;
}
{% endhighlight %}
{% endtabs %}