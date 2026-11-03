#nullable disable
using System;
using System.Drawing;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    /// <summary>
    /// Plain data model representing a meeting.
    /// Kept as a simple POCO so the Form (View) has no business logic.
    /// </summary>
    public class Meeting
    {
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Optional text color of the appointment. Null means "use the control's default".
        /// </summary>
        public Color? ForeColor { get; set; }

        /// <summary>
        /// Optional background color of the appointment. Null means "use the control's default".
        /// </summary>
        public Color? BackColor { get; set; }
    }
}
