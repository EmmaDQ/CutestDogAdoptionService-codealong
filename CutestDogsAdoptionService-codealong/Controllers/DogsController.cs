using Microsoft.AspNetCore.Mvc;

namespace CutestDogsAdoptionService_codealong.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
