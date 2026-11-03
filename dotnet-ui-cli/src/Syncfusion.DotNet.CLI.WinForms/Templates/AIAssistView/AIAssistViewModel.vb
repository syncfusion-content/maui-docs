#Disable Warning BC40000
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Syncfusion.WinForms.AIAssistView

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    ''' <summary>
    ''' ViewModel for the AI AssistView sample.
    ''' Holds the chat messages, suggestions and simulated response logic
    ''' so the page stays UI-only.
    ''' </summary>
    Public Class __VIEW_MODEL_NAME__
        Implements INotifyPropertyChanged

        Private ReadOnly bot As New Author With {.Name = "Bot"}

        Private _chats As ObservableCollection(Of Object)

        Private _suggestions As ObservableCollection(Of String)

        ''' <summary>
        ''' The conversation displayed by the <c>SfAIAssistView</c>.
        ''' </summary>
        Public Property Chats As ObservableCollection(Of Object)
            Get
                Return _chats
            End Get
            Set(value As ObservableCollection(Of Object))
                _chats = value
                OnPropertyChanged(NameOf(Chats))
            End Set
        End Property

        ''' <summary>
        ''' The quick-reply suggestions displayed above the input editor.
        ''' </summary>
        Public Property Suggestions As ObservableCollection(Of String)
            Get
                Return _suggestions
            End Get
            Set(value As ObservableCollection(Of String))
                _suggestions = value
                OnPropertyChanged(NameOf(Suggestions))
            End Set
        End Property

        ''' <summary>
        ''' The author representing the local user.
        ''' </summary>
        Public ReadOnly Property CurrentUser As New Author With {.Name = "User"}

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Sub New()
            Chats = New ObservableCollection(Of Object)()
            Suggestions = New ObservableCollection(Of String) From {
                "What is Windows Forms?",
                "What are the advantages of Windows Forms?"
            }

            ' Seed the conversation with a greeting from the bot.
            Chats.Add(New TextMessage With
            {
                .Author = bot,
                .Text = "Hello! I am your AI assistant. Select a suggestion or type a question to get started."
            })
        End Sub

        ''' <summary>
        ''' Adds the user prompt to the conversation and replies with a
        ''' simulated response after a short delay.
        ''' </summary>
        Public Async Function ProcessPromptAsync(prompt As String) As Task
            If String.IsNullOrWhiteSpace(prompt) Then
                Return
            End If

            Chats.Add(New TextMessage With {.Author = CurrentUser, .Text = prompt})

            ' Simulates response generation.
            Await Task.Delay(1000)

            Chats.Add(New TextMessage With
            {
                .Author = bot,
                .Text = GetResponse(prompt.Trim())
            })
        End Function

        Private Shared Function GetResponse(prompt As String) As String
            Dim responses As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
                {"What is Windows Forms?", "Windows Forms, also known as WinForms, is a graphical user interface framework developed by Microsoft for building Windows desktop applications."},
                {"What are the advantages of Windows Forms?", "Windows Forms provides a simple development model, a rich collection of desktop controls, Visual Studio designer support, and easy integration with the .NET platform."}
            }

            Dim response As String = Nothing
            Return If(responses.TryGetValue(prompt, response), response, "This is a sample assistant that answers the suggested questions. Please select one of the suggested questions.")
        End Function

        Private Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
