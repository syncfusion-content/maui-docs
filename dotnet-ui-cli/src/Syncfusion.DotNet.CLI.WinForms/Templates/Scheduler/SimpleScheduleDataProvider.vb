#Disable Warning BC40000
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Serialization.Formatters.Binary
Imports Syncfusion.Schedule

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    ''' <summary>
    ''' Minimal in-memory data provider for the Syncfusion WinForms Scheduler.
    ''' Stores appointments in a SimpleScheduleAppointmentList and
    ''' implements just enough of ScheduleDataProvider for the
    ''' ScheduleControl to display and edit items.
    ''' </summary>
    Public Class SimpleScheduleDataProvider
        Inherits ScheduleDataProvider

        Public Sub New()
            MyBase.New()
        End Sub

        Private masterListField As SimpleScheduleAppointmentList = New SimpleScheduleAppointmentList()

        ''' <summary>
        ''' Backing store of appointments. The ScheduleControl reads from here.
        ''' </summary>
        Public Property MasterList As SimpleScheduleAppointmentList
            Get
                Return masterListField
            End Get
            Set(value As SimpleScheduleAppointmentList)
                masterListField = value
            End Set
        End Property

        #Region "ScheduleDataProvider overrides"

        Public Overrides Function GetSchedule(startDate As DateTime, endDate As DateTime) As IScheduleAppointmentList
            Dim list As ScheduleAppointmentList = New ScheduleAppointmentList()
            Dim start As DateTime = startDate.Date
            Dim [end] As DateTime = endDate.Date

            For Each item As ScheduleAppointment In Me.MasterList
                If ((item.StartTime.Date >= start AndAlso item.StartTime.Date <= [end]) OrElse (item.EndTime.Date > start AndAlso item.EndTime.Date <= [end])) Then
                    list.Add(item)
                End If
            Next

            Return list
        End Function

        Public Overrides Function GetScheduleForDay(day As DateTime) As IScheduleAppointmentList
            Dim list As ScheduleAppointmentList = New ScheduleAppointmentList()
            day = day.Date

            For Each item As ScheduleAppointment In Me.MasterList
                If item.StartTime.Date = day OrElse item.EndTime.Date = day Then
                    list.Add(item)
                End If
            Next

            Return list
        End Function

        Public Overrides Sub CommitChanges()
            Me.IsDirty = False
        End Sub

        Public Overrides Property IsDirty As Boolean
            Get
                Return MyBase.IsDirty
            End Get
            Set(value As Boolean)
                MyBase.IsDirty = value
            End Set
        End Property

        Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
            Return New SimpleScheduleAppointment()
        End Function

        Public Overrides Sub AddItem(item As IScheduleAppointment)
            Me.MasterList.Add(item)
        End Sub

        Public Overrides Sub RemoveItem(item As IScheduleAppointment)
            Me.MasterList.Remove(item)
        End Sub

        #End Region
    End Class

    ''' <summary>
    ''' Minimal appointment list. Uses the base ScheduleAppointmentList
    ''' collection; only customises the appointment factory.
    ''' </summary>
    <Serializable>
    Public Class SimpleScheduleAppointmentList
        Inherits ScheduleAppointmentList

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
            Return New SimpleScheduleAppointment()
        End Function
    End Class

    ''' <summary>
    ''' Minimal concrete appointment. Inherits all fields/properties from
    ''' ScheduleAppointment; no extra properties required for the sample.
    ''' </summary>
    <Serializable>
    Public Class SimpleScheduleAppointment
        Inherits ScheduleAppointment

        Public Sub New()
            MyBase.New()
        End Sub
    End Class
End Namespace
