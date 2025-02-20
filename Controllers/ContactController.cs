using Microsoft.AspNetCore.Mvc;
using midterm_encinasValador.Models;

namespace midterm_encinasValador.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactForm model)
        {
            if (ModelState.IsValid)
            {


                TempData["SuccessMessage"] = "Thank you for your message! We'll get back to you soon.";
                return RedirectToAction(nameof(Index));
            }


            return View(model);
        }
    }
}
