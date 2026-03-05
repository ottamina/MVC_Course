using BTKAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTKAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost] //bunun bir post oldugunu soyluyoz
        [ValidateAntiForgeryToken] //guvenlik icin token ekliyoruz
        public IActionResult Apply([FromForm] Candidate model) //fromform bunun formdan geldigini soyluyoruz
        {

            if (Repository.Applications.Any(c => c.Email == model.Email)) //email daha once kullanilmissa hata veriyoruz
            {
                ModelState.AddModelError("", "This email is already used");
            }

            if (ModelState.IsValid) //modelstate valid degilse tekrar apply sayfasina gonderiyoruz
            {
                Repository.Add(model);
                return View("Feedback", model);

            }

            return View(model);
        }
    }
}