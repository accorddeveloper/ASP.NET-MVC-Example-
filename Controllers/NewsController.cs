using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using PagedList;

namespace WebApplication2.Controllers
{
    public class NewsController : Controller
    {
        private static int MaxNumberOfNews = 50;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        // POST: News
        [HttpPost]
        public ActionResult News([Bind(Include = "Author, Title, News")]NewsModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (MvcApplication.optionList.Count < MaxNumberOfNews)
                    {
                        MvcApplication.optionList.Add(collection);
                        return RedirectToAction("News");
                    }
                    else
                    {
                        ModelState.AddModelError("CustomError", "Maximum number of News is reached.");
                        return View();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
            
        }
    }
}
