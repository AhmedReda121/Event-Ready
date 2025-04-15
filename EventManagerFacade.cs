// File: Models/EventManagerFacade.cs
using System;

namespace EVENT_READY
{
    public class EventManagerFacade
    {
        // دالة لإنشاء مناسبة جديدة مع بعض الإعدادات الافتراضية
        public Event CreateEvent(int eventId, string name, string date, string location)
        {
            Event ev = new Event(eventId, name, date, location);
            // يمكن إضافة عمليات تهيئة إضافية هنا
            return ev;
        }

        // دالة لإضافة الحضور للمناسبة وإضافتها لتقويم المستخدم
        public void AddAttendeeToEvent(Event ev, User user)
        {
            ev.AddAttendee(user);
            user.AddEventToCalendar(ev);
        }

        // دالة لتوليد توصية بناءً على نوع شخصية المستخدم
        public Recommendation GenerateRecommendation(User user, Event ev)
        {
            RecommendationFactory factory;
            // تحديد المصنع المناسب بناءً على نوع شخصية المستخدم
            if (user.PersonalityType.ToLower().Contains("انطوائي"))
            {
                factory = new IntrovertRecommendationFactory();
            }
            else
            {
                factory = new ExtrovertRecommendationFactory();
            }
            Recommendation rec = factory.CreateRecommendation(user, ev);
            return rec;
        }

        // دالة لجدولة تنبيه للمناسبة بالنسبة للمستخدم
        public void ScheduleNotification(User user, Event ev, string notificationTime)
        {
            user.Calendar.SetReminder(ev, notificationTime);
        }
    }
}
