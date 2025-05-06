namespace Reminder
{
    public class MeetingReminder : Reminder
    {
        public string Location { get; set; }
        public List<string> Attendees { get; set; } = new();

        public override void Notify()
        {
            // Toplantıya özel bildirim
            Console.Beep(1000, 500); // Sesli uyarı
        }
    }
}