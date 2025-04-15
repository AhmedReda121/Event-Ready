// File: Models/RecommendationFactory.cs
using System;

namespace EVENT_READY
{
    // الواجهة المجردة للتصنيع (Factory Method)
    public abstract class RecommendationFactory
    {
        public abstract Recommendation CreateRecommendation(User user, Event ev);
    }

    // تطبيق مصنع للتوصيات للمستخدمين الانطوائيين
    public class IntrovertRecommendationFactory : RecommendationFactory
    {
        public override Recommendation CreateRecommendation(User user, Event ev)
        {
            // منطق مخصص للمستخدمين الانطوائيين
            Recommendation rec = new Recommendation(user, ev);
            // على سبيل المثال: نستخدم اقتراحات هادئة وبسيطة
            rec.SuggestOutfit(); // اقتراح اللبس
            rec.SuggestConversationTopics(); // اقتراح الموضوع
            return rec;
        }
    }

    // تطبيق مصنع للتوصيات للمستخدمين الغير انطوائيين (مثلاً اجتماعيين)
    public class ExtrovertRecommendationFactory : RecommendationFactory
    {
        public override Recommendation CreateRecommendation(User user, Event ev)
        {
            // منطق مخصص للمستخدمين الاجتماعيين
            Recommendation rec = new Recommendation(user, ev);
            // يمكن تخصيص اقتراحات اللبس والمواضيع لتتماشى مع النشاط والحيوية
            rec.SuggestOutfit(); // اقتراح اللبس
            rec.SuggestConversationTopics(); // اقتراح الموضوع
            return rec;
        }
    }
}
