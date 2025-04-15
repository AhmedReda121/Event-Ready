using System.Collections.Generic;

namespace EVENT_READY
{
    public class ConversationSimulator
    {
        public List<string> SimulatedConversations { get; set; } = new List<string>();

        public string SimulateConversation(User user, List<string> topics)
        {
            string topicsJoined = string.Join(", ", topics);
            string result = $"Simulated conversation with {user.Name} about {topicsJoined}";
            SimulatedConversations.Add(result);
            return result;
        }

        public string ProvideFeedback(string simulationResult)
        {
            return "Improve active listening and note-taking skills.";
        }
    }
}
