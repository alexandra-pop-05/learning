namespace GenericRepository.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
