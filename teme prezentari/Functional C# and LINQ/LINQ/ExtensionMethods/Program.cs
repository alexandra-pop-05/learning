using ExtensionMethods;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //filter students with age > 20, and dont have a part time job
            var filteredStudents = _students.Filter(student => student.Age > 20)
                                            .Filter(student => student.HasAPartTimeJob == false);
            Print(filteredStudents);

            var averageAge = _students.CalculateAverageAge();
            Console.WriteLine($"\nAverage Age of Students: {averageAge}");
        }



        static List<Student> _students => new List<Student>
        {
            new Student { FirstName = "John", LastName = "Smith", Age = 22, Year = 2020, HasAPartTimeJob = true},
            new Student { FirstName = "John", LastName = "Smith", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F1" },
            new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
            new Student { FirstName = "Michael", LastName = "Brown", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F3" },
            new Student { FirstName = "David", LastName = "Miller", Age = 20, Year = 2022, HasAPartTimeJob = false, FacultyId = "F1" },
            new Student { FirstName = "Sophia", LastName = "Davis", Age = 24, Year = 2018, HasAPartTimeJob = true, FacultyId = "F4" },
            new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
            new Student { FirstName = "Ava", LastName = "Lee", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
            new Student { FirstName = "Lucas", LastName = "Garcia", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F4" },
            new HomeStudent { FirstName = "Isabella", LastName = "Martinez", Age = 15, Year = 2020, HasAPartTimeJob = true, FacultyId = "F1", Address = "Cluj"},
            new HomeStudent { FirstName = "Ethan", LastName = "Taylor", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2", Address = "Ermoclia" }
        };

        static List<Faculty> _faculties => new List<Faculty>
        {
            new Faculty { Id = "F1", Name = "Facultyy of Engineering", HeadMaster = "John Smith", Students = new() },
            new Faculty { Id = "F2", Name = "Facultyy of Medicine", HeadMaster = "Emily Johnson", Students = new() },
            new Faculty { Id = "F3", Name = "Facultyy of Arts", HeadMaster = "Michael Brown", Students = new() },
            new Faculty { Id = "F4", Name = "Facultyy of Business Administration", HeadMaster = "Jessica Lee" , Students = new()},
            new Faculty { Id = "F5", Name = "Facultyy of Science", HeadMaster = "David Williams" , Students = new()},
            new Faculty { Id = "F6", Name = "Facultyy of Law", HeadMaster = "Sophia Martinez", Students = new() },
            new Faculty { Id = "F7", Name = "Facultyy of Social Sciences", HeadMaster = "Matthew Wilson" , Students = new()},
            new Faculty
            {
                Id = "F8",
                Name = "Faculty of Education",
                HeadMaster = "Olivia Taylor",
                Students = new List<Student>
                {
                    new Student { FirstName = "John", LastName = "Smith", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F1" },
                    new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
                }
            },
            new Faculty
            {
                Id = "F9",
                Name = "Faculty of Information Technology",
                HeadMaster = "Daniel Anderson",
                Students = new List<Student>
                {
                    new Student { FirstName = "Michael", LastName = "Brown", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F3" },
                    new Student { FirstName = "David", LastName = "Miller", Age = 20, Year = 2022, HasAPartTimeJob = false, FacultyId = "F1" },
                }
            },
            new Faculty
            {
                Id = "F10",
                Name = "Faculty of Psychology",
                HeadMaster = "Ava Garcia",
                Students = new List<Student>
                {
                    new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
                    new Student { FirstName = "Ava", LastName = "Lee", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
                    new Student { FirstName = "Lucas", LastName = "Garcia", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F4" },
                }
            }
        };

        static void Print<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

static class StudentExtensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> students, Func<T, bool> predicate)
    {

        foreach (var student in students)
        {
            if (predicate(student))
            {
                yield return student;
            }
        }
    }


    public static double  CalculateAverageAge(this IEnumerable<Student> students)
    {
        if (students == null || !students.Any())
        {
            throw new ArgumentException("No students to calculate average age.");
        }

        int totalAge = 0;
        int studentCount = 0;

        foreach (var student in students)
        {
            totalAge += student.Age;
            studentCount++;
        }

        return (double)totalAge / studentCount;
    }
}
