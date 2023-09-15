using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public class CourseRepository: ICourseRepository
    { 
       private List<Course> Courses;

        public CourseRepository()
        {
            Courses = Data.Courses;
        }

        public Course? GetById(int id) => Courses.FirstOrDefault(s => s.Id == id);

        public List<Course> GetAll() => Courses;

        public void Insert(Course course) => Courses.Add(course);
        public void Update(Course course)
        {
            var courseIndex = Courses.FindIndex(s => s.Id == course.Id);

            if (courseIndex < 0)
            {
                Console.WriteLine("Course not found");
            }

            Courses[courseIndex] = course;
        }

        public void Delete(int id)
        {
            var courseIndex = Courses.FindIndex(s => s.Id == id);

            if (courseIndex < 0)
            {
                Console.WriteLine("Course not found");
            }

            Courses.RemoveAt(courseIndex);
        }

    }
}
