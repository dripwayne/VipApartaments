using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VipApartaments.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                //if (context.Instructors.Any())
                //{
                //    return; // dane już zostały dodane do bazy danych
                //}

                //var instructor = new Instructor()
                //{
                //    FirstName = "Michał",
                //    LastName = "Frontczak",
                //    Email = "mfrontczak@wsei.edu.pl",
                //    Title = "mgr"
                //};

                //context.Instructors.Add(instructor);
                //context.SaveChanges();

                /* do uzupełnienia */
            }
        } 
    
    }
}
