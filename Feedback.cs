namespace EVENT_READY
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
        public int Rating { get; set; } 
        public string Comment { get; set; }

        public void SubmitFeedback()
        {
            Event.AddFeedback(this);
        }
    }
}
