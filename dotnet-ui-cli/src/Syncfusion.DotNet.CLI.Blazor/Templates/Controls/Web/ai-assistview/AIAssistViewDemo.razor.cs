using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.InteractiveChat;
using Syncfusion.Blazor.Navigations;

namespace __PAGE_NAMESPACE__;

public partial class AIAssistViewDemo
{
    private SfAIAssistView sfAIAssistView = new SfAIAssistView();


    #pragma warning disable BL0005

    private AssistViewAttachmentSettings attachmentSettings = new AssistViewAttachmentSettings()
    {
        Enable = true,
        SaveUrl = "https://blazor.syncfusion.com/services/production/api/FileUploader/Save",
        RemoveUrl = "https://blazor.syncfusion.com/services/production/api/FileUploader/Remove"
    };

    #pragma warning restore BL0005


    private List<string> suggestions = new List<string>()
    {
        "How do I set daily goals in my work day?",
        "Steps to publish a e-book with marketing strategy"
    };

    private async Task PromptRequest(AssistViewPromptRequestedEventArgs args)
    {
        await Task.Delay(3000);
        var defaultResponse = "For real-time prompt processing, connect the AI AssistView control to your preferred AI service, such as OpenAI or Azure Cognitive Services. Ensure you obtain the necessary API credentials to authenticate and enable seamless integration.";
        args.Response = defaultResponse;
    }

    private void ToolbarItemClicked(AssistViewToolbarItemClickedEventArgs args)
    {
        if (args.Item.IconCss == "e-icons e-refresh")
        {
            sfAIAssistView.Prompts.Clear();
        }
    }
}
