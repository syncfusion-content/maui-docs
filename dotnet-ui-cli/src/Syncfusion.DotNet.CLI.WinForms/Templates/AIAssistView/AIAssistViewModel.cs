#nullable disable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Syncfusion.WinForms.AIAssistView;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    /// <summary>
    /// ViewModel for the AI AssistView sample.
    /// Holds the chat messages, suggestions and simulated response logic
    /// so the page stays UI-only.
    /// </summary>
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        private readonly Author bot = new Author { Name = "Bot" };

        private ObservableCollection<object> chats;

        private ObservableCollection<string> suggestions;

        /// <summary>
        /// The conversation displayed by the <c>SfAIAssistView</c>.
        /// </summary>
        public ObservableCollection<object> Chats
        {
            get => chats;
            set
            {
                chats = value;
                OnPropertyChanged(nameof(Chats));
            }
        }

        /// <summary>
        /// The quick-reply suggestions displayed above the input editor.
        /// </summary>
        public ObservableCollection<string> Suggestions
        {
            get => suggestions;
            set
            {
                suggestions = value;
                OnPropertyChanged(nameof(Suggestions));
            }
        }

        /// <summary>
        /// The author representing the local user.
        /// </summary>
        public Author CurrentUser { get; } = new Author { Name = "User" };

        public event PropertyChangedEventHandler PropertyChanged;

        public __VIEW_MODEL_NAME__()
        {
            Chats = new ObservableCollection<object>();
            Suggestions = new ObservableCollection<string>
            {
                "What is Windows Forms?",
                "What are the advantages of Windows Forms?",
            };

            // Seed the conversation with a greeting from the bot.
            Chats.Add(new TextMessage
            {
                Author = bot,
                Text = "Hello! I am your AI assistant. Select a suggestion or type a question to get started.",
            });
        }

        /// <summary>
        /// Adds the user prompt to the conversation and replies with a
        /// simulated response after a short delay.
        /// </summary>
        public async Task ProcessPromptAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                return;
            }

            Chats.Add(new TextMessage { Author = CurrentUser, Text = prompt });

            // Simulates response generation.
            await Task.Delay(1000);

            Chats.Add(new TextMessage
            {
                Author = bot,
                Text = GetResponse(prompt.Trim()),
            });
        }

        private static string GetResponse(string prompt)
        {
            var responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["What is Windows Forms?"] =
                    "Windows Forms, also known as WinForms, is a graphical user interface framework " +
                    "developed by Microsoft for building Windows desktop applications.",
                ["What are the advantages of Windows Forms?"] =
                    "Windows Forms provides a simple development model, a rich collection of desktop controls, " +
                    "Visual Studio designer support, and easy integration with the .NET platform.",
            };

            return responses.TryGetValue(prompt, out var response)
                ? response
                : "This is a sample assistant that answers the suggested questions. Please select one of the suggested questions.";
        }

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
