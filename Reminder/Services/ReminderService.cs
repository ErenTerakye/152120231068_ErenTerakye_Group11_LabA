using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reminder.Models;

namespace Reminder.Services
{
    public static class ReminderService
    {
        public static List<Models.Reminder> Reminders { get; } = new();  // Tam nitelikli ad

        public static void AddReminder(Models.Reminder reminder)  // Tam nitelikli ad
        {
            Reminders.Add(reminder);
        }
    }
}