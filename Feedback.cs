// File: Models/Feedback.cs
namespace EVENT_READY
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
        public int Rating { get; set; } // من 1 إلى 5
        public string Comment { get; set; }

        public void SubmitFeedback()
        {
            Event.AddFeedback(this);
        }
    }
}
