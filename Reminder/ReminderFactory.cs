namespace Reminder
{
    public abstract class ReminderFactory
    {
        public abstract Reminder CreateReminder(string summary, DateTime date, TimeSpan time);
    }

    public class MeetingReminderFactory : ReminderFactory
    {
        public string DefaultLocation { get; set; } = "Online";

        public override Reminder CreateReminder(string summary, DateTime date, TimeSpan time)
        {
            return new MeetingReminder
            {
                Summary = summary,
                Date = date,
                Time = time,
                Location = DefaultLocation
            };
        }
    }

    public class TaskReminderFactory : ReminderFactory
    {
        public override Reminder CreateReminder(string summary, DateTime date, TimeSpan time)
        {
            return new TaskReminder
            {
                Summary = summary,
                Date = date,
                Time = time,
                Category = "Genel"
            };
        }
    }
}