Imports Syncfusion.Windows.Controls.Gantt
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    Public Class __VIEW_MODEL_NAME__
        Implements INotifyPropertyChanged

        Public Property TaskCollection As ObservableCollection(Of TaskDetails)

        Public Sub New()
            TaskCollection = New ObservableCollection(Of TaskDetails)()
            GetData()
        End Sub

        Private Sub GetData()
            Dim taskDetails = New ObservableCollection(Of TaskDetails)()

            taskDetails.Add(New TaskDetails With {.TaskId = 1, .TaskName = "Scope", .StartDate = New DateTime(2011, 7, 3), .FinishDate = New DateTime(2011, 7, 14), .Progress = 40.0})
            taskDetails(0).Child.Add(New TaskDetails With {.TaskId = 2, .TaskName = "Determine project office scope", .StartDate = New DateTime(2011, 7, 3), .FinishDate = New DateTime(2011, 7, 5), .Progress = 20.0})
            taskDetails(0).Child.Add(New TaskDetails With {.TaskId = 3, .TaskName = "Justify Project Office via business model", .StartDate = New DateTime(2011, 7, 3), .FinishDate = New DateTime(2011, 7, 7), .Progress = 20.0})
            taskDetails(0).Child.Add(New TaskDetails With {.TaskId = 4, .TaskName = "Secure executive sponsorship", .StartDate = New DateTime(2011, 7, 3), .FinishDate = New DateTime(2011, 7, 14), .Progress = 20.0})
            taskDetails(0).Child.Add(New TaskDetails With {.TaskId = 5, .TaskName = "Secure complete", .StartDate = New DateTime(2011, 7, 14), .FinishDate = New DateTime(2011, 7, 14), .Progress = 20.0})

            taskDetails.Add(New TaskDetails With {.TaskId = 6, .TaskName = "Risk Assessment", .StartDate = New DateTime(2011, 7, 8), .FinishDate = New DateTime(2011, 7, 24), .Progress = 30.0})
            taskDetails(1).Child.Add(New TaskDetails With {.TaskId = 7, .TaskName = "Perform risk assessment", .StartDate = New DateTime(2011, 7, 8), .FinishDate = New DateTime(2011, 7, 21), .Progress = 20.0})
            taskDetails(1).Child.Add(New TaskDetails With {.TaskId = 8, .TaskName = "Evaluate risk assessment", .StartDate = New DateTime(2011, 7, 8), .FinishDate = New DateTime(2011, 7, 23), .Progress = 30.0})
            taskDetails(1).Child.Add(New TaskDetails With {.TaskId = 9, .TaskName = "Prepare contingency plans", .StartDate = New DateTime(2011, 7, 12), .FinishDate = New DateTime(2011, 7, 24), .Progress = 30.0})
            taskDetails(1).Child.Add(New TaskDetails With {.TaskId = 10, .TaskName = "Risk Assessment complete", .StartDate = New DateTime(2011, 7, 15), .FinishDate = New DateTime(2011, 7, 24), .Progress = 30.0})

            taskDetails.Add(New TaskDetails With {.TaskId = 11, .TaskName = "Monitoring", .StartDate = New DateTime(2011, 7, 13), .FinishDate = New DateTime(2011, 8, 6), .Progress = 40.0})
            taskDetails(2).Child.Add(New TaskDetails With {.TaskId = 12, .TaskName = "Prepare Meeting agenda", .StartDate = New DateTime(2011, 7, 13), .FinishDate = New DateTime(2011, 7, 26), .Progress = 30.0})
            taskDetails(2).Child.Add(New TaskDetails With {.TaskId = 13, .TaskName = "Conduct review meeting", .StartDate = New DateTime(2011, 7, 13), .FinishDate = New DateTime(2011, 7, 30), .Progress = 30.0})
            taskDetails(2).Child.Add(New TaskDetails With {.TaskId = 14, .TaskName = "Migrate critical issues", .StartDate = New DateTime(2011, 7, 18), .FinishDate = New DateTime(2011, 8, 2), .Progress = 30.0})
            taskDetails(2).Child.Add(New TaskDetails With {.TaskId = 15, .TaskName = "Establish change mgmt Control", .StartDate = New DateTime(2011, 8, 3), .FinishDate = New DateTime(2011, 8, 6), .Progress = 30.0})
            taskDetails(2).Child.Add(New TaskDetails With {.TaskId = 16, .TaskName = "Monitoring Complete", .StartDate = New DateTime(2011, 8, 6), .FinishDate = New DateTime(2011, 8, 6), .Progress = 30.0})

            taskDetails.Add(New TaskDetails With {.TaskId = 17, .TaskName = "Post Implementation", .StartDate = New DateTime(2011, 8, 7), .FinishDate = New DateTime(2011, 8, 19), .Progress = 40.0})
            taskDetails(3).Child.Add(New TaskDetails With {.TaskId = 18, .TaskName = "Obtain User feedback", .StartDate = New DateTime(2011, 8, 7), .FinishDate = New DateTime(2011, 8, 10), .Progress = 30.0})
            taskDetails(3).Child.Add(New TaskDetails With {.TaskId = 19, .TaskName = "Evaluate lessons learned", .StartDate = New DateTime(2011, 8, 7), .FinishDate = New DateTime(2011, 8, 17), .Progress = 30.0})
            taskDetails(3).Child.Add(New TaskDetails With {.TaskId = 20, .TaskName = "Modify items as necessary", .StartDate = New DateTime(2011, 8, 7), .FinishDate = New DateTime(2011, 8, 19), .Progress = 30.0})
            taskDetails(3).Child.Add(New TaskDetails With {.TaskId = 21, .TaskName = "Post Implementation complete", .StartDate = New DateTime(2011, 8, 19), .FinishDate = New DateTime(2011, 8, 19), .Progress = 30.0})

            TaskCollection = taskDetails
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub SetProperty(Of T)(ByRef storage As T, value As T, Optional propertyName As String = Nothing)
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
