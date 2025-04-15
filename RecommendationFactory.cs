using System;

namespace EVENT_READY
{
    // Abstract factory for creating recommendations
    public abstract class RecommendationFactory
    {
        public abstract Recommendation CreateRecommendation(User user, Event ev);
    }

    // Factory for introverted user recommendations
    public class IntrovertRecommendationFactory : RecommendationFactory
    {
        public override Recommendation CreateRecommendation(User user, Event ev)
        {
            Recommendation rec = new Recommendation(user, ev);
            rec.SuggestOutfit();              // Suggest calm/simple outfit
            rec.SuggestConversationTopics();  // Suggest soft conversation topics
            return rec;
        }
    }

    // Factory for extroverted user recommendations
    public class ExtrovertRecommendationFactory : RecommendationFactory
    {
        public override Recommendation CreateRecommendation(User user, Event ev)
        {
            Recommendation rec = new Recommendation(user, ev);
            rec.SuggestOutfit();              // Suggest bold/energetic outfit
            rec.SuggestConversationTopics();  // Suggest engaging conversation topics
            return rec;
        }
    }
}
