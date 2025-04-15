// File: Models/Calendar.cs
using System.Collections.Generic;

namespace EVENT_READY
{
    public class Calendar
    {
        public List<Event> Events { get; set; } = new List<Event>();

        public void AddEvent(Event ev)
        {
            Events.Add(ev);
        }

        public void RemoveEvent(Event ev)
        {
            if (Events.Contains(ev))
                Events.Remove(ev);
        }

        public void SetReminder(Event ev, string notificationTime)
        {
            Notification notification = new Notification(ev, $"تنبيه: {ev.Name} سيبدأ قريباً!", notificationTime);
            notification.SendNotification();
        }
    }
}
