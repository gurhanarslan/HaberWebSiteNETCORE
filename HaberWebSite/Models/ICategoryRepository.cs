using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public interface ICategoryRepository
    {
        Category GetById(int categoryid);
        IQueryable<Category> getAll();
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryid);
    }
}
