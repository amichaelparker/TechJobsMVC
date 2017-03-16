using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        internal static List<string> actionChoices = new List<string>();

        static TechJobsController()
        {
            actionChoices.Add("Search");
            actionChoices.Add("List");
        }

        public override ViewResult View()
        {
            ViewBag.actions = actionChoices;
            return base.View();
        }

        public override ViewResult View(string url)
        {
            ViewBag.actions = actionChoices;
            return base.View(url);
        }
    }
}
