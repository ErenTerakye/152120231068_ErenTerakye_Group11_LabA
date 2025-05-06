namespace Reminder
{
    public class TaskReminder : Reminder
    {
        public string Category { get; set; }
        public bool IsCompleted { get; set; }

        public override void Notify()
        {
            // Göreve özel bildirim
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}