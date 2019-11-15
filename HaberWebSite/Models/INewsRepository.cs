using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public interface INewsRepository
    {
        IQueryable<News> getAll();
        News GetById(int newsid);
        News GetByTitle(string newstitle);
        void CreateNews(News news);
        void UpdateNews(News news);
        void DeleteNews(int newsid);
    }
}
