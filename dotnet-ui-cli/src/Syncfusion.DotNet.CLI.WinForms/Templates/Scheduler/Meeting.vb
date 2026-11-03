#Disable Warning BC40000
Imports System
Imports System.Drawing

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    ''' <summary>
    ''' Plain data model representing a meeting.
    ''' Kept as a simple POCO so the Form (View) has no business logic.
    ''' </summary>
    Public Class Meeting
        Public Property Subject As String
        Public Property StartTime As DateTime
        Public Property EndTime As DateTime

        ''' <summary>
        ''' Optional text color of the appointment. Null means "use the control's default".
        ''' </summary>
        Public Property ForeColor As Color?

        ''' <summary>
        ''' Optional background color of the appointment. Null means "use the control's default".
        ''' </summary>
        Public Property BackColor As Color?
    End Class
End Namespace
