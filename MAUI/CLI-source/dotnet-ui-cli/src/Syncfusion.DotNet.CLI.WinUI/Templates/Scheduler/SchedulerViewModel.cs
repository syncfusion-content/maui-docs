using System;
using System.Collections.ObjectModel;

namespace @__ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    /// <summary>
    /// Collection of meetings that the scheduler will render.
    /// </summary>
    public ObservableCollection<Meeting> Events { get; } = new();

    public __VIEW_MODEL_NAME__()
    {
        var today = DateTime.Today;
        Events.Add(new Meeting()
        {
            Subject = "Sprint Planning",
            From = today.AddHours(10),
            To = today.AddHours(11)
        });
        Events.Add(new Meeting()
        {
            Subject = "Code Review",
            From = today.AddHours(14),
            To = today.AddHours(15)
        });
        Events.Add(new Meeting()
        {
            Subject = "Design Sync",
            From = today.AddDays(1).AddHours(9),
            To = today.AddDays(1).AddHours(10)
        });
        Events.Add(new Meeting()
        {
            Subject = "Client Call",
            From = today.AddDays(2).AddHours(15),
            To = today.AddDays(2).AddHours(16)
        });
    }
}

/// <summary>
/// Represents a calendar appointment (meeting) bound to the SfScheduler.
/// Property names are kept simple so they can be mapped via
/// <see cref="Syncfusion.UI.Xaml.Scheduler.SfScheduler.AppointmentMapping"/>.
/// </summary>
public sealed class Meeting
{
    /// <summary>
    /// Title of the meeting shown in the scheduler.
    /// </summary>
    public string Subject { get; set; } = "";

    /// <summary>
    /// Start date and time of the meeting.
    /// </summary>
    public DateTime From { get; set; }

    /// <summary>
    /// End date and time of the meeting.
    /// </summary>
    public DateTime To { get; set; }
}