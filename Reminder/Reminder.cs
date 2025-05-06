using System;

namespace Reminder
{
    public abstract class Reminder
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public abstract void Notify();

        public bool IsUrgent =>
            (Date.Date == DateTime.Today) &&
            (Time.Hours - DateTime.Now.Hour <= 2);
    }
}