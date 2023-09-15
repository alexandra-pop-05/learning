using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private List<Student> Students;

        public StudentRepository()
        {
            Students = Data.Students;
        }

        public Student? GetById(int id) => Students.FirstOrDefault(s => s.Id == id);

        public List<Student> GetAll() => Students;

        public void Insert(Student student) => Students.Add(student);
        public void Update(Student student)
        {
            var studentIndex = Students.FindIndex(s => s.Id == student.Id);

            if (studentIndex < 0)
            {
                Console.WriteLine("Student not found");
            }

            Students[studentIndex] = student;
        }

        public void Delete(int id)
        {
            var studentIndex = Students.FindIndex(s => s.Id == id);

            if (studentIndex < 0)
            {
                Console.WriteLine("Student not found");
            }

            Students.RemoveAt(studentIndex);
        }

    }
}
