#nullable disable

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Syncfusion.UI.Xaml.Chat;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__ : INotifyPropertyChanged
    {
        private bool _showTypingIndicator;

        public __VIEW_MODEL_NAME__()
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

            Chats = new ObservableCollection<IMessage>();

            GenerateMessagesAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Author CurrentUser { get; }

        public Author Assistant { get; }

        public ObservableCollection<IMessage> Chats { get; }

        public TypingIndicator TypingIndicator { get; }

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
                Text = "What is WPF?"
            });

            ShowTypingIndicator = true;

            try
            {
                await Task.Delay(1000);

                Chats.Add(new TextMessage
                {
                    Author = Assistant,
                    DateTime = DateTime.Now,
                    Text = "WPF is a .NET user interface framework for building Windows desktop applications with XAML, data binding, styles, templates, and reusable controls."
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