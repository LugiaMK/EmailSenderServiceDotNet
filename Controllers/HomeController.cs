using EmailService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailService.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "myemail@gmail.com";
            var subject = "Subject";
            var message = "Hello World";

            await _emailSender.SendEmailAsync(receiver, subject, message);
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