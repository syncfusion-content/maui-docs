
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.Chart
    Public Class ChartViewModel
        Implements INotifyPropertyChanged
        Public ReadOnly Property Data As ObservableCollection(Of ChartModel) = New ObservableCollection(Of ChartModel)()

        Public Sub New()
            Data.Add(New ChartModel With {
                .Name = "Product A",
                .[Imports] = 2.2,
                .Exports = 1.2
            })
            Data.Add(New ChartModel With {
                .Name = "Product B",
                .[Imports] = 2.4,
                .Exports = 1.3
            })
            Data.Add(New ChartModel With {
                .Name = "Product C",
                .[Imports] = 3,
                .Exports = 1.5
            })
            Data.Add(New ChartModel With {
                .Name = "Product D",
                .[Imports] = 3.1,
                .Exports = 2.2
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
