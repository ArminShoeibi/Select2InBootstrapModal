using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Select2InBootstrapModal.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Partial View
        public IActionResult CreateCategory()
        {
            var parentCategories = new[] 
            { 
                new { CategoryId = 1, Name = "C#" },
                new { CategoryId = 2, Name = "Javascript" },
                new { CategoryId = 3, Name = "Ruby" },
            }.ToList();

            ViewBag.ParentCategories = new SelectList(parentCategories, "CategoryId", "Name");
            return PartialView();
        }
    }
}
