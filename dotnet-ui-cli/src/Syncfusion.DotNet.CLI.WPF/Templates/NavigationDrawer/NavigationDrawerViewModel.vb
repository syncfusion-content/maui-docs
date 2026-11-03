
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.NavigationDrawer
    Public Class NavigationDrawerViewModel
        Inherits NotificationObject
        Implements INotifyPropertyChanged
        Public ReadOnly Property Contents As ObjectModel.ObservableCollection(Of NavigationDrawerModel) = New ObjectModel.ObservableCollection(Of NavigationDrawerModel) From {
New NavigationDrawerModel With {
.Name = "Inbox"
},
New NavigationDrawerModel With {
.Name = "Sent Mail"
},
New NavigationDrawerModel With {
.Name = "Starred"
},
New NavigationDrawerModel With {
.Name = "Drafts"
}
}

        Public Sub New()
        End Sub


        Protected Sub [Set](Of T)(ByRef storage As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
            RaisePropertyChanged(propertyName)
        End Sub
    End Class
End Namespace
