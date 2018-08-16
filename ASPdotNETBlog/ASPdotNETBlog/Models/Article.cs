using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNETBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Name")]
        [StringLength(100,ErrorMessage ="Name is too long")]
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime date { get; set; }
        [Required(ErrorMessage = "Enter some text")]
        [AllowHtml]
        public string Text { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Category { get; set; }

        public Article()
        {
            Tags = new List<string>();
            Category = new List<string>();
            date = DateTime.Now;
        }
    }
}