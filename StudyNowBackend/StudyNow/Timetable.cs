using System.Collections.Generic;
using System.Text;

namespace StudyNow
{
    public class Timetable
    {
        private List<TimetableEvent> _events;

        public List<TimetableEvent> Events => _events;

        public Timetable()
        {
            _events = new List<TimetableEvent>();
        }

        public void AddEventUnchecked(TimetableEvent _event)
        {
            _events.Add(_event);
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
    }
}
