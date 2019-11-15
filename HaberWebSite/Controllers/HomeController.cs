using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HaberWebSite.Models;

namespace HaberWebSite.Controllers
{
    public class HomeController : Controller
    {
        private INewsRepository newsRepository;

        public HomeController(INewsRepository _newsRepository)
        {
            newsRepository = _newsRepository;
        }
        public IActionResult Index(int? id, string q)
        {
            var news = newsRepository.getAll().Where(i => i.IsApproved);
            if (id != null)
            {
                news = news.Where(i => i.CategoryId == id);
            }
            if (!string.IsNullOrEmpty(q))
            {
                news = news.Where(i => i.NewsTitle.Contains(q) || i.NewsDescription.Contains(q) || i.Body.Contains(q));
            }

            return View(news.OrderByDescending(i => i.NewsTime));
        }

    

    public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Spor()
        {
            return View(newsRepository.getAll().Where(i=>i.CategoryName=="Spor"));
        }
        public IActionResult Teknoloji()
        {
            return View(newsRepository.getAll().Where(i => i.CategoryName == "Teknoloji"));
        }
        public IActionResult TasarimInovasyon()
        {
            return View(newsRepository.getAll().Where(i => i.CategoryName == "Tasarım-İnovasyon"));
        }
        public IActionResult KulturSanat()
        {
            return View(newsRepository.getAll().Where(i => i.CategoryName == "Kültür-Sanat"));
        }
        public IActionResult Details(string title)
        {
            return View(newsRepository.GetByTitle(title));
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
