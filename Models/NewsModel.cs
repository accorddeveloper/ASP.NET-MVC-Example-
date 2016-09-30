using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class NewsModel
    {
        [Required(ErrorMessage = "Author field is required")]
        //[Author]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Title field is required")]
        //[Title]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "News field is required")]
        //[News]
        [Display(Name = "News")]
        public string News { get; set; }
    }


}

