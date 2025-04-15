using System;

namespace EVENT_READY
{
    public class EventManagerFacade
    {
        // Create a new event with default setup
        public Event CreateEvent(int eventId, string name, string date, string location)
        {
            Event ev = new Event(eventId, name, date, location);
            return ev;
        }

        // Add a user to the event and to their calendar
        public void AddAttendeeToEvent(Event ev, User user)
        {
            ev.AddAttendee(user);
            user.AddEventToCalendar(ev);
        }

        // Generate recommendations based on user's personality type
        public Recommendation GenerateRecommendation(User user, Event ev)
        {
            RecommendationFactory factory;

            if (user.PersonalityType.ToLower().Contains("introvert"))
            {
                factory = new IntrovertRecommendationFactory();
            }
            else
            {
                factory = new ExtrovertRecommendationFactory();
            }

            return factory.CreateRecommendation(user, ev);
        }

        // Schedule a notification for the event
        public void ScheduleNotification(User user, Event ev, string notificationTime)
        {
            user.Calendar.SetReminder(ev, notificationTime);
        }
    }
}
