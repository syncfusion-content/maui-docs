Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Syncfusion.UI.Xaml.Chat

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    Public Class __VIEW_MODEL_NAME__
        Implements INotifyPropertyChanged

        Private _showTypingIndicator As Boolean

        Public Sub New()
            CurrentUser = New Author With {
                .Name = "John"
            }

            Assistant = New Author With {
                .Name = "Bot"
            }

            TypingIndicator = New TypingIndicator With {
                .Author = Assistant,
                .Text = "Bot is typing..."
            }

            Chats = New ObservableCollection(Of IMessage)()

            GenerateMessagesAsync()
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        Public ReadOnly Property CurrentUser As Author

        Public ReadOnly Property Assistant As Author

        Public ReadOnly Property Chats As ObservableCollection(Of IMessage)

        Public ReadOnly Property TypingIndicator As TypingIndicator

        Public Property ShowTypingIndicator As Boolean
            Get
                Return _showTypingIndicator
            End Get
            Private Set(value As Boolean)
                If _showTypingIndicator <> value Then
                    _showTypingIndicator = value
                    OnPropertyChanged(NameOf(ShowTypingIndicator))
                End If
            End Set
        End Property

        Private Async Sub GenerateMessagesAsync()
            Chats.Add(New TextMessage With {
                .Author = CurrentUser,
                .DateTime = DateTime.Now,
                .Text = "What is WPF?"
            })

            ShowTypingIndicator = True

            Try
                Await Task.Delay(1000)

                Chats.Add(New TextMessage With {
                    .Author = Assistant,
                    .DateTime = DateTime.Now,
                    .Text = "WPF is a .NET user interface framework for building Windows desktop applications with XAML, data binding, styles, templates, and reusable controls."
                })
            Finally
                ShowTypingIndicator = False
            End Try
        End Sub

        Private Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(
                Me,
                New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace