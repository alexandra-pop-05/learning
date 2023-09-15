using EFCoreRelationships;
using EFCoreRelationships.Entities;
using Microsoft.EntityFrameworkCore;

using (var context = new EFCoreDbContext())
{
    /*var user = new User
    {
        Username = "internship_03",
        Email = "intern31@gmail.com",
        Person = new Person
        {
            FirstName = "Cosminw3",
            LastName = "F",
            Address = "Brasov",

        }
    };

    context.Users.Add(user);
    context.SaveChanges();

    var firstUser = context.Users.Include(p => p.Person).FirstOrDefault();

    if (firstUser == null)
    {
        Console.WriteLine("No user found");
        return;
    }*/

    var project = new Project
    {
        Name = "project1",
        Description = "HELLO",
        
    };

    context.Projects.Add(project);
    context.SaveChanges();

    var firstProject = context.Projects.FirstOrDefault();

    if (firstProject == null)
    {
        Console.WriteLine("No project found");
        return;
    }
    Console.WriteLine($"Project: {firstProject!.Name}, {firstProject!.Description}");

    /*var existingPerson = context.Persons.Include(p => p.User).FirstOrDefault(d => d.FirstName == "Cosminw");

    if (existingPerson == null)
    {
        Console.WriteLine("No person found");
        return;
    }

    context.Remove(existingPerson);
    context.SaveChanges();

    Console.WriteLine($" Person: {existingPerson!.FirstName}, {existingPerson!.LastName} deleted");*/
    var existingProject = context.Projects.FirstOrDefault(d => d.Name == "project1");

    if (existingProject == null)
    {
        Console.WriteLine("No project found");
        return;
    }

    context.Remove(existingProject);
    context.SaveChanges();

    Console.WriteLine($" Project: {existingProject!.Name}, {existingProject!.Description} deleted");
}