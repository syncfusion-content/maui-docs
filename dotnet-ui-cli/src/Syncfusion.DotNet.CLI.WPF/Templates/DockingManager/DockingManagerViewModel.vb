
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.DockingManager
    Public Class DockingManagerViewModel
        Implements INotifyPropertyChanged
        Private useDocumentContainerField As Boolean

        Public Property UseDocumentContainer As Boolean
            Get
                Return useDocumentContainerField
            End Get
            Set(value As Boolean)
                useDocumentContainerField = value
            End Set
        End Property

        Private enableMaximizeButtonField As Boolean

        Public Property EnableMaximizeButton As Boolean
            Get
                Return enableMaximizeButtonField
            End Get
            Set(value As Boolean)
                enableMaximizeButtonField = value
            End Set
        End Property


        Private enableMinimizeButtonField As Boolean

        Public Property EnableMinimizeButton As Boolean
            Get
                Return enableMinimizeButtonField
            End Get
            Set(value As Boolean)
                enableMinimizeButtonField = value
            End Set
        End Property


        Public Sub New()
            UseDocumentContainer = True
            EnableMaximizeButton = True
            EnableMinimizeButton = True
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
