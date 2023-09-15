using GenericRepository.Entities;
using GenericRepository.Repositories;

namespace GenericRepository.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> GetStudentsByName(string name)
        {
            return _studentRepository.GetAll().Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
