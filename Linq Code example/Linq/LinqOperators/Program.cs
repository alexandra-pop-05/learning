namespace LinqOperators
{
    public class Program
    {
        public static void Main()
        {

        }

        static void Filtering()
        {
            // Where
            //var studentsYoungerThan21 = _students.Where(student => student.Age <= 21);
            //Print(studentsYoungerThan21);

            // Take
            //var first5Students = _students.Take(5);
            //Print(first5Students);

            // Skip
            //var allStudentsOtherThanFirst5Students = _students.Skip(2);
            //Print(allStudentsOtherThanFirst5Students);

            // Take while
            //var firstStudentsOlderThan20 = _students.TakeWhile(student => student.Age > 20);
            //Print(firstStudentsOlderThan20);

            // Skip while
            //var skipStudentsOlderThan20 = _students.SkipWhile(student => student.Age > 20);
            //Print(skipStudentsOlderThan20);

            // Distinct
            //var distinctStudents = _students.Distinct();
            //Print(distinctStudents);
        }

        static void Projection()
        {
            // Select

            // SelectMany
        }

        static void Ordering()
        {
            // OrderBy

            // ThenBy

            // OrderByDescending

            // ThenByDescending

            // Reverse
        }

        static void Conversion()
        {
            // OfType

            // Cast

            // ToArray

            // ToList

            // ToDictionary

            // ToLookup

            // AsEnumerable

            // AsQueryable
        }

        // All have immediate execution
        static void ElementOperations()
        {
            // First 

            // FirstOrDefault

            // Single

            // SingleOrDefault

            // Last/LastOrDefault

            // ElementAt/ElementAtOrDefault

            // DefaultIfEmpty
        }

        // All have immediate execution
        static void Aggregation()
        {
            // Count/LongCount
            //var numberOfStudents = _students.Count();
            //Console.WriteLine(numberOfStudents);

            // Min/Max
            //var yougestStudent = _students.Min();
            //Console.WriteLine(yougestStudent.ToString());

            //var oldestStudent = _students.Max();
            //Console.WriteLine(oldestStudent.ToString());

            // MinBy/MaxBy
            //var yougestStudent2 = _students.MinBy(student => student.Age);
            //Console.WriteLine(yougestStudent2);

            //var oldestStudent2 = _students.MaxBy(student => student.Age);
            //Console.WriteLine(oldestStudent2);

            // Sum/Average

            // Aggregate
        }

        // All have immediate execution
        static void Quantifiers()
        {
            // Contains

            // Any

            // All

            // SequenceEqual
        }

        static void SetOperations()
        {
            // Concat

            // Union

            // Intersect

            // Except
        }

        static void Joins()
        {
            // Join
            //var faculties = new List<Faculty> { new Faculty { Id = "F1", Name = "Faculty of Engineering", HeadMaster = "John Smith", Students = new() },
            //new Faculty { Id = "F2", Name = "Faculty of Medicine", HeadMaster = "Emily Johnson", Students = new() },
            //new Faculty { Id = "F3", Name = "Faculty of Arts", HeadMaster = "Michael Brown", Students = new() },
            //new Faculty { Id = "F4", Name = "Faculty of Business Administration", HeadMaster = "Jessica Lee" , Students = new()},
            //new Faculty { Id = "F5", Name = "Faculty of Science", HeadMaster = "David Williams" , Students = new()},
            //new Faculty { Id = "F6", Name = "Faculty of Law", HeadMaster = "Sophia Martinez", Students = new() },
            //new Faculty { Id = "F7", Name = "Faculty of Social Sciences", HeadMaster = "Matthew Wilson" , Students = new()},};

            //var studentsAndFaculties = _students.Join(
            //    faculties,
            //    student => student.FacultyId,
            //    faculty => faculty.Id,
            //    (student, faculty) => $"{student.FirstName} is at faculty {faculty.Name}"
            //);

            //Print(studentsAndFaculties);


            // GroupJoin

            // Zip
        }

        static void Grouping()
        {
            // Group by
            var groupedStudents = _students.GroupBy(student => student.HasAPartTimeJob);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Have part time job: {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName} - Has part time job? - {student.HasAPartTimeJob}");
                }
            }
        }

        static List<Student> _students => new List<Student>
        {
            new Student { FirstName = "John", LastName = "Smith", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F1" },
            new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
            new Student { FirstName = "Michael", LastName = "Brown", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F3" },
            new Student { FirstName = "David", LastName = "Miller", Age = 20, Year = 2022, HasAPartTimeJob = false, FacultyId = "F1" },
            new Student { FirstName = "Sophia", LastName = "Davis", Age = 24, Year = 2018, HasAPartTimeJob = true, FacultyId = "F4" },
            new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
            new Student { FirstName = "Ava", LastName = "Lee", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
            new Student { FirstName = "David", LastName = "Miller", Age = 19, Year = 2022, HasAPartTimeJob = false, FacultyId = "F1" },
            new Student { FirstName = "Lucas", LastName = "Garcia", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F4" },
            new HomeStudent { FirstName = "Isabella", LastName = "Martinez", Age = 15, Year = 2020, HasAPartTimeJob = true, FacultyId = "F1", Address = "Cluj"},
            new HomeStudent { FirstName = "Ethan", LastName = "Taylor", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2", Address = "Ermoclia" }
        };

        static List<Faculty> _faculties => new List<Faculty>
        {
            new Faculty { Id = "F1", Name = "Faculty of Engineering", HeadMaster = "John Smith", Students = new() },
            new Faculty { Id = "F2", Name = "Faculty of Medicine", HeadMaster = "Emily Johnson", Students = new() },
            new Faculty { Id = "F3", Name = "Faculty of Arts", HeadMaster = "Michael Brown", Students = new() },
            new Faculty { Id = "F4", Name = "Faculty of Business Administration", HeadMaster = "Jessica Lee" , Students = new()},
            new Faculty { Id = "F5", Name = "Faculty of Science", HeadMaster = "David Williams" , Students = new()},
            new Faculty { Id = "F6", Name = "Faculty of Law", HeadMaster = "Sophia Martinez", Students = new() },
            new Faculty { Id = "F7", Name = "Faculty of Social Sciences", HeadMaster = "Matthew Wilson" , Students = new()},
            new Faculty
            {
                Id = "F8",
                Name = "Faculty of Education",
                HeadMaster = "Olivia Taylor",
                Students =
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
                Students =
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
                Students =
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

