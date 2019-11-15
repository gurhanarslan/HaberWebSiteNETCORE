using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public class EfNewsRepository : INewsRepository
    {
        private ApplicationDbContext context;

        public EfNewsRepository(ApplicationDbContext _context)
        {
            context = _context;
        }



        public void CreateNews(News news)
        {
            context.News.Add(news);
            context.SaveChanges();
        }

        public void DeleteNews(int newsid)
        {
            var abi = context.News.FirstOrDefault(i => i.NewsId == newsid);
            if(context != null)
            {
                context.News.Remove(abi);
                context.SaveChanges();
            }
        }

        public IQueryable<News> getAll()
        {
            return context.News;
        }

        public News GetById(int newsid)
        {
            return context.News.FirstOrDefault(i => i.NewsId == newsid);

        }

        public News GetByTitle(string newstitle)
        {
            return context.News.FirstOrDefault(i => i.NewsTitle == newstitle);
        }

        public void UpdateNews(News news)
        {
            context.News.Update(news);
            context.SaveChanges();
        }
    }
}
