using EFCore.Domain;
using EFCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using (var context = new EFCoreDbContext())
{
    var user = new User
    {
        Username="internship_02",
        Email = "intern2@gmail.com",
        Person = new Person
        {
            FirstName = "Cosmin",
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
    }

    Console.WriteLine($"User: {firstUser!.Username}, Person: {firstUser!.Person.FirstName}, {firstUser!.Person.LastName}");

    var existingPerson = context.Persons.Include(p => p.User).FirstOrDefault(d => d.FirstName == "Cosmin");

    if (existingPerson == null)
    {
        Console.WriteLine("No person found");
        return;
    }

    context.Remove(existingPerson);
    context.SaveChanges();

    Console.WriteLine($" Person: {existingPerson!.FirstName}, {existingPerson!.LastName} deleted");
}