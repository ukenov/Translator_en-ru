using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using TranslationService;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Translation model)
        {
            var translate = new Translator();
            var result = translate.Translate(model.InputTxt);

            model.CorectedLng = result.CorrectedResult;
            model.Result = result.Result;
            
            return View(model);
        }
    }
}
