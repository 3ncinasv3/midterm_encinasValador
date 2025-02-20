using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace midterm_encinasValador.Controllers
{
    [Authorize(Policy = "Buyer only")]

    public class Profile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
