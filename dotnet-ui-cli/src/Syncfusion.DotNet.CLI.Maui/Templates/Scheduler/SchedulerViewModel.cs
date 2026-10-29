using System;
using System.Collections.ObjectModel;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public class __VIEW_MODEL_NAME__
    {
        public ObservableCollection<SchedulerModel> Appointments { get; } = [];

        public __VIEW_MODEL_NAME__()
        {
            var today = DateTime.Today;
            string[] activities = ["Planning", "Design review", "Implementation", "Testing", "Release preparation", "Documentation", "Retrospective"];
            for (var day = 0; day < activities.Length; day++)
            {
                var date = today.AddDays(day);
                Appointments.Add(new SchedulerModel { Subject = "Daily check-in", StartTime = date.AddHours(9), EndTime = date.AddHours(9.5) });
                Appointments.Add(new SchedulerModel { Subject = activities[day], StartTime = date.AddHours(11), EndTime = date.AddHours(12) });
                Appointments.Add(new SchedulerModel { Subject = "Project follow-up", StartTime = date.AddHours(14), EndTime = date.AddHours(15) });
            }
        }
    }
}
