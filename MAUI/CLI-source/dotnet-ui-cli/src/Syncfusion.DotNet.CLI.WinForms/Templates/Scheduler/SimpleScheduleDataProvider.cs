#nullable disable
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.Schedule;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    /// <summary>
    /// Minimal in-memory data provider for the Syncfusion WinForms Scheduler.
    /// Stores appointments in a <see cref="SimpleScheduleAppointmentList"/> and
    /// implements just enough of <see cref="ScheduleDataProvider"/> for the
    /// ScheduleControl to display and edit items.
    /// </summary>
    public class SimpleScheduleDataProvider : ScheduleDataProvider
    {
        public SimpleScheduleDataProvider()
            : base()
        {
        }

        private SimpleScheduleAppointmentList masterList = new SimpleScheduleAppointmentList();

        /// <summary>
        /// Backing store of appointments. The ScheduleControl reads from here.
        /// </summary>
        public SimpleScheduleAppointmentList MasterList
        {
            get { return masterList; }
            set { masterList = value; }
        }

        #region ScheduleDataProvider overrides

        public override IScheduleAppointmentList GetSchedule(DateTime startDate, DateTime endDate)
        {
            ScheduleAppointmentList list = new ScheduleAppointmentList();
            DateTime start = startDate.Date;
            DateTime end = endDate.Date;

            foreach (ScheduleAppointment item in this.MasterList)
            {
                if ((item.StartTime.Date >= start && item.StartTime.Date <= end) ||
                    (item.EndTime.Date > start && item.EndTime.Date <= end))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public override IScheduleAppointmentList GetScheduleForDay(DateTime day)
        {
            ScheduleAppointmentList list = new ScheduleAppointmentList();
            day = day.Date;

            foreach (ScheduleAppointment item in this.MasterList)
            {
                if (item.StartTime.Date == day || item.EndTime.Date == day)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public override void CommitChanges()
        {
            this.IsDirty = false;
        }

        public override bool IsDirty
        {
            get { return base.IsDirty; }
            set { base.IsDirty = value; }
        }

        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleScheduleAppointment();
        }

        public override void AddItem(IScheduleAppointment item)
        {
            this.MasterList.Add(item);
        }

        public override void RemoveItem(IScheduleAppointment item)
        {
            this.MasterList.Remove(item);
        }

        #endregion
    }

    /// <summary>
    /// Minimal appointment list. Uses the base <see cref="ScheduleAppointmentList"/>
    /// collection; only customises the appointment factory.
    /// </summary>
    [Serializable]
    public class SimpleScheduleAppointmentList : ScheduleAppointmentList
    {
        public SimpleScheduleAppointmentList() : base()
        {
        }

        public override IScheduleAppointment NewScheduleAppointment()
        {
            return new SimpleScheduleAppointment();
        }
    }

    /// <summary>
    /// Minimal concrete appointment. Inherits all fields/properties from
    /// <see cref="ScheduleAppointment"/>; no extra properties required for the sample.
    /// </summary>
    [Serializable]
    public class SimpleScheduleAppointment : ScheduleAppointment
    {
        public SimpleScheduleAppointment() : base()
        {
        }
    }
}
