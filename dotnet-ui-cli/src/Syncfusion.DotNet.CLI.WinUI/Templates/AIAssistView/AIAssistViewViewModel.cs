#nullable disable

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Syncfusion.UI.Xaml.Chat;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class AIAssistViewViewModel : INotifyPropertyChanged
    {
        private bool _showTypingIndicator;

        public event PropertyChangedEventHandler PropertyChanged;

        public Author CurrentUser { get; }

        public Author Assistant { get; }

        public ObservableCollection<object> Chats { get; }

        public TypingIndicator TypingIndicator { get; }

        public AIAssistViewViewModel()
        {
            CurrentUser = new Author
            {
                Name = "John"
            };

            Assistant = new Author
            {
                Name = "Bot"
            };

            TypingIndicator = new TypingIndicator
            {
                Author = Assistant,
                Text = "Bot is typing..."
            };

            Chats = new ObservableCollection<object>();

            GenerateMessagesAsync();
        }

        public bool ShowTypingIndicator
        {
            get => _showTypingIndicator;
            private set
            {
                if (_showTypingIndicator != value)
                {
                    _showTypingIndicator = value;
                    OnPropertyChanged(nameof(ShowTypingIndicator));
                }
            }
        }

        private async void GenerateMessagesAsync()
        {
            Chats.Add(new TextMessage
            {
                Author = CurrentUser,
                DateTime = DateTime.Now,
                Text = "What is WinUI?"
            });

            ShowTypingIndicator = true;

            try
            {
                await Task.Delay(1000);

                Chats.Add(new TextMessage
                {
                    Author = Assistant,
                    DateTime = DateTime.Now,
                    Text = "WinUI is a user interface framework for building modern Windows desktop applications with XAML, data binding, styles, templates, and reusable controls."
                });
            }
            finally
            {
                ShowTypingIndicator = false;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
