// File: Models/Notification.cs
namespace EVENT_READY
{
    public class Notification
    {
        public Event Event { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; } // يمكن استخدام DateTime

        public Notification(Event ev, string message, string timestamp)
        {
            Event = ev;
            Message = message;
            Timestamp = timestamp;
        }

        public void SendNotification()
        {
            // هنا يتم منطق إرسال الإشعار (مثلاً عبر الإيميل أو الإشعارات على الهاتف)
            System.Console.WriteLine($"إشعار للمناسبة '{Event.Name}': {Message} في {Timestamp}");
        }
    }
}
