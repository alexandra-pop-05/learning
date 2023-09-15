using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Student /*: IEquatable<Student>, IComparable<Student>*/
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public bool HasAPartTimeJob { get; set; }
        public string FacultyId { get; set; }

        public override string ToString()
        {
            string employmentStatus = HasAPartTimeJob ? "Employed" : "Not employed";
            return $"{FirstName} {LastName}, Age: {Age}, Year: {Year}, Employment Status: {employmentStatus}, Faculty ID: {FacultyId}";
        }

        /*public bool Equals(Student? other)
        {
            return FirstName == other.FirstName &&
                LastName == other.LastName;
        }
        public override int GetHashCode()
        {
            return
                FirstName.GetHashCode() ^
                LastName.GetHashCode();
        }*/

        /*public int CompareTo(Student? other)
        {
            return Age > other.Age ? 1 : -1;
        }*/


        //public int CompareTo(Student obj)
        //{
        //    return Age > obj.Age ? 1 : -1;
        //}
    }

    public class HomeStudent : Student
    {
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Address: {Address}";
        }
    }

    public class Faculty
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string HeadMaster { get; set; }

        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Faculty ID: {Id}, Name: {Name}, HeadMaster: {HeadMaster}";
        }
    }
}
