using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.AddRange(

                    new Category() { CategoryName = "Category 1" },
                    new Category() { CategoryName = "Category 2" },
                    new Category() { CategoryName = "Category 3" }

                    );
                context.SaveChanges();
            }

           

            if (!context.News.Any())
            {
                context.AddRange(

                    new News() { NewsTitle = "Blog Title 11", NewsDescription = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", NewsTime = DateTime.Now.AddDays(-5), IsApproved = true, CategoryId = 1 },
                    new News() { NewsTitle = "Blog Title 21", NewsDescription = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", NewsTime = DateTime.Now.AddDays(-6), IsApproved = false, CategoryId = 1 },
                    new News() { NewsTitle = "Blog Title 31", NewsDescription = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", NewsTime = DateTime.Now.AddDays(-7), IsApproved = true, CategoryId = 1 },
                    new News() { NewsTitle = "Blog Title 41", NewsDescription = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", NewsTime = DateTime.Now.AddDays(-8), IsApproved = true, CategoryId = 1 },
                    new News() { NewsTitle = "Blog Title 51", NewsDescription = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", NewsTime = DateTime.Now.AddDays(-9), IsApproved = true, CategoryId = 1 }

                    );
                context.SaveChanges();

            }
        }

    }
}
