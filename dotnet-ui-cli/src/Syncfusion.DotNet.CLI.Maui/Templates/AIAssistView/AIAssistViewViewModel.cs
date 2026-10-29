using System.Collections.ObjectModel;
using System.Windows.Input;
using Syncfusion.Maui.AIAssistView;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<IAssistItem> AssistItems { get; set; } =
        [
            new AssistItem { Text = "What can I try in this sample?", IsRequested = true },
            new AssistItem { Text = "Enter a request below to explore the conversation interface. Responses are local sample text; connect your AI service to provide real answers.", IsRequested = false }
        ];

        public ICommand RequestCommand { get; }

        public __VIEW_MODEL_NAME__()
        {
            RequestCommand = new Command<RequestEventArgs>(OnRequest);
        }

        private async void OnRequest(RequestEventArgs request)
        {
            await Task.Delay(2500);
            AssistItems.Add(new AssistItem
            {
                Text = "This is a local demonstration response. Connect your AI service in the view model's request handler to respond to this request.",
                IsRequested = false
            });
        }
    }
}
