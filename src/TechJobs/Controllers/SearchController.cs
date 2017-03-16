using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : TechJobsController
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            ViewBag.type = "all";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if (searchTerm == null)
            {
                ViewBag.type = searchType;
                ViewBag.error = "Please enter a search query.";
                return View("Index");
            }
            if (searchType == "all")
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            } else
            {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            ViewBag.search = searchTerm;
            ViewBag.type = searchType;
            ViewBag.error = "";
            return View("Index");
        }
    }
}
