using System.Collections.Generic;
using System.Web.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("List");
            }

            return View(feedback);
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}