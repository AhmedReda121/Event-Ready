using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EVENT_READY
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PersonalityType { get; set; }
        public List<string> PreferredTopics { get; set; } = new List<string>();
        public List<Group> JoinedGroups { get; set; } = new List<Group>();
        public Calendar Calendar { get; set; } = new Calendar();

        public void Register()
        {
            // Registration logic should be implemented here
        }

        public void UpdatePreferences(List<string> newTopics)
        {
            PreferredTopics = newTopics;
        }

        public void JoinGroup(Group group)
        {
            group.AddMember(this);
            JoinedGroups.Add(group);
        }

        public void AddEventToCalendar(Event ev)
        {
            Calendar.AddEvent(ev);
        }
    }
}
