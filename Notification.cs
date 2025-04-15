namespace EVENT_READY
{
    public class Notification
    {
        public Event Event { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; } // Consider using DateTime

        public Notification(Event ev, string message, string timestamp)
        {
            Event = ev;
            Message = message;
            Timestamp = timestamp;
        }

        public void SendNotification()
        {
            // Simulate sending the notification (e.g., via email or mobile alert)
            System.Console.WriteLine($"Notification for event '{Event.Name}': {Message} at {Timestamp}");
        }
    }
}
