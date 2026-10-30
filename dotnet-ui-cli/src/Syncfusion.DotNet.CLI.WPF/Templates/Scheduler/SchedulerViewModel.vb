
Imports System
Imports System.Windows.Media
Imports Syncfusion.UI.Xaml.Scheduler
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace __ROOT_NAMESPACE__.Scheduler
    Public Class SchedulerViewModel
        Inherits NotificationObject
        Implements INotifyPropertyChanged
        Private resourcesField As ObservableCollection(Of Object)

        Public Property Resources As ObservableCollection(Of Object)
            Get
                Return resourcesField
            End Get
            Set(value As ObservableCollection(Of Object))
                resourcesField = value
                RaisePropertyChanged("Resources")
            End Set
        End Property


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

        Public Sub New()
            MinDate = Date.Now.Date.AddMonths(-3)
            MaxDate = Date.Now.AddMonths(3)
            DisplayDate = Date.Now.Date.AddHours(9)

            Resources = New ObservableCollection(Of Object)() From {
New SchedulerResource() With {
        .Name = "Sophia",
        .Foreground = New SolidColorBrush(ColorConverter.ConvertFromString("#FFFFFF")),
        .Background = New SolidColorBrush(ColorConverter.ConvertFromString("#9d65c9")),
        .Id = "1000"
    },
New SchedulerResource() With {
        .Name = "Zoey Addison",
        .Foreground = New SolidColorBrush(ColorConverter.ConvertFromString("#FFFFFF")),
        .Background = New SolidColorBrush(ColorConverter.ConvertFromString("#f08a5d")),
        .Id = "1001"
    },
New SchedulerResource() With {
        .Name = "James William",
        .Foreground = New SolidColorBrush(ColorConverter.ConvertFromString("#FFFFFF")),
        .Background = New SolidColorBrush(ColorConverter.ConvertFromString("#679b9b")),
        .Id = "1002"
    }
}

            'Creating new event
            Events = New ScheduleAppointmentCollection()

            'Creating new event
            Events.Add(New ScheduleAppointment() With {
    .StartTime = Date.Now,
    .EndTime = Date.Now.AddHours(1),
    .AppointmentBackground = New SolidColorBrush(ColorConverter.ConvertFromString("#FF339933")),
    .Subject = "Conference",
                    .Reminders = New ObservableCollection(Of SchedulerReminder) From {
         New SchedulerReminder With {
            .ReminderTimeInterval = New TimeSpan(0)
        }
    },
    .ResourceIdCollection = New ObservableCollection(Of Object) From {
        TryCast(Resources(1), SchedulerResource).Id
    }
})
        End Sub

        Private eventsField As ScheduleAppointmentCollection


        Public Property MinDate As Date
        Public Property MaxDate As Date
        Public Property DisplayDate As Date
        Public Property Events As ScheduleAppointmentCollection
            Get
                Return eventsField
            End Get
            Set(value As ScheduleAppointmentCollection)
                eventsField = value
                RaisePropertyChanged("Events")
            End Set
        End Property
    End Class
End Namespace
