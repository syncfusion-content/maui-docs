#nullable disable
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        public __VIEW_NAME__()
        {
            var viewModel = new __VIEW_MODEL_NAME__();
            var scheduleControl = new ScheduleControl();

            // Configure the scheduler control
            scheduleControl.ScheduleType = ScheduleViewType.Day;
            scheduleControl.DataSource = viewModel.Provider;
            scheduleControl.Dock = DockStyle.Fill;

            Controls.Add(scheduleControl);
        }
    }
}
