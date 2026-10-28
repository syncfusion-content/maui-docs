#nullable disable
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.AIAssistView;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        private readonly __VIEW_MODEL_NAME__ viewModel = new __VIEW_MODEL_NAME__();

        public __VIEW_NAME__()
        {
            var aiAssistView = new SfAIAssistView
            {
                AccessibleName = "AI Assist",
                Dock = DockStyle.Fill,
                Name = "sfAIAssistView",
                User = viewModel.CurrentUser,
            };

            aiAssistView.DataBindings.Add("Messages", viewModel, nameof(viewModel.Chats), true, DataSourceUpdateMode.OnPropertyChanged);
            aiAssistView.DataBindings.Add("Suggestions", viewModel, nameof(viewModel.Suggestions), true, DataSourceUpdateMode.OnPropertyChanged);

            // Handles text entered through the input editor.
            aiAssistView.PromptRequest += OnPromptRequest;

            // Handles suggestion selection.
            aiAssistView.SuggestionSelected += OnSuggestionSelected;

            // Show default copy / like / dislike toolbar on bot responses.
            aiAssistView.IsResponseToolBarVisible = true;
            aiAssistView.ResponseToolBarItems = new ObservableCollection<ResponseToolBarItem>
            {
                new ResponseToolBarItem { ItemType = ResponseToolBarItemType.Copy, Name = "Copy" },
                new ResponseToolBarItem { ItemType = ResponseToolBarItemType.Like, Name = "Like" },
                new ResponseToolBarItem { ItemType = ResponseToolBarItemType.Dislike, Name = "Dislike" },
            };

            ConfigureBanner(aiAssistView);

            Controls.Add(aiAssistView);
        }

        /// <summary>
        /// Configures the banner with a title, subtitle, and custom style.
        /// </summary>
        private static void ConfigureBanner(SfAIAssistView aiAssistView)
        {
            var bannerStyle = new BannerStyle
            {
                TitleFont = new Font("Segoe UI", 14F, FontStyle.Bold),
                SubTitleFont = new Font("Segoe UI", 12F, FontStyle.Italic),
                ImageSize = AvatarSize.ExtraLarge,
                TitleColor = Color.MidnightBlue,
            };

            aiAssistView.SetBannerView("AI Assist view", "Your best AI Companion", null, bannerStyle);
        }

        /// <summary>
        /// Handles manually entered prompt messages.
        /// </summary>
        private async void OnPromptRequest(object sender, PromptRequestEventArgs e)
        {
            if (e.Message is not TextMessage textMessage || string.IsNullOrWhiteSpace(textMessage.Text))
            {
                return;
            }

            // The assistant view should not add the message automatically;
            // the view model owns the conversation.
            e.Handled = true;

            await viewModel.ProcessPromptAsync(textMessage.Text);
        }

        /// <summary>
        /// Handles suggestion selection.
        /// </summary>
        private async void OnSuggestionSelected(object sender, SuggestionSelectedEventArgs e)
        {
            var suggestionText = e.Item?.ToString();
            if (string.IsNullOrWhiteSpace(suggestionText))
            {
                return;
            }

            await viewModel.ProcessPromptAsync(suggestionText);
        }
    }
}
