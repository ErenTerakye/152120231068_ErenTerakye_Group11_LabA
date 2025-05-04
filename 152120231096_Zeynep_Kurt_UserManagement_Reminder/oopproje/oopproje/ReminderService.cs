using System.Collections.Generic;

namespace oopproje
{
    public static class ReminderService
    {
        private static List<Reminder> reminders = new List<Reminder>();

        public static void AddReminder(Reminder reminder)
        {
            reminders.Add(reminder);
        }

        public static List<Reminder> GetRemindersByUserId(int userId)
        {
            return reminders.FindAll(r => r.UserId == userId);
        }
    }
}
