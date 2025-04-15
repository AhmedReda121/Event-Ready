using System.Collections.Generic;

namespace EVENT_READY
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; } 
        public string Location { get; set; }
        public List<User> Attendees { get; set; } = new List<User>();
        public List<string> OutfitSuggestions { get; set; } = new List<string>();
        public List<string> ConversationTopics { get; set; } = new List<string>();
        public List<Feedback> FeedbackList { get; set; } = new List<Feedback>();

        public Event(int eventId, string name, string date, string location)
        {
            EventId = eventId;
            Name = name;
            Date = date;
            Location = location;
        }

        public void AddAttendee(User user)
        {
            Attendees.Add(user);
        }

        public void AddFeedback(Feedback feedback)
        {
            FeedbackList.Add(feedback);
        }
    }
}
