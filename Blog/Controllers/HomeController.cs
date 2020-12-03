using Blog.BusinessManagers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogBusinessManager blogBusinessManager;
        public HomeController(IBlogBusinessManager blogBusinessManager)
        {
            this.blogBusinessManager = blogBusinessManager;
        }

        public IActionResult Index(string searchString, int? page)
        {
            return View(blogBusinessManager.GetIndexViewModel(searchString, page));
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
