using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.Schedule;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Data;

namespace __PAGE_NAMESPACE__;

public partial class SchedulerDemo
{
	public DateTime CurrentDate = new DateTime(2020, 2, 12);
    List<ScheduleData.AppointmentData> DataSource = new ScheduleData().GetScheduleData();
	public class ScheduleData
    {
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 1, 13, 9, 30, 0),
                EndTime = new DateTime(2020, 1, 13, 11, 0, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(2020, 3, 12, 12, 0, 0),
                EndTime = new DateTime(2020, 3, 12, 13, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 1, 16, 9, 30, 0),
                EndTime = new DateTime(2020, 1, 16, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 1, 15, 11, 0, 0),
                EndTime = new DateTime(2020, 1, 15, 13, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 9, 12, 0, 0),
                EndTime = new DateTime(2020, 2, 9, 13, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(2020, 2, 12, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 12, 11, 0, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(2020, 2, 11, 11, 0, 0),
                EndTime = new DateTime(2020, 2, 11, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 7, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 7, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 15, 11, 0, 0),
                EndTime = new DateTime(2020, 2, 15, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(2020, 2, 18, 10, 0, 0),
                EndTime = new DateTime(2020, 2, 18, 12, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2018",
                Location = "London",
                StartTime = new DateTime(2020, 2, 25, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 25, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(2020, 3, 6, 10, 0, 0),
                EndTime = new DateTime(2020, 3, 6, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 3, 9, 10, 30, 0),
                EndTime = new DateTime(2020, 3, 9, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2020, 3, 14, 10, 0, 0),
                EndTime = new DateTime(2020, 3, 14, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(2020, 3, 10, 9, 30, 0),
                EndTime = new DateTime(2020, 3, 10, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(2020, 1, 17, 11, 0, 0),
                EndTime = new DateTime(2020, 1, 17, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2020, 1, 12, 8, 30, 0),
                EndTime = new DateTime(2020, 1, 12, 10, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 20, 10, 0, 0),
                EndTime = new DateTime(2020, 2, 20, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Fransisco",
                StartTime = new DateTime(2020, 2, 9, 8, 30, 0),
                EndTime = new DateTime(2020, 2, 9, 10, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 3, 4, 12, 0, 0),
                EndTime = new DateTime(2020, 3, 4, 13, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 4, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 4, 10, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(2020, 3, 1, 11, 30, 0),
                EndTime = new DateTime(2020, 3, 1, 13, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(2020, 3, 2, 9, 30, 0),
                EndTime = new DateTime(2020, 3, 2, 11, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(2020, 2, 8, 12, 30, 0),
                EndTime = new DateTime(2020, 2, 8, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 25,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 6, 13, 0, 0),
                EndTime = new DateTime(2020, 2, 6, 14, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 26,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(2020, 2, 3, 12, 0, 0),
                EndTime = new DateTime(2020, 2, 3, 1, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 27,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 2, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 2, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 28,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 3, 10, 30, 0),
                EndTime = new DateTime(2020, 2, 3, 12, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 29,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 5, 10, 30, 0),
                EndTime = new DateTime(2020, 2, 5, 12, 0, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 30,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(2020, 2, 16, 12, 0, 0),
                EndTime = new DateTime(2020, 2, 16, 13, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 31,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 23, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 23, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 32,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 2, 28, 11, 0, 0),
                EndTime = new DateTime(2020, 2, 28, 13, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 33,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(2020, 2, 13, 12, 30, 0),
                EndTime = new DateTime(2020, 2, 13, 14, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 34,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 1, 27, 9, 30, 0),
                EndTime = new DateTime(2020, 1, 27, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 35,
                Subject = "Meteor Showers in 2018",
                Location = "Space Centre USA",
                StartTime = new DateTime(2020, 1, 30, 11, 0, 0),
                EndTime = new DateTime(2020, 1, 30, 13, 30, 0),
                CategoryColor = "#ea7a57"
            });
            return appData;
        }

        public List<ResourceData> GetResourceData()
        {
            List<ResourceData> resourceData = new List<ResourceData>();
            resourceData.Add(new ResourceData
            {
                Id = 1,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(2020, 2, 12, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 12, 12, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 2,
                Subject = "Requirement planning",
                StartTime = new DateTime(2020, 3, 5, 10, 30, 0),
                EndTime = new DateTime(2020, 3, 5, 12, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 3,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2020, 1, 14, 10, 0, 0),
                EndTime = new DateTime(2020, 1, 14, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 4,
                Subject = "Resource planning",
                StartTime = new DateTime(2020, 1, 16, 11, 0, 0),
                EndTime = new DateTime(2020, 1, 16, 13, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 5,
                Subject = "Timeline estimation",
                StartTime = new DateTime(2020, 2, 7, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 7, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 6,
                Subject = "Developers Meeting",
                StartTime = new DateTime(2020, 2, 11, 10, 0, 0),
                EndTime = new DateTime(2020, 2, 11, 12, 45, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 7,
                Subject = "Project Review",
                StartTime = new DateTime(2020, 2, 4, 11, 15, 0),
                EndTime = new DateTime(2020, 2, 4, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 8,
                Subject = "Manual testing",
                StartTime = new DateTime(2020, 3, 8, 9, 15, 0),
                EndTime = new DateTime(2020, 3, 8, 11, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 9,
                Subject = "Project Preview",
                StartTime = new DateTime(2020, 2, 2, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 2, 12, 45, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 10,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(2020, 2, 17, 13, 45, 0),
                EndTime = new DateTime(2020, 2, 17, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 11,
                Subject = "Bug Automation",
                StartTime = new DateTime(2020, 2, 26, 10, 0, 0),
                EndTime = new DateTime(2020, 2, 26, 12, 15, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 12,
                Subject = "Functionality testing",
                StartTime = new DateTime(2020, 2, 25, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 25, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 13,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(2020, 2, 19, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 19, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 14,
                Subject = "Test report Validation",
                StartTime = new DateTime(2020, 3, 15, 9, 0, 0),
                EndTime = new DateTime(2020, 3, 15, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 15,
                Subject = "Test case correction",
                StartTime = new DateTime(2020, 3, 18, 9, 45, 0),
                EndTime = new DateTime(2020, 3, 18, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 16,
                Subject = "Run test cases",
                StartTime = new DateTime(2020, 1, 19, 10, 30, 0),
                EndTime = new DateTime(2020, 1, 19, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 17,
                Subject = "Quality Analysis",
                StartTime = new DateTime(2020, 2, 12, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 12, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 18,
                Subject = "Debugging",
                StartTime = new DateTime(2020, 2, 13, 9, 0, 0),
                EndTime = new DateTime(2020, 2, 13, 11, 15, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 19,
                Subject = "Exception handling",
                StartTime = new DateTime(2020, 2, 16, 10, 10, 0),
                EndTime = new DateTime(2020, 2, 16, 13, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 20,
                Subject = "Decoding",
                StartTime = new DateTime(2020, 2, 28, 10, 30, 0),
                EndTime = new DateTime(2020, 2, 28, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 21,
                Subject = "Requirement planning",
                StartTime = new DateTime(2020, 2, 18, 9, 30, 0),
                EndTime = new DateTime(2020, 2, 18, 11, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 19,
                Subject = "Exception handling",
                StartTime = new DateTime(2020, 2, 18, 10, 10, 0),
                EndTime = new DateTime(2020, 2, 18, 13, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                CategoryId = 2
            });
            return resourceData;
        }

        public List<AppointmentData> GetRecurrenceData()
        {
            List<AppointmentData> recurrenceData = new List<AppointmentData>();
            recurrenceData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Project demo meeting with Andrew",
                Location = "Office",
                StartTime = new DateTime(2020, 1, 8, 9, 0, 0),
                EndTime = new DateTime(2020, 1, 8, 10, 30, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=2;BYDAY=MO;COUNT=10",
                CategoryColor = "#1aaa55",
                Description = "Project demo meeting with Andrew regarding timeline"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Scrum Meeting",
                Location = "Office",
                StartTime = new DateTime(2020, 1, 6, 12, 0, 0),
                EndTime = new DateTime(2020, 1, 6, 13, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR;INTERVAL=1",
                CategoryColor = "#357cd2",
                Description = "Weekly work status"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Meeting with Core team",
                Location = "Office",
                StartTime = new DateTime(2020, 1, 10, 9, 0, 0),
                EndTime = new DateTime(2020, 1, 10, 10, 30, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=FR",
                CategoryColor = "#7fa900",
                Description = "Future plans and posibilities"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Customer meeting – John Mackenzie",
                Location = "Office",
                StartTime = new DateTime(2020, 2, 14, 10, 30, 0),
                EndTime = new DateTime(2020, 2, 14, 11, 30, 0),
                RecurrenceRule = "FREQ=MONTHLY;BYMONTHDAY=20;INTERVAL=1;COUNT=5",
                CategoryColor = "#ea7a57",
                Description = "Regarding DataSource issue"
            });
            return recurrenceData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string? Subject { get; set; }
            public string? Location { get; set; }
            public string? Description { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public Nullable<bool> IsAllDay { get; set; }
            public string? CategoryColor { get; set; }
            public string? RecurrenceRule { get; set; }
            public string? EventType { get; set; }
            public Nullable<int> RecurrenceID { get; set; }
            public string? RecurrenceException { get; set; }
            public string? StartTimezone { get; set; }
            public string? EndTimezone { get; set; }
        }
        public class ResourceData : AppointmentData
        {
            public int ProjectId { get; set; }
            public int CategoryId { get; set; }
        }
    }
}
