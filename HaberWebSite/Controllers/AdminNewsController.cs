using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HaberWebSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HaberWebSite.Controllers
{
    [Authorize]
    public class AdminNewsController : Controller
    {
        private INewsRepository newsRepository;
        private ICategoryRepository categoryRepository;

        public AdminNewsController(INewsRepository _newsRepository, ICategoryRepository _categoryRepository)
        {
            newsRepository = _newsRepository;
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            
            return View(newsRepository.getAll().Where(i=>i.IsSlide==false && i.IsApproved==true));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryRepository.getAll(), "CategoryId", "CategoryName");

            return View();
        }
        public IActionResult IsNotApproved()
        {

            return View(newsRepository.getAll().Where(i => i.IsSlide == false && i.IsApproved == false));
        }


        [HttpPost]
        public IActionResult Create(News news)
        {
            news.NewsTime = DateTime.Now;
            if (ModelState.IsValid)
            {
                newsRepository.CreateNews(news);
                return RedirectToAction("Index");
            }
            return View(news);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            
                    newsRepository.DeleteNews(id);
                    return RedirectToAction("Index");
 
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.getAll(), "CategoryId", "CategoryName");

            return View(newsRepository.GetById(id));
        }
        public IActionResult All()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Update(News blog, IFormFile file)
        {

            blog.NewsTime = DateTime.Now;
            if (ModelState.IsValid)
            {

                if (file != null)
                {


                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    blog.Image = file.FileName;
                }
                newsRepository.UpdateNews(blog);
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");
        }

    }
}