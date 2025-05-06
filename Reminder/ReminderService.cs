using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Reminder
{
    public static class ReminderService
    {
        private static readonly string CsvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reminders.csv");
        public static BindingList<Reminder> Reminders { get; } = new BindingList<Reminder>();
        private static readonly List<ReminderObserver> _observers = new List<ReminderObserver>();

        static ReminderService()
        {
            LoadFromCsv();
            SetupAutoSave();
        }

        private static void SetupAutoSave()
        {
            Reminders.ListChanged += (s, e) => SaveToCsv();
        }

        public static void RegisterObserver(ReminderObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public static void AddReminder(Reminder reminder)
        {
            Reminders.Add(reminder);
            _observers.ForEach(o => o.Update(reminder.Summary, reminder));
        }

        private static void LoadFromCsv()
        {
            if (!File.Exists(CsvPath)) return;

            try
            {
                var lines = File.ReadAllLines(CsvPath);
                foreach (var line in lines.Skip(1)) // Başlık satırını atla
                {
                    var parts = line.Split(',');
                    if (parts.Length < 6) continue;

                    Reminder reminder = parts[0] == "Meeting"
                        ? new MeetingReminder { Location = parts[5], Attendees = parts[6].Split(';').ToList() }
                        : new TaskReminder { Category = parts[5], IsCompleted = bool.Parse(parts[6]) };

                    reminder.Summary = parts[1];
                    reminder.Description = parts[2];
                    reminder.Date = DateTime.Parse(parts[3]);
                    reminder.Time = TimeSpan.Parse(parts[4]);

                    Reminders.Add(reminder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void SaveToCsv()
        {
            try
            {
                using (var writer = new StreamWriter(CsvPath))
                {
                    writer.WriteLine("Type,Summary,Description,Date,Time,Extra1,Extra2"); // Başlık
                    foreach (var r in Reminders)
                    {
                        if (r is MeetingReminder m)
                            writer.WriteLine($"Meeting,{r.Summary},{r.Description},{r.Date},{r.Time},{m.Location},{string.Join(";", m.Attendees)}");
                        else if (r is TaskReminder t)
                            writer.WriteLine($"Task,{r.Summary},{r.Description},{r.Date},{r.Time},{t.Category},{t.IsCompleted}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV kaydetme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}