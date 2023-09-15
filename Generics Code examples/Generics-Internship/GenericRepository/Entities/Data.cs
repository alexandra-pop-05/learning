namespace GenericRepository.Entities
{
    /// <summary>
    /// Static placeholder to keep entity data
    /// </summary>
    public static class Data
    {
        public static List<Course> Courses = new()
        {
            new Course
            {
                Id = 1,
                Name = "Data Structures"
            },
            new Course
            {
                Id = 2,
                Name = "OOP Programming"
            },
            new Course
            {
                Id = 3,
                Name = "Cloud Computing"
            },
            new Course
            {
                Id = 4,
                Name = "SQL"
            }
        };

        public static List<Student> Students = new()
        {
            new Student
            {
                Id = 1,
                Name = "Popescu Andrei",
                Courses = new List<Course>{Courses[0], Courses[1] }
            },
            new Student
            {
                Id = 2,
                Name = "Popescu Maria",
                Courses = Courses
            },
            new Student
            {
                Id = 3,
                Name = "Ionescu Mihai",
                Courses = new List<Course>{ Courses[3] }
            }
        };
    }
}
