using System;
using System.Collections.Generic;
using TWproject;

namespace TWproject
{
    public interface IShowDetails
    {
        void ShowDetails();
    }

    public interface IApprovable
    {
        void Approve();
    }


    public abstract class Event : IShowDetails, IApprovable
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Description { get; set; }


        public void ShowDetails()
        {
            Console.WriteLine("Event Details:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"From Date: {FromDate}");
            Console.WriteLine($"To Date: {ToDate}");
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void Approve()
        {
            Console.WriteLine($"Event '{EventName}' has been approved.");
        }

        public abstract void EventDetails();
    }

    public class ConcreteEvent : Event
    {
        public override void EventDetails()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class ProjectMember : IShowDetails
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Project Member Details:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Email: {Email}");
        }

    }

    public class Project : IShowDetails
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int TeamManagerId { get; set; }
        public int ProjectManagerId { get; set; }
        public string ProjectStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Project Details:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Project Name: {ProjectName}");
            Console.WriteLine($"Team Manager ID: {TeamManagerId}");
            Console.WriteLine($"Project Manager ID: {ProjectManagerId}");
            Console.WriteLine($"Project Status: {ProjectStatus}");
            Console.WriteLine($"Start Date: {StartDate}");
            Console.WriteLine($"End Date: {EndDate}");
            Console.WriteLine($"Client: {Client}");
            Console.WriteLine($"Description: {Description}");
        }

      /*  public int ShowDetails()
        {
            int age;
            return age;
        }*/

    }

    public class User : ProjectMember
    {
        public int FreeDaysLeft { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Free Days Left: {FreeDaysLeft}");
        }
    }





    public class Program
    {
        public static void Main(string[] args)
        {

            // Create users
            User user1 = new User
            {
                Id = 1,
                Nickname = "Alexandra Pop",
                Email = "ale@yahoo.com",
                FreeDaysLeft = 5
            };

            User user2 = new User
            {
                Id = 2,
                Nickname = "Ioana Hetea",
                Email = "ioanaH@yahoo.com",
                FreeDaysLeft = 7
            };

            // Create project
            Project project1 = new Project
            {
                Id = 1,
                ProjectName = "Sample Project",
                TeamManagerId = user1.Id,
                ProjectManagerId = user2.Id,
                ProjectStatus = "In progress",
                StartDate = new DateTime(2023, 7, 1),
                EndDate = new DateTime(2023, 12, 31),
                Client = "ABC Corp",
                Description = "A sample project"
            };

            // Create events
            Event event1 = new ConcreteEvent
            {
                Id = 1,
                EventName = "Vacation",
                Type = "Time Off",
                Status = "Pending",
                FromDate = new DateTime(2023, 8, 1),
                ToDate = new DateTime(2023, 8, 7),
                Description = "Vacation trip"
            };

            Event event2 = new ConcreteEvent
            {
                Id = 2,
                EventName = "Conference",
                Type = "Event",
                Status = "Accepted",
                FromDate = new DateTime(2023, 9, 15),
                ToDate = new DateTime(2023, 9, 17),
                Description = "Annual conference"
            };

            // Show details of users, project, and events
            user1.ShowDetails();
            Console.WriteLine();
            user2.ShowDetails();
            Console.WriteLine();
            project1.ShowDetails();
            Console.WriteLine();
            event1.ShowDetails();
            Console.WriteLine();
            event2.ShowDetails();
            Console.WriteLine();

            // polymorfism
            List<IShowDetails> showDetailsList = new List<IShowDetails>
            {
                user1,
                user2,
                project1,
                event1,
                event2
            };

            Console.WriteLine("Details of objects in the list:");
            foreach (var item in showDetailsList)
            {
                item.ShowDetails();
                Console.WriteLine();
            }

            
        }
    }

}