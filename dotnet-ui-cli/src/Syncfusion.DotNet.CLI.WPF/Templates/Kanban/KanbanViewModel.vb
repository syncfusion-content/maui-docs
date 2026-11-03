Imports Syncfusion.UI.Xaml.Kanban

Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.Kanban
    Public Class KanbanViewModel
        Implements INotifyPropertyChanged
        Public Property Tasks As ObservableCollection(Of KanbanModel)

        Public Sub New()
            Tasks = New ObservableCollection(Of KanbanModel)()
            Tasks.Add(New KanbanModel() With {
    .Title = "Universal App",
    .ID = "27654",
    .Description = "Incorporate feedback into functional specifications",
    .Category = "Open",
    .ColorKey = "Low",
    .Tags = New String() {"Deployment"},
    .ImageURL = New Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
})

            Tasks.Add(New KanbanModel() With {
    .Title = "Universal App",
    .ID = "29477",
    .Description = "Design functional specifications",
    .Category = "In Progress",
    .ColorKey = "Normal",
    .Tags = New String() {"Design"},
    .ImageURL = New Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
})

            Tasks.Add(New KanbanModel() With {
    .Title = "Universal App",
    .ID = "25678",
    .Description = "Review preliminary software specifications",
    .Category = "Done",
    .ColorKey = "Low",
    .Tags = New String() {"Analysis"},
    .ImageURL = New Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
})

            Tasks.Add(New KanbanModel() With {
    .Title = "Universal App",
    .ID = "6593",
    .Description = "Draft preliminary software specifications",
    .Category = "Review",
    .ColorKey = "High",
    .Tags = New String() {"Analysis"},
    .ImageURL = New Uri("/__ROOT_NAMESPACE__;component/Kanban/Resources/Employee.png", UriKind.RelativeOrAbsolute)
})
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub [Set](Of T)(ByRef storage As T, value As T,
<CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
