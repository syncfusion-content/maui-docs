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

The [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) provides options to customize its behavior and features, including predefined suggestions, initial prompts, enabling or disabling smart actions, and programmatic control of the AssistView.

## Suggestions

The [SuggestedPrompts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_SuggestedPrompts) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) provides a predefined list of suggestions displayed in the AssistView banner. These quick-access suggestions help users discover common operations without typing commands manually.


{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:SfSmartDataGrid.AssistViewSettings>
            <smart:DataGridAssistViewSettings SuggestedPrompts="{Binding Suggestions}"/>
        </smart:SfSmartDataGrid.AssistViewSettings>
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
public class OrderInfoRepository
{
    public ObservableCollection<ISuggestion> Suggestions { get; set; } = new ObservableCollection<ISuggestion>
    {
        new AssistSuggestion() { Text = "Which orders have a payment status of Not Paid?" },
        new AssistSuggestion() { Text = "What are the top 10 orders with the highest freight cost?" },
        new AssistSuggestion() { Text = "Which customers have placed the most orders?" },
        new AssistSuggestion() { Text = "What are the orders shipped to Brazil?" },
        new AssistSuggestion() { Text = "What is the total quantity of products ordered across all orders?" },
    };
}
{% endhighlight %}
{% endtabs %}

<img alt="maui-smart-datagrid-suggested-prompts" src="Images\Customization\maui-smart-datagrid-suggested-prompts.png" width="600"/>

## Prompt

The [Prompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_Prompt) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) defines an initial command automatically executed when the AssistView opens for the first time. The prompt uses the same syntax as user-entered commands (see [AI-Powered Features](ai-powered-features.md) for supported commands).

> **Note:** The prompt is only executed once on first open. Invalid or unsupported prompts are silently ignored with no error notification.

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:SfSmartDataGrid.AssistViewSettings>
            <smart:DataGridAssistViewSettings Prompt="Sort by OrderDate ascending" />
        </smart:SfSmartDataGrid.AssistViewSettings>
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.Prompt = "Sort by OrderDate ascending";
{% endhighlight %}
{% endtabs %}

## EnableSmartActions

The [EnableSmartActions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_EnableSmartActions) property in [DataGridAssistViewSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html) controls whether AI commands modify the grid. By default, this property is set to `true`, enabling automatic execution of sorting, grouping, filtering, and highlighting operations. Set to `false` to prevent all grid modifications (useful for preview or read-only modes).

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:SfSmartDataGrid.AssistViewSettings>
            <smart:DataGridAssistViewSettings EnableSmartActions="True" />
        </smart:SfSmartDataGrid.AssistViewSettings>
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
SmartGrid.AssistViewSettings.EnableSmartActions = true;
{% endhighlight %}
{% endtabs %}

## Programmatic AssistView Control

Use the [ShowAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_ShowAssistView_Microsoft_Maui_Controls_View_) and [CloseAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_CloseAssistView) methods on the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) instance to display or hide the AssistView popup programmatically. By default, `ShowAssistView()` opens the popup anchored to the default AssistView button. Optionally pass a View object to anchor the popup to a different UI element (e.g., a custom button).

**Return Types:** 
- `ShowAssistView()`: `void`
- `CloseAssistView()`: `void`

{% tabs %}
{% highlight c# %}
// Show AssistView popup anchored to the default assist button
SmartGrid.ShowAssistView();

// Show AssistView popup anchored to a specific view (e.g., a button)
Button customButton = new Button { Text = "Ask AI" };
SmartGrid.ShowAssistView(customButton);

// Close the AssistView popup
SmartGrid.CloseAssistView();

{% endhighlight %}
{% endtabs %}

## Apply Smart Actions Programmatically

The [GetResponseAsync](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_GetResponseAsync_System_String_) method on the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) instance executes AI commands programmatically without displaying the AssistView UI. Pass a prompt string using the same syntax as user-entered commands. This is useful for background processing, API automation, or custom UI integration.

**Method Signature:**
```csharp
public async Task<bool> GetResponseAsync(string prompt)
```

**Return Value:** `Task<bool>` — Returns `true` if the command executed successfully; `false` if invalid or unsupported.

{% tabs %}
{% highlight c# %}
// Execute command asynchronously
bool result = await SmartGrid.GetResponseAsync("Sort the OrderID by Descending");

if (result)
{
    Debug.WriteLine("Command executed successfully");
}
else
{
    Debug.WriteLine("Invalid or unsupported command");
}
{% endhighlight %}
{% endtabs %}


## Events

Events allow you to intercept and customize behavior at specific points in the AssistView lifecycle. All events support cancellation through a `Cancel` property to prevent default actions.

**Event Execution Order:**
1. `AssistViewOpening` — Before popup displays
2. `AssistViewRequest` — When user sends a command
3. `AssistViewClosing` — Before popup closes

### AssistViewOpening

The [DataGridAssistViewSettings.AssistViewOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_AssistViewOpening) event fires before the AssistView popup displays. Use this to validate permissions, initialize state, or cancel the operation by setting `Cancel = true`.

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:SfSmartDataGrid.AssistViewSettings>
            <smart:DataGridAssistViewSettings AssistViewOpening="OnAssistViewOpening" />
        </smart:SfSmartDataGrid.AssistViewSettings>
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistViewOpening(object sender, AssistViewOpeningEventArgs e)
{
    // Example: Prevent opening if user lacks permissions
    if (!CurrentUser.HasAssistViewPermission)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### AssistViewRequest

The [SfSmartDataGrid.AssistViewRequest](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_AssistViewRequest) event fires when a user or code sends a command. The event provides the `Prompt` text and allows cancellation to prevent execution.

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}" 
                           AssistViewRequest="OnAssistViewRequest">
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistViewRequest(object sender, AssistViewRequestEventArgs e)
{
    Debug.WriteLine($"Command executed: {e.Prompt}");
    
    // Example: Block delete operations
    if (e.Prompt.Contains("delete", StringComparison.OrdinalIgnoreCase))
    {
        e.Cancel = true;
        ShowUserMessage("Delete operations are not allowed");
    }
}
{% endhighlight %}
{% endtabs %}

### AssistViewClosing

The [DataGridAssistViewSettings.AssistViewClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.DataGridAssistViewSettings.html#Syncfusion_Maui_SmartComponents_DataGridAssistViewSettings_AssistViewClosing) event fires before the AssistView popup closes. Set `Cancel = true` to keep the popup open.

{% tabs %}
{% highlight xaml %}
    <smart:SfSmartDataGrid ItemsSource="{Binding OrderInfoCollection}">
        <smart:SfSmartDataGrid.AssistViewSettings>
            <smart:DataGridAssistViewSettings AssistViewClosing="OnAssistViewClosing" />
        </smart:SfSmartDataGrid.AssistViewSettings>
    </smart:SfSmartDataGrid>
{% endhighlight %}

{% highlight c# %}
private void OnAssistViewClosing(object sender, AssistViewClosingEventArgs e)
{
    // Example: Confirm before closing if unsaved changes exist
    if (HasUnsavedChanges)
    {
        e.Cancel = true;
        PromptUserToSave();
    }
}
{% endhighlight %}
{% endtabs %}
