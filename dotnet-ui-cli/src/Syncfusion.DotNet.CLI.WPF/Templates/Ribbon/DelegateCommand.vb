
Imports System
Imports System.Windows.Input

Namespace __ROOT_NAMESPACE__.Ribbon
    Public NotInheritable Class DelegateCommand(Of T)
        Implements ICommand
        Private ReadOnly executeField As Action(Of T)
        Public Sub New(execute As Action(Of T))
            executeField = execute
        End Sub
        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function
        Public Sub Execute(parameter As Object) Implements ICommand.Execute
            executeField(parameter)
        End Sub
        Public Custom Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
            AddHandler(value As EventHandler)
            End AddHandler
            RemoveHandler(value As EventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)
            End RaiseEvent
        End Event
    End Class
End Namespace
