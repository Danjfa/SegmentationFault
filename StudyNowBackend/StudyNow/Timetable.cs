using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyNow
{
    public class Timetable
    {
        /// <summary>
        /// The list containing all of the TimetableEvents in the Timetable
        /// </summary>
        private List<TimetableEvent> _events;

        /// <summary>
        /// The read-only list containing all of the TimetableEvents in the Timetable
        /// </summary>
        public List<TimetableEvent> Events => _events;

        /// <summary>
        /// Creates new blank Timetable
        /// </summary>
        public Timetable()
        {
            _events = new List<TimetableEvent>();
        }

        /// <summary>
        /// Add a TimeTableEvent to the Timetable without checking if it collides with existing TimetableEvents
        /// </summary>
        /// <param name="timetableEvent">Event to add to Timetable</param>
        public void AddEventUnchecked(TimetableEvent timetableEvent)
        {
            _events.Add(timetableEvent);
        }

        /// <summary>
        /// Add a TimeTableEvent to the Timetable if it doesn't collide with existing TimetableEvents
        /// </summary>
        /// <param name="timetableEvent">Event to add to Timetable</param>
        /// <returns>Returns true if TimetableEvent successfully added otherwise false</returns>
        public bool AddEvent(TimetableEvent timetableEvent)
        {
            if (EventCollides(timetableEvent))
                return false;
            _events.Add(timetableEvent);

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (TimetableEvent timetableEvent in _events)
            {
                sb.Append(timetableEvent);
                sb.Append("\n");
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Check whether a Timetable event collides with any existing TimetableEvent in the Timetable
        /// </summary>
        /// <param name="timetableEvent">Timetable event to check</param>
        /// <returns>Whether the event collides with any of the existing TimetableEvents in the Timetable</returns>
        private bool EventCollides(TimetableEvent timetableEvent)
        {
            // Checks if any of the existing timetable events collide with it (inefficient with high amounts of events due to checking all of them)
            return _events.Any(exitingTimetableEvent => exitingTimetableEvent.EventCollides(timetableEvent));
        }
    }
}
