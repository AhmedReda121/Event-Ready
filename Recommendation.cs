namespace EVENT_READY
{
    public class Recommendation
    {
        public User User { get; set; }
        public Event Event { get; set; }

        public Recommendation(User user, Event ev)
        {
            User = user;
            Event = ev;
        }

        // Suggest suitable outfit for the event
        public string SuggestOutfit()
        {
            string suggestion = "Classic suit";
            Event.OutfitSuggestions.Add(suggestion);
            return suggestion;
        }

        // Suggest a conversation topic based on user preferences
        public string SuggestConversationTopics()
        {
            string suggestion = (User.PreferredTopics.Count > 0) ? User.PreferredTopics[0] : "General topics";
            Event.ConversationTopics.Add(suggestion);
            return suggestion;
        }
    }
}
