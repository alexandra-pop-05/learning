using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface IStudentRepository
    {
        public Student GetById(int id);
        public List<Student> GetAll();
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
