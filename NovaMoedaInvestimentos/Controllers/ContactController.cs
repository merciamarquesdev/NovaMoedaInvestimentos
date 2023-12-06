using Microsoft.AspNetCore.Mvc;

namespace NovaMoedaInvestimentos.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
