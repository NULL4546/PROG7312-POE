using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7312Lopes
{
    public static class EventStorage
    {
        // Dictionary
        private static Dictionary<string, List<Event>> eventsByCategory = new Dictionary<string, List<Event>>(StringComparer.OrdinalIgnoreCase);

        // Stack
        private static Stack<Event> recentEvents = new Stack<Event>();

        // Queue
        private static Queue<Event> eventsByDate = new Queue<Event>();

        public static void AddEvent(Event newEvent)
        {
            if (!eventsByCategory.ContainsKey(newEvent.Category))
            {
                eventsByCategory[newEvent.Category] = new List<Event>();
            }
            eventsByCategory[newEvent.Category].Add(newEvent);

            recentEvents.Push(newEvent);

            InsertEventInQueueByDate(newEvent);
        }

        private static void InsertEventInQueueByDate(Event newEvent)
        {
            List<Event> tempList = eventsByDate.ToList();
            tempList.Add(newEvent);
            tempList = tempList.OrderBy(e => e.EventDate).ToList();
            eventsByDate.Clear();
            foreach (var evnt in tempList)
            {
                eventsByDate.Enqueue(evnt);
            }
        }

        // Get all events
        public static List<Event> GetAllEvents()
        {
            return eventsByCategory.Values.SelectMany(events => events).ToList();
        }

        // Search events by category and/or date
        public static List<Event> SearchEvents(string category = null, DateTime? date = null)
        {
            var result = new List<Event>();

            if (!string.IsNullOrEmpty(category) && eventsByCategory.ContainsKey(category))
            {
                result.AddRange(eventsByCategory[category]);
            }
            else
            {
                result.AddRange(GetAllEvents());
            }

            if (date.HasValue)
            {
                result = result.Where(e => e.EventDate.Date == date.Value.Date).ToList();
            }

            return result;
        }

        public static Event GetMostRecentEvent()
        {
            return recentEvents.Count > 0 ? recentEvents.Peek() : null;
        }

        public static Event GetNextUpcomingEvent()
        {
            return eventsByDate.Count > 0 ? eventsByDate.Peek() : null;
        }
    }
}
