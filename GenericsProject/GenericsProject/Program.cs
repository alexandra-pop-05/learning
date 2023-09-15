using GenericsProject.Entities;
using GenericsProject.Repositories;
using GenericsProject.Services;

namespace GenericsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Repo methods test

            //USERS
           // var userRepository = new GenericRepository<Users>(Data.Users);
           var userRepository = new UserRepository();

            //get user by id
            var user = userRepository.GetById(1);
            if (user != null)
            {
                Console.WriteLine(user.ToString());
            }
            else
            {
                Console.WriteLine("User not found!");
            }


            //insert user
            userRepository.Insert(new Users
            {
                Id = 4,
                Nickname = "Oleon Raul",
                Birthday = new DateTime(1999, 10, 05)

            });

            //update user
            userRepository.Update(new Users
            {
                Id = 4,
                Nickname = "Oleon Raul Marian",
                Birthday = new DateTime(1999, 10, 05)
            });


            //get all users
            var users = userRepository.GetAll();
            foreach (var u in users)
            {
                Console.WriteLine(u.ToString());
            }

            //USER SERVICE 
            // Create a UserRepository instance

            // Create a UserService instance and pass the UserRepository
            var userService = new UserService(userRepository);

            // Get all users using UserService
            var allUsersFromService = userService.GetAllUsers();
            foreach (var u in allUsersFromService)
            {
                Console.WriteLine(u.ToString());
            }

            // Get users by nickname using UserService
            string nickname = "Popescu Andrei";
            var userByNickname = userService.GetUserByNickname(nickname);
            if (userByNickname != null)
            {
                Console.WriteLine("The user is: ");
                Console.WriteLine(userByNickname.ToString());
            }
            else
            {
                Console.WriteLine($"User with nickname \"{nickname}\" not found!");
            }




            //PROJECTS
            Console.WriteLine("\n");
            var projectRepository = new ProjectRepository();
            var projectService = new ProjectService(projectRepository);

            //get project by id
            var project = projectService.GetById(1);
            if (project != null)
            {
                Console.WriteLine(project.ToString());
            }
            else
            {
                Console.WriteLine("Project not found!");
            }

            //Insert project
            projectService.AddProject(new Project{
                Id= 5,
                ProjectName="New Project",
                ProjectStatus= "In Progress"
            }) ;

            //get all projects
            var projects = projectService.GetAllProjects();
            Console.WriteLine("Projects: ");
            foreach (var p in projects)
            {
                Console.WriteLine(p.ToString());
            }

            //get status 
            string projectName = "Goodleap";
            var getProjectStatus = projectService.GetProjectStatus(projectName);
            if (getProjectStatus != null)
            {
                Console.WriteLine($"The project \"{projectName}\" status is: ");
                Console.WriteLine(getProjectStatus.ToString());
            }
            else
            {
                Console.WriteLine($"Project with name \"{projectName}\" not found!");
            }

        }
    }
}