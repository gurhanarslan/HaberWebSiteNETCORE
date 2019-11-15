using HaberWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.ViewComponents
{
    public class SameNewsTIViewComponent : ViewComponent
    {
        private INewsRepository newsRepository;

        public SameNewsTIViewComponent(INewsRepository _newsRepository)
        {
            newsRepository = _newsRepository;
        }
        public IViewComponentResult Invoke(string NewsTitle)
        {

            return View(newsRepository.getAll().Where(i => i.CategoryName=="Tasarım-İnovasyon"));
        }
    }
}
