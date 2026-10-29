#Disable Warning BC40000
Imports System
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.WinForms.AIAssistView

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    Public Class __VIEW_NAME__
        Inherits UserControl

        Private ReadOnly viewModel As New __VIEW_MODEL_NAME__()

        Public Sub New()
            Dim aiAssistView As New SfAIAssistView With
            {
                .AccessibleName = "AI Assist",
                .Dock = DockStyle.Fill,
                .Name = "sfAIAssistView",
                .User = viewModel.CurrentUser
            }

            aiAssistView.DataBindings.Add("Messages", viewModel, NameOf(viewModel.Chats), True, DataSourceUpdateMode.OnPropertyChanged)
            aiAssistView.DataBindings.Add("Suggestions", viewModel, NameOf(viewModel.Suggestions), True, DataSourceUpdateMode.OnPropertyChanged)

            ' Handles text entered through the input editor.
            AddHandler aiAssistView.PromptRequest, AddressOf OnPromptRequest

            ' Handles suggestion selection.
            AddHandler aiAssistView.SuggestionSelected, AddressOf OnSuggestionSelected

            ' Show default copy / like / dislike toolbar on bot responses.
            aiAssistView.IsResponseToolBarVisible = True
            aiAssistView.ResponseToolBarItems = New ObservableCollection(Of ResponseToolBarItem) From {
                New ResponseToolBarItem With {.ItemType = ResponseToolBarItemType.Copy, .Name = "Copy"},
                New ResponseToolBarItem With {.ItemType = ResponseToolBarItemType.Like, .Name = "Like"},
                New ResponseToolBarItem With {.ItemType = ResponseToolBarItemType.Dislike, .Name = "Dislike"}
            }

            ConfigureBanner(aiAssistView)

            Controls.Add(aiAssistView)
        End Sub

        ''' <summary>
        ''' Configures the banner with a title, subtitle, and custom style.
        ''' </summary>
        Private Shared Sub ConfigureBanner(aiAssistView As SfAIAssistView)
            Dim bannerStyle = New BannerStyle With
            {
                .TitleFont = New Font("Segoe UI", 14.0F, FontStyle.Bold),
                .SubTitleFont = New Font("Segoe UI", 12.0F, FontStyle.Italic),
                .ImageSize = AvatarSize.ExtraLarge,
                .TitleColor = Color.MidnightBlue
            }

            aiAssistView.SetBannerView("AI Assist view", "Your best AI Companion", Nothing, bannerStyle)
        End Sub

        ''' <summary>
        ''' Handles manually entered prompt messages.
        ''' </summary>
        Private Async Sub OnPromptRequest(sender As Object, e As PromptRequestEventArgs)
            Dim textMessage = TryCast(e.Message, TextMessage)
            If textMessage Is Nothing OrElse String.IsNullOrWhiteSpace(textMessage.Text) Then
                Return
            End If

            ' The assistant view should not add the message automatically;
            ' the view model owns the conversation.
            e.Handled = True

            Await viewModel.ProcessPromptAsync(textMessage.Text)
        End Sub

        ''' <summary>
        ''' Handles suggestion selection.
        ''' </summary>
        Private Async Sub OnSuggestionSelected(sender As Object, e As SuggestionSelectedEventArgs)
            Dim suggestionText = If(e.Item?.ToString(), String.Empty)
            If String.IsNullOrWhiteSpace(suggestionText) Then
                Return
            End If

            Await viewModel.ProcessPromptAsync(suggestionText)
        End Sub
    End Class
End Namespace
