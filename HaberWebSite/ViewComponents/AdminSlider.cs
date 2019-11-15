using HaberWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.ViewComponents
{
    public class AdminSlider : ViewComponent
    {
        private INewsRepository newsRepository;

        public AdminSlider(INewsRepository _newsRepository)
        {
            newsRepository= _newsRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(newsRepository.getAll().Where(i => i.IsSlide));
        }
    }
}
