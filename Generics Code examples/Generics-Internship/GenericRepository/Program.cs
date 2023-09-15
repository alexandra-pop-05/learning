using GenericRepository.Entities;
using GenericRepository.Repositories;

//Repo methods test
var studentRepository = new GenericRepository<Student>(Data.Students);

var student = studentRepository.GetById(1);
var students = studentRepository.GetAll();

studentRepository.Insert(new Student
{
    Id = 5,
    Name = "Ana Maria"
});

students = studentRepository.GetAll();

studentRepository.Update(new Student
{
    Id = 5,
    Name = "Ana Maria",
    Courses = new List<Course>
    {
        new Course
        {
            Id = 2,
            Name = "OOP Programming"
        }
    }
});

students = studentRepository.GetAll();

studentRepository.Delete(5);
students = studentRepository.GetAll();


//Same for CourseRepository