// File: Models/ConversationSimulator.cs
using System.Collections.Generic;

namespace EVENT_READY
{
    public class ConversationSimulator
    {
        public List<string> SimulatedConversations { get; set; } = new List<string>();

        public string SimulateConversation(User user, List<string> topics)
        {
            string topicsJoined = string.Join(", ", topics);
            string result = $"تمت محاكاة محادثة مع {user.Name} حول {topicsJoined}";
            SimulatedConversations.Add(result);
            return result;
        }

        public string ProvideFeedback(string simulationResult)
        {
            return "ننصح بتحسين مهارات الاستماع وتسجيل الملاحظات.";
        }
    }
}
