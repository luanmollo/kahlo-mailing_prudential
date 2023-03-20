using Mailing.Helpers;
using Mailing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mailing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MailHelper mailHelper = new MailHelper();
            mailHelper.EnviarEmail("luanmollo@gmail.com", "prueba", "hola buen dia", "atencionalasegurado@prudential.com");
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