using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface ICourseRepository
    {
        public Course GetById(int id);
        public List<Course> GetAll();
        void Insert(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}
