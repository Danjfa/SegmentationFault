using System;

namespace StudyNow
{
    public class TimetableEvent
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The description of the event
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The location of the event
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// The starting time and date of the event
        /// </summary>
        public DateTime Start { get; set; }
        /// <summary>
        /// The ending time and date of the event
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Creates a TimetableEvent
        /// </summary>
        /// <param name="name">The name of the TimetableEvent</param>
        /// <param name="description">The description of the TimetableEvent</param>
        /// <param name="location">The location of the TimetableEvent</param>
        /// <param name="start">The start time of the TimetableEvent</param>
        /// <param name="end">The end time of the TimetableEvent</param>
        public TimetableEvent(string name, string description, string location, DateTime start, DateTime end)
        {
            Name = name;
            Description = description;
            Location = location;
            Start = start;
            End = end;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + "\nDescription: " + Description + "\nLocation: " + Location + "\nStart: " + Start + "\nEnd: " + End;
        }

        /// <summary>
        /// Check whether a Timetable event collides with this TimetableEvent
        /// </summary>
        /// <param name="timetableEvent">Timetable event to check</param>
        /// <returns>Whether a Timetable event collides with this TimetableEvent</returns>
        public bool EventCollides(TimetableEvent timetableEvent)
        {
            // Collision if start between the new events start and end or end between the new events start and end
            return Start.CompareTo(timetableEvent.Start) < 0 && Start.CompareTo(timetableEvent.End) > 0 || End.CompareTo(timetableEvent.Start) > 0 && End.CompareTo(timetableEvent.End) < 0;
        }
    }
}
