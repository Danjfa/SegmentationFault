using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Study_Now
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