using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext context;

        public EfCategoryRepository(ApplicationDbContext _context)
        {
            context = _context;
        }


        public void CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryid)
        {
            var abi = context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);
        }

        public IQueryable<Category> getAll()
        {
            return context.Categories;
        }

        public Category GetById(int categoryid)
        {
            return  context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);

        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
