using AssimentMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssimentMVC1.Controllers
{
   
    public class HomeController : Controller
    {

        #region
        [HttpGet("Json")]
         public IActionResult JsonAction()
        {
            return Json("Hello from Json Action ");
        }
        #endregion


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
