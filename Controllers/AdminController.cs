using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace midterm_encinasValador.Controllers
{
    [Authorize(Policy = "Owner only")]

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
