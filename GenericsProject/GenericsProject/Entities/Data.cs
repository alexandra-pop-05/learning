namespace GenericsProject.Entities
{
    internal class Data
    {

        public static List<Project> Project = new()
        {
            new Project
            {
                Id = 1,
                ProjectName = "Goodleap",
                ProjectStatus = "On hold"
            },
            new Project
            {
                Id = 2,
                ProjectName = "LittlePay",
                 ProjectStatus = "Completed"
            },
            new Project
            {
                Id = 3,
                ProjectName = "Smartcare",
                ProjectStatus = "In progress"
            },
            new Project
            {
                Id = 4,
                ProjectName = "Solarizd",
                ProjectStatus = "On hold"
            }
        };

        public static List<Users> Users = new()
        {
            new Users
            {
                Id = 1,
                Nickname = "Popescu Andrei",
                Birthday = new DateTime(2001, 08, 05)

            },
            new Users
            {
                Id = 2,
                Nickname = "Popescu Maria",
                Birthday = new DateTime(1998, 10, 01)
            },
            new Users
            {
                Id = 3,
                Nickname = "Ionescu Mihai",
                Birthday = new DateTime(1999, 04, 12)
            }
        };
    }
}

