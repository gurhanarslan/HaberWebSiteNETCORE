using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberWebSite.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string Body { get; set; }
        [BindNever]
        public DateTime NewsTime { get; set; }
        public bool IsApproved { get; set; }
        public bool IsSlide { get; set; }
        public string NewsAuthor { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string CategoryName { get; set; }
        public string ReadingTime { get; set; }
        public string SliderName { get; set; }
     
    }
}
