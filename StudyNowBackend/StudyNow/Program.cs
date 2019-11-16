using System;

namespace StudyNow
{
    class Program
    {
        public static void Main(string[] args)
        {
            Timetable timetable = new Timetable();
            
            TimetableEvent timetableEvent = CreateEvent();
            
            timetable.AddEventUnchecked(timetableEvent);
            
            Console.WriteLine();
            Console.WriteLine(timetable);
            Console.ReadLine();
        }

        private static TimetableEvent CreateEvent()
        {
            // Get name
            Console.Write("Name of event: ");
            string name = Console.ReadLine();
            
            // Get Description
            Console.Write("Description of event: ");
            string description = Console.ReadLine();
            
            // Get Location
            Console.Write("Location of event: ");
            string location = Console.ReadLine();
            
            // Start year
            int startYear = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter event start year: ");
                valid = int.TryParse(Console.ReadLine(), out startYear) && startYear > 0 && startYear <= 9999;
            }
            
            // Start month
            int startMonth = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event start month as a number: ");
                valid = int.TryParse(Console.ReadLine(), out startMonth) && startMonth > 0 && startMonth <= 12;
            }
            
            // Start day
            int startDay = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event start day: ");
                valid = int.TryParse(Console.ReadLine(), out startDay) && startDay > 0 && startDay <= 31;
            }
            
            // Start hour
            int startHour = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event start hour: ");
                valid = int.TryParse(Console.ReadLine(), out startHour) && startHour >= 0 && startHour < 24;
            }
            
            // Start minute
            int startMinute = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event start minute: ");
                valid = int.TryParse(Console.ReadLine(), out startMinute) && startMinute >= 0 && startMinute < 60;
            }
            
            // End year
            int endYear = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event end year: ");
                valid = int.TryParse(Console.ReadLine(), out endYear) && endYear > 0 && endYear <= 9999;
            }
            
            // End month
            int endMonth = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event end month as a number: ");
                valid = int.TryParse(Console.ReadLine(), out endMonth) && endMonth > 0 && endMonth <= 12;
            }
            
            // End day
            int endDay = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event end day: ");
                valid = int.TryParse(Console.ReadLine(), out endDay) && endDay > 0 && endDay <= 31;
            }
            
            // End hour
            int endHour = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event end hour: ");
                valid = int.TryParse(Console.ReadLine(), out endHour) && endHour >= 0 && endHour < 24;
            }
            
            // End minute
            int endMinute = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter event end minute: ");
                valid = int.TryParse(Console.ReadLine(), out endMinute) && endMinute >= 0 && endMinute < 60;
            }
            
            return new TimetableEvent(name, description, location,
                new DateTime(startYear, startMonth, startDay, startHour, startMinute, 0),
                new DateTime(endYear, endMonth, endDay, endHour, endMinute, 0));
        }
    }
}
