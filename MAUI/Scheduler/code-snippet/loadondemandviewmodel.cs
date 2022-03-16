using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MAUISchedulerDemo
{
    /// <summary>
    /// The load on demand view model.
    /// </summary>
    public class LoadOnDemandViewModel : INotifyPropertyChanged
    {
        private bool showBusyIndicator;
        private ObservableCollection<SchedulerAppointment> events;

        /// <summary>
        /// Gets or sets load on demand command.
        /// </summary>
        public ICommand QueryAppointmentsCommand { get; set; }

        /// <summary>
        /// Gets or sets the event collection.
        /// </summary>
        public ObservableCollection<SchedulerAppointment> Events
        {
            get { return events; }
            set
            {
                events = value;
                this.RaiseOnPropertyChanged(nameof(Events));
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to show the busy indicator.
        /// </summary>
        public bool ShowBusyIndicator
        {
            get { return showBusyIndicator; }
            set
            {
                showBusyIndicator = value;
                this.RaiseOnPropertyChanged(nameof(ShowBusyIndicator));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadOnDemandViewModel" /> class.
        /// </summary>
        public LoadOnDemandViewModel()
        {
            this.QueryAppointmentsCommand = new Command<object>(LoadMoreAppointments, CanLoadMoreAppointments);
        }

        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool CanLoadMoreAppointments(object obj)
        {
            return true;
        }
        private async void LoadMoreAppointments(object obj)
        {
            this.ShowBusyIndicator = true;
            await Task.Delay(1500);
            this.Events = this.GenerateSchedulerAppointments(((SchedulerQueryAppointmentsEventArgs)obj).VisibleDates);
            this.ShowBusyIndicator = false;
        }

        /// <summary>
        /// Method to generate scheduler appointments based on current visible date range.
        /// </summary>
        /// <param name="visibleDates">Current visible date range.</param>
        private ObservableCollection<SchedulerAppointment> GenerateSchedulerAppointments(List<DateTime> visibleDates)
        {
            var brush = new ObservableCollection<Brush>
        {
            new SolidColorBrush(Color.FromArgb("#FF8B1FA9")),
            new SolidColorBrush(Color.FromArgb("#FFD20100")),
            new SolidColorBrush(Color.FromArgb("#FFFC571D")),
            new SolidColorBrush(Color.FromArgb("#FF36B37B")),
            new SolidColorBrush(Color.FromArgb("#FF3D4FB5")),
            new SolidColorBrush(Color.FromArgb("#FFE47C73")),
            new SolidColorBrush(Color.FromArgb("#FF636363")),
            new SolidColorBrush(Color.FromArgb("#FF85461E")),
            new SolidColorBrush(Color.FromArgb("#FF0F8644")),
            new SolidColorBrush(Color.FromArgb("#FF01A1EF"))
        };

            var subjectCollection = new ObservableCollection<string>
        {
            "Business Meeting",
            "Conference",
            "Medical check up",
            "Performance Check",
            "Consulting",
            "Project Status Discussion",
            "Client Meeting",
            "General Meeting",
            "Yoga Therapy",
            "GoToMeeting",
            "Plan Execution",
            "Project Plan"
        };

            Random ran = new();
            int daysCount = visibleDates.Count;
            DateTime visibleStartDate = visibleDates.FirstOrDefault();
            var appointments = new ObservableCollection<SchedulerAppointment>();
            for (int i = 0; i < 10; i++)
            {
                var startTime = visibleStartDate.AddDays(ran.Next(0, daysCount + 1)).AddHours(ran.Next(9, 16));
                appointments.Add(new SchedulerAppointment()
                {
                    StartTime = startTime,
                    EndTime = startTime.AddHours(1),
                    Subject = subjectCollection[ran.Next(0, subjectCollection.Count)],
                    Background = brush[ran.Next(0, brush.Count)]
                });
            }

            return appointments;
        }
    }
}