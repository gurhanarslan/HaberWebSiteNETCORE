using HaberWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.ViewComponents
{
    public class SameNewsKSViewComponent : ViewComponent
    {
        private INewsRepository newsRepository;

        public SameNewsKSViewComponent(INewsRepository _newsRepository)
        {
            newsRepository = _newsRepository;
        }
        public IViewComponentResult Invoke(string NewsTitle)
        {

            return View(newsRepository.getAll().Where(i => i.CategoryName=="Kültür-Sanat"));
        }
    }
}
