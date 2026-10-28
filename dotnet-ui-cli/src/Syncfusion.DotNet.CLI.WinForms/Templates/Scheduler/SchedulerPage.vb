#Disable Warning BC40000
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Schedule

Namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
    Public Partial Class __VIEW_NAME__
        Inherits UserControl

        Public Sub New()
            Dim viewModel = New __VIEW_MODEL_NAME__()
            Dim scheduleControl = New ScheduleControl()

            ' Configure the scheduler control
            scheduleControl.ScheduleType = ScheduleViewType.Day
            scheduleControl.DataSource = viewModel.Provider
            scheduleControl.Dock = DockStyle.Fill

            Controls.Add(scheduleControl)
        End Sub
    End Class
End Namespace
