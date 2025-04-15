// File: Models/Group.cs
using System.Collections.Generic;

namespace EVENT_READY
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public List<User> Members { get; set; } = new List<User>();
        public List<string> GroupTopics { get; set; } = new List<string>();

        public Group() { }

        public Group(int groupId, string groupName, List<string> groupTopics = null)
        {
            GroupId = groupId;
            GroupName = groupName;
            GroupTopics = groupTopics ?? new List<string>();
        }

        public void AddMember(User user)
        {
            Members.Add(user);
        }

        public void RemoveMember(User user)
        {
            if (Members.Contains(user))
                Members.Remove(user);
        }
    }
}
