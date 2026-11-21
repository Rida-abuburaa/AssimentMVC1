using AssimentMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssimentMVC1.Controllers
{
    [Route("Pord")]
    public class ProductController : Controller
    {
        #region Routing
        [HttpGet("Json")]
        public IActionResult JsonAction()
        {
            return Json("Hello from Json Action ");
        }
        #endregion
        #region Model Binding 

        public IActionResult Serch(ProductFiltter filter)
        {
            return View();

        }

        public IActionResult GetbyId( [FromQuery]int Id , [FromQuery (Name = "Id2")]int otherId)
        {
            return Json("");

        }
        #endregion
       
    }
}
