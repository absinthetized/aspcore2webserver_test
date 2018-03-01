using Microsoft.AspNetCore.Mvc;

namespace aspcore2webserver_test.Controllers {
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() { return View(); }
    }
}
