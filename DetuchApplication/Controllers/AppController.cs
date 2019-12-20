using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DetuchApplication.Services;
using DetuchApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DetuchApplication.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                //send email
                _mailService.SendMessage("moiza0799@gmail.com", model.Subject, $"From : {model.Name} - {model.Email}  Message{model.Message}");
                ViewBag.UserMesasge = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                //show the errors
            }
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
