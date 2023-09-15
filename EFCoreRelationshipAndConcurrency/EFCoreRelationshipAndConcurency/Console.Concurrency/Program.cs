using EFCore.Domain;
using EFCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SecondDomain;



    using (var context = new EFCoreDbContext())
    {
        

        try
        {
        
        var project = context.Projects.First();

        if (project != null)
            {
                Console.WriteLine($"Updating item {project.Id}...");

                // Simulate another user modifying the same product concurrently
                // This could be done in another session or process


                project.Description +="test";

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
                if (entry.Entity is Project conflictingProject)
                {
                    var databaseValues = entry.GetDatabaseValues();
                    var projectDescription = databaseValues["Description"];

                    Console.WriteLine($"Current project description in database: {projectDescription}");
                }
            }
        }
    }


