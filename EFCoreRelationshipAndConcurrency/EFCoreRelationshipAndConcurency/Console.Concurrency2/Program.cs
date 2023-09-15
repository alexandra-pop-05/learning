using EFCore.Domain;
using EFCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;


using (var context = new EFCoreDbContext())
{
    try
    {
        var project = context.Projects.First();

        if (project != null)
        {
            Console.WriteLine($"Updating item {project.Id}");

            project.Description +="A   ";

            await context.SaveChangesAsync();

            Console.WriteLine("Project updated successfully.");
        }
        else
        {
            Console.WriteLine("Project not found.");
        }
    }
    catch (DbUpdateConcurrencyException ex)
    {
        Console.WriteLine($"Concurrency conflict: {ex.Message}");

        foreach (var entry in ex.Entries)
        {
            if (entry.Entity is Project conflictingProduct)
            {
                var databaseValues = entry.GetDatabaseValues();
                var projectDescription = databaseValues?["Description"];

                Console.WriteLine($"Current project description in database: {projectDescription}");
            }
        }
    }
}


