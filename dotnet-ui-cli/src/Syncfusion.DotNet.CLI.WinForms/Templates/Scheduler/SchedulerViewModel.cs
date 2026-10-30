#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using Syncfusion.Schedule;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    /// <summary>
    /// ViewModel for the Scheduler view.
    /// Exposes a <see cref="SimpleScheduleDataProvider"/> that the Form binds to.
    /// All appointment-creation logic lives here so the Form stays UI-only.
    /// </summary>
    public class __VIEW_MODEL_NAME__
    {
        /// <summary>
        /// The data provider consumed by <c>ScheduleControl.DataSource</c>.
        /// </summary>
        public SimpleScheduleDataProvider Provider { get; }

        public __VIEW_MODEL_NAME__()
        {
            Provider = new SimpleScheduleDataProvider();
            SeedSampleAppointments();
        }

        /// <summary>
        /// Adds a single meeting to the underlying appointment collection.
        /// Optional <see cref="Meeting.ForeColor"/> and <see cref="Meeting.BackColor"/>
        /// are applied directly to the <see cref="ScheduleAppointment"/>.
        /// </summary>
        public void AddMeeting(Meeting meeting)
        {
            if (meeting == null) return;

            var appointment = new ScheduleAppointment
            {
                Subject = meeting.Subject,
                StartTime = meeting.StartTime,
                EndTime = meeting.EndTime
            };

            // Apply colors only when explicitly set, so unspecified meetings
            // keep the control's default theme.
            if (meeting.ForeColor.HasValue)
                appointment.ForeColor = meeting.ForeColor.Value;

            if (meeting.BackColor.HasValue)
                appointment.BackColor = meeting.BackColor.Value;

            Provider.MasterList.Add(appointment);
        }

        private void SeedSampleAppointments()
        {
            var now = DateTime.Now;
            var today9am = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0);

            var samples = new List<Meeting>
            {
                new Meeting { Subject = "Team Meeting",      StartTime = now,                  EndTime = now.AddHours(1) },

                new Meeting
                {
                    Subject   = "Project Review",
                    StartTime = today9am,
                    EndTime   = today9am.AddHours(2),
                    ForeColor = Color.Black,
                    BackColor= Color.LightBlue
                },

                new Meeting
                {
                    Subject   = "Lunch with Client",
                    StartTime = today9am.AddHours(4),
                    EndTime   = today9am.AddHours(5),
                    BackColor = Color.LightGreen
                },

                new Meeting
                {
                    Subject   = "Design Sync",
                    StartTime = today9am.AddDays(1),
                    EndTime   = today9am.AddDays(1).AddHours(1),
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White
                }
            };

            foreach (var m in samples)
            {
                AddMeeting(m);
            }
        }
    }
}
