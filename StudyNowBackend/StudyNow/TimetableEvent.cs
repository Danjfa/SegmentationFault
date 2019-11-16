using System;

namespace StudyNow
{
    public class TimetableEvent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

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
    }
}
