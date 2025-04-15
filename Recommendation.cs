// File: Models/Recommendation.cs
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

        public string SuggestOutfit()
        {
            // منطق اقتراح اللبس
            string suggestion = "بدلة كلاسيكية";
            Event.OutfitSuggestions.Add(suggestion);
            return suggestion;
        }

        public string SuggestConversationTopics()
        {
            string suggestion = (User.PreferredTopics.Count > 0) ? User.PreferredTopics[0] : "مواضيع عامة";
            Event.ConversationTopics.Add(suggestion);
            return suggestion;
        }
    }
}
