using System.Runtime.Serialization.Formatters;

namespace LinqOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("All Students: ");
            Print(_students);
            Console.WriteLine();*/

            Console.WriteLine("All Faculties: ");
            Print(_faculties);
            Console.WriteLine();
              Conversion();

            //ElementOperations();

             Aggregation();
            // Quantifiers();
            //Joins();
            
        }

        static void Filtering()
        {
            // Where => IEnumerable
            /*var studentsYoungerThan21 = _students.Where(student => student.Age <= 21);
            Console.WriteLine("Students younger than 21:");
            Print(studentsYoungerThan21);
            Console.WriteLine();
            Console.WriteLine("Students older than 21:");
            var studentsOlderThan21 = _students.Where(student => student.Age >= 21);
            Print(studentsOlderThan21);*/

            // Take => IEnumerable
            /* Console.WriteLine("First five students:");
             var first5Students = _students.Take(5);
             Print(first5Students);
             Console.WriteLine();*/

            //TakeLast
            /*Console.WriteLine("Last 2 students:");
            var last2Students = _students.TakeLast(2);
            Print(last2Students);*/

            // Skip
            /*Console.WriteLine();
            Console.WriteLine("All the students other than firs 2:");
            var allStudentsOtherThanFirst2Students = _students.Skip(2);
            Print(allStudentsOtherThanFirst2Students);*/

            // Take while
            /*Console.WriteLine();
            Console.WriteLine("First students older than 21:"); //until i meet one with age >=21
            var firstStudentsOlderThan21 = _students.TakeWhile(student => student.Age > 21);
            Print(firstStudentsOlderThan21);
*/
            // Skip while
            /*Console.WriteLine();
            Console.WriteLine("Skip students older than 21:"); //until i meet one with age <=21
            var skipStudentsOlderThan20 = _students.SkipWhile(student => student.Age > 20);
            Print(skipStudentsOlderThan20);*/

            // Distinct
            //using IEquatable<Student>.Equals for string - implemented in Student.cs
           /* Console.WriteLine();
            Console.WriteLine("Show all distinct students: ");
            var distinctStudents = _students.Distinct();
            Print(distinctStudents);*/
        }

        static void Projection()
        {
            // Select
            /*Console.WriteLine();
            Console.WriteLine("Students with their full name");
            var fullNameOfAllStudents = _students.Select(student => $"{student.FirstName} {student.LastName}");
            Print(fullNameOfAllStudents);*/

            // SelectMany
        /*    Console.WriteLine();
            Console.WriteLine("Students from each faculty: ");
            // Using SelectMany to flatten the list of students from all faculties
            var studentsFromEachFaculty = _faculties.SelectMany(faculty => faculty.Students);
            Print(studentsFromEachFaculty);
*/

        }

        static void Ordering()
        {
            // OrderBy
          /*  Console.WriteLine();
            Console.WriteLine("Students ordered by age ascending: ");
            var studentsByAge = _students.OrderBy(student => student.Age);
            Print(studentsByAge);*/

            // ThenBy
            /*Console.WriteLine();
            Console.WriteLine("Students ordered by age and FirstName: ");
            var studentsByAgeAndFirstName = _students.OrderBy(student => student.Age)
                                          .ThenBy(student => student.FirstName);
            Print(studentsByAgeAndFirstName);*/


            // OrderByDescending
            // ThenByDescending
            /*Console.WriteLine();
            Console.WriteLine("Students ordered by age and FirstName descending: ");
            var studentsByAgeAndFirstName2 = _students.OrderByDescending(student => student.Age)
                                          .ThenByDescending(student => student.FirstName);
            Print(studentsByAgeAndFirstName);
*/

            // Reverse
            /*Console.WriteLine();
            Console.WriteLine("Students reversed");
            var reversedStudents = _students.ToList();
            reversedStudents.Reverse();
            Print(reversedStudents);*/

        }

        static void Conversion()
        {
            // OfType
            /*Console.WriteLine("Students of type - Home Students: ");
            var homeStudents = _students.OfType<HomeStudent>();
            Print(homeStudents);*/

            // Cast
            /*Console.WriteLine("\nStudents age into double");
            var studentsAge = _students.Select(student => student.Age).Cast<float>().Cast<double>();
            Print(studentsAge);*/
            /*Console.WriteLine("\nStudents age into double");
            var studentsAge = _students.Select(student => (double)student.Age);
            Print(studentsAge);*/


            // ToArray
            /* Console.WriteLine("\nFaculties name into array");
             string[] facultiesName = _faculties.Select(faculty => faculty.Name).ToArray();
             Print(facultiesName);*/

            // ToList
            /*  Console.WriteLine("\nFaculties name into list");
              List<string> facultiesNameList = _faculties.Select(faculty => faculty.Name).ToList();
              Print(facultiesNameList);*/


            // ToDictionary
            /*Console.WriteLine("\nStudents as dictionary");
            var studentsDictionary = _students.ToDictionary(student => student.FirstName); //FirstName is the key
            foreach (var item in studentsDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }*/

            // ToLookup
            /* Console.WriteLine("\nStudents as lookup");
             var studentsLookup = _students.ToLookup(student => student.FacultyId); //FacultyId is the key
             foreach (var item in studentsLookup)
             {
                 Console.WriteLine($"Faculty ID: {item.Key}");
                 foreach (var student in item)
                 {
                     Console.WriteLine($"\t{student.FirstName} {student.LastName}");
                 }
             }*/


            // AsEnumerable
            /* Console.WriteLine("\nStudents as enumerable");
             var studentsAsEnumerable = _students.AsEnumerable();
             Print(studentsAsEnumerable);
 */

            // AsQueryable
           /* Console.WriteLine("\nStudents as queryable");
            var studentsAsQueryable = _students.AsQueryable();
            Print(studentsAsQueryable);*/

            //another example to understand
            //If I want to use First on a List directly it may throw an exception if the list is empty
            //So i use AsQueryable
            /*List<Student> people = new List<Student>();
            var firstStudentWithAge21 = people.First();
            Console.WriteLine(firstStudentWithAge21.ToString());*/


            /*var firstStudentWithAge21= _students.AsQueryable()
                                   .Where(student => student.Age == 21)
                                   .Select(student => student.FirstName)
                                   .First();
            Console.WriteLine(firstStudentWithAge21);*/

        }

        // All have immediate execution
        static void ElementOperations()
        {
            // First
             var firstStudent = _students.First();
             Console.WriteLine("First Student:");
             Console.WriteLine(firstStudent);

            /*var firstStudentWithAge21 = _students.AsQueryable()
                                   .Where(student => student.Age == 21)
                                   .Select(student => student.FirstName)
                                   .First();
            Console.WriteLine("First student with age = 21: "+ firstStudentWithAge21.ToString());*/

            // FirstOrDefault
            /*var firstOrDefaultStudent = _students.FirstOrDefault(student => student.Age > 28);
            Console.WriteLine("\nFirst Student Older Than 21:");
            Console.WriteLine(firstOrDefaultStudent);*/

            // Single
            /* Console.WriteLine();
             try
             {
                 var singleStudent = _students.Single(student => student.FirstName == "John");
                 Console.WriteLine("\nSingle Student Named John:");
                 Console.WriteLine(singleStudent);
             }
             catch (InvalidOperationException ex)
             {
                 Console.WriteLine("Error: " + ex.Message);
             }*/

            // SingleOrDefault
            /* var empty = Enumerable.Empty<Student>();
             var singleOrDefaultStudent = empty.SingleOrDefault(student => student.FirstName == "Emily");
             Console.WriteLine("\nSingle or Default Student Named Emily:");
             Console.WriteLine(singleOrDefaultStudent);*/

            // Last/LastOrDefault
            /*var lastStudent = _students.Last();
            Console.WriteLine("\nLast Student:");
            Console.WriteLine(lastStudent);

            var lastOrDefaultStudent = empty.LastOrDefault();
            Console.WriteLine("\nLast or default Student:");
            Console.WriteLine(lastOrDefaultStudent);*/

            // ElementAt/ElementAtOrDefault
            /*          var secondStudent = _students.ElementAt(1);
                      Console.WriteLine("\nSecond Student:"); //first is at index 0
                      Console.WriteLine(secondStudent);

                      var eleventhStudent = _students.ElementAt(11); // index out of range exception
                      Console.WriteLine("\nEleventh Student:");
                      Console.WriteLine(eleventhStudent);

                      var eleventhStudentOrDefault = _students.ElementAtOrDefault(11); //it will not throw an exception
                      Console.WriteLine("\nEleventh Student:");
                      Console.WriteLine(eleventhStudentOrDefault);*/

            // DefaultIfEmpty - if i have no students in the collection, i will provide the default student.
          /*  var emptyStudents = Enumerable.Empty<Student>();
            var defaultStudent = emptyStudents.DefaultIfEmpty(new Student { FirstName = "No Students", Age = -1 }).First();
            Console.WriteLine("\nDefault Student (if collection is empty):");
            Console.WriteLine(defaultStudent);*/
        }

        // All have immediate execution
        static void Aggregation()
        {
            // Count/LongCount
            Console.WriteLine("\nNumber of students: ");
            var numberOfStudents = _students.Count();
            Console.WriteLine(numberOfStudents);

            // Min/Max
            /*Console.WriteLine("\nYoungest student: ");
            var yougestStudent = _students.Min();
            Console.WriteLine(yougestStudent.ToString());

            Console.WriteLine("\nOldest student: ");
            var oldestStudent = _students.Max();
            Console.WriteLine(oldestStudent.ToString());*/

            // MinBy/MaxBy
            /*Console.WriteLine("\nStudent with minimum faculty id: ");
            var minimumIdStudent = _students.MinBy(student => student.FacultyId);
            Console.WriteLine(minimumIdStudent);

            Console.WriteLine("\nStudent with maximum faculty id: ");
            var maximumIdStudent = _students.MaxBy(student => student.FacultyId);
            Console.WriteLine(maximumIdStudent);*/

            // Sum/Average
            /*Console.WriteLine("\nTotal age of all students: ");
            var totalAge = _students.Sum(student => student.Age);
            Console.WriteLine(totalAge);

            Console.WriteLine("\nAverage age of all students: ");
            var averageAge = _students.Average(student => student.Age);
            Console.WriteLine(averageAge);*/
            // Aggregate
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var sum = numbers.Aggregate(0, (currentSum, number) => currentSum + number);
            Console.WriteLine(sum);

        }

        // All have immediate execution
        static void Quantifiers()
        {
            // Contains
            Console.WriteLine("\nFaculty name contains word 'rrr': ");
            var nameContainsWord = _faculties.Any(faculty => faculty.Name.Contains("rrr"));
            Console.WriteLine(nameContainsWord);

            // Any
            Console.WriteLine("\nCheck if any of the students has 21 years?: ");
            var has21Years = _students.Any(student => student.Age == 21);
            Console.WriteLine(has21Years);

            // All
            Console.WriteLine("\nCheck if all students have a FacultyId: ");
            var studentsHaveFacultyId = _students.All(student => student.FacultyId != null);
            Console.WriteLine(studentsHaveFacultyId);

            // SequenceEqual
            var _students1 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, FacultyId = "F2" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" }
            };

            var _students2 = new List<Student>
            {
                new Student { FirstName = "Johnn", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, FacultyId = "F2" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" }
            };

            bool areEqual = _students1.SequenceEqual(_students2);

            Console.WriteLine("The two students lists are equal -  " + areEqual);
        }

        static void SetOperations()
        {
            // Concat
            /* Console.WriteLine("Student's names and faculties:  ");
             var facultiesAndStudents = _students.Select(student => student.FirstName)
                                                  .Concat(_faculties.Select(faculty => faculty.Name));
             Print(facultiesAndStudents);*/

            // Union
            /*var _students1 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, FacultyId = "F2" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" }
            };

            var _students2 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
                new Student { FirstName = "Ava", LastName = "Lee", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
                new Student { FirstName = "Lucas", LastName = "Garcia", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F4" },
                new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
            };
            Console.WriteLine("Students union :  ");
            var union = _students1.Union(_students2);
            Print(union);*/

            // Intersect
            /*var _students1 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, FacultyId = "F2" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" }
            };

            var _students2 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" },
                new Student { FirstName = "Ava", LastName = "Lee", Age = 21, Year = 2021, HasAPartTimeJob = false, FacultyId = "F2" },
                new Student { FirstName = "Lucas", LastName = "Garcia", Age = 23, Year = 2019, HasAPartTimeJob = true, FacultyId = "F4" },
                new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
            };

            Console.WriteLine("Students intersection :  ");
            var intersection = _students1.Intersect(_students2);
            Print(intersection);*/

            // Except
            var _students1 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Emily", LastName = "Johnson", Age = 21, FacultyId = "F2" },
                new Student { FirstName = "Michael", LastName = "Brown", Age = 23, FacultyId = "F3" }
            };

            var _students2 = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Age = 22, FacultyId = "F1" },
                new Student { FirstName = "Oliver", LastName = "Wilson", Age = 22, Year = 2020, HasAPartTimeJob = true, FacultyId = "F3" },
            };

            Console.WriteLine("Students exception :  ");
            var exception = _students1.Except(_students2);
            Print(exception);
        }

        static void Joins()
        {
            // Join
            /*var faculties = new List<Faculty> { new Faculty { Id = "F1", Name = "Faculty of Engineering", HeadMaster = "John Smith", Students = new() },
            new Faculty { Id = "F2", Name = "Faculty of Medicine", HeadMaster = "Emily Johnson", Students = new() },
            new Faculty { Id = "F3", Name = "Faculty of Arts", HeadMaster = "Michael Brown", Students = new() },
            new Faculty { Id = "F4", Name = "Faculty of Business Administration", HeadMaster = "Jessica Lee" , Students = new()},
            new Faculty { Id = "F5", Name = "Faculty of Science", HeadMaster = "David Williams" , Students = new()},
            new Faculty { Id = "F6", Name = "Faculty of Law", HeadMaster = "Sophia Martinez", Students = new() },
            new Faculty { Id = "F7", Name = "Faculty of Social Sciences", HeadMaster = "Matthew Wilson" , Students = new()},};*/

            Console.WriteLine("\njoin Students with their faculties: ");
            var studentsAndFaculties = _students.Join(
                _faculties,
                student => student.FacultyId,
                faculty => faculty.Id,
                (student, faculty) => $"{student.FirstName} is at faculty {faculty.Name}"
            );

            Print(studentsAndFaculties);


            // GroupJoin
            /*Console.WriteLine("\nGroup join Students and faculties: ");
            var GroupJoinstudentsWithFaculties = _students.GroupJoin(_faculties,
                student => student.FacultyId,
                faculty => faculty.Id,
                (student, facultiesList) => new
                {
                    Faculties = facultiesList,
                    StudentsName = student.FirstName
                }
                );
            foreach (var item in GroupJoinstudentsWithFaculties)
            {
                Console.WriteLine(item.StudentsName);

                foreach (var faculty in item.Faculties)
                    Console.WriteLine(faculty.Name);
            }*/

            // Zip
           /* Console.WriteLine("\nZipping students and their faculties: ");
            var zippedStudentsAndFaculties = _students.Zip(
                _faculties,
                (student, faculty) => $"{student.FirstName} is at faculty {faculty.Name}"
            );

            Print(zippedStudentsAndFaculties);*/

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
