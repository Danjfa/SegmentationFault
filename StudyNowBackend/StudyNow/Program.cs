using System;

namespace StudyNow
{
    class Program
    {
        public static void Main(string[] args)
        {
            Timetable timetable = new Timetable();

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("(q)uit to quit, (t) to run unit tests, (d)isplay to display the timetable events (a)dd to create new event and add it to the timetable");
                string input = Console.ReadLine();
                switch (input?.ToLower())
                {
                    case "q":
                    case "quit":
                        quit = true;
                        break;
                    case "d":
                    case "display":
                        Console.WriteLine();
                        Console.WriteLine(timetable);
                        break;
                    case "t":
                    case "test":
                        TestCollides();
                        break;
                    case "a":
                    case "add":
                        Console.WriteLine(timetable.AddEvent(CreateEvent())
                            ? "Event added successfully"
                            : "Event could not be added");
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
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

        private static void TestCollides()
        {
            Timetable timetable = new Timetable();

            Console.WriteLine("Testing event collision detection:");
            TimetableEvent a = new TimetableEvent("a", "", "",
                new DateTime(2019, 1, 1, 12, 0, 0), 
                new DateTime(2019, 1, 1, 13, 0, 0));
            TimetableEvent b = new TimetableEvent("b", "", "",
                new DateTime(2019, 1, 1, 12, 30, 0), 
                new DateTime(2019, 1, 1, 13, 30, 0));
            TimetableEvent c = new TimetableEvent("c", "", "",
                new DateTime(2019, 1, 1, 14, 30, 0), 
                new DateTime(2019, 1, 1, 15, 30, 0));
            TimetableEvent d = new TimetableEvent("d", "", "",
                new DateTime(2019, 1, 1, 1, 30, 0), 
                new DateTime(2019, 1, 1, 2, 30, 0));

            Console.WriteLine(a.EventCollides(b) ? "- Success" : "- Failure");
            Console.WriteLine(a.EventCollides(c) ? "- Failure" : "- Success");
            Console.WriteLine(a.EventCollides(d) ? "- Failure" : "- Success");
            Console.WriteLine(timetable.AddEvent(a) ? "- Success" : "- Failure");
            Console.WriteLine(timetable.AddEvent(c) ? "- Success" : "- Failure");
            Console.WriteLine(timetable.AddEvent(d) ? "- Success" : "- Failure");
            Console.WriteLine(timetable.AddEvent(b) ? "- Failure" : "- Success");
            Console.WriteLine();
        }
    }
}
