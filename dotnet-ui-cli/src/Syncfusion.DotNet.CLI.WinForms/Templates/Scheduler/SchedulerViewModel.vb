#Disable Warning BC40000
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports Syncfusion.Schedule

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    ''' <summary>
    ''' ViewModel for the Scheduler view.
    ''' Exposes a SimpleScheduleDataProvider that the Form binds to.
    ''' All appointment-creation logic lives here so the Form stays UI-only.
    ''' </summary>
    Public Class __VIEW_MODEL_NAME__
        ''' <summary>
        ''' The data provider consumed by ScheduleControl.DataSource.
        ''' </summary>
        Public Property Provider As SimpleScheduleDataProvider

        Public Sub New()
            Provider = New SimpleScheduleDataProvider()
            SeedSampleAppointments()
        End Sub

        ''' <summary>
        ''' Adds a single meeting to the underlying appointment collection.
        ''' Optional Meeting.ForeColor and Meeting.BackColor
        ''' are applied directly to the ScheduleAppointment.
        ''' </summary>
        Public Sub AddMeeting(meeting As Meeting)
            If meeting Is Nothing Then Return

            Dim appointment = New ScheduleAppointment With {
                .Subject = meeting.Subject,
                .StartTime = meeting.StartTime,
                .EndTime = meeting.EndTime
            }

            ' Apply colors only when explicitly set, so unspecified meetings
            ' keep the control's default theme.
            If meeting.ForeColor.HasValue Then
                appointment.ForeColor = meeting.ForeColor.Value
            End If

            If meeting.BackColor.HasValue Then
                appointment.BackColor = meeting.BackColor.Value
            End If

            Provider.MasterList.Add(appointment)
        End Sub

        Private Sub SeedSampleAppointments()
            Dim now = DateTime.Now
            Dim today9am = New DateTime(now.Year, now.Month, now.Day, 9, 0, 0)

            Dim samples = New List(Of Meeting) From {
                New Meeting With {.Subject = "Team Meeting", .StartTime = now, .EndTime = now.AddHours(1)},
                New Meeting With {
                    .Subject = "Project Review",
                    .StartTime = today9am,
                    .EndTime = today9am.AddHours(2),
                    .ForeColor = Color.Black,
                    .BackColor = Color.LightBlue
                },
                New Meeting With {
                    .Subject = "Lunch with Client",
                    .StartTime = today9am.AddHours(4),
                    .EndTime = today9am.AddHours(5),
                    .BackColor = Color.LightGreen
                },
                New Meeting With {
                    .Subject = "Design Sync",
                    .StartTime = today9am.AddDays(1),
                    .EndTime = today9am.AddDays(1).AddHours(1),
                    .BackColor = Color.SteelBlue,
                    .ForeColor = Color.White
                }
            }

            For Each m In samples
                AddMeeting(m)
            Next
        End Sub
    End Class
End Namespace
