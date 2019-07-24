using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            this._mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Get solictar info 
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //ViewBag.Title = "Contact Us";
            //throw new InvalidOperationException("Bad thing happen"); //no se usa, se debe hacer por la carpeta Pages Error.cshtml y para que sirve debe estar _ViewStart.cshtml

            return View();
        }

        //Post enviar info
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            //ViewBag.Title = "Contact Us"; //esto no se hace aquí, se hace en contact.cshtml @{ViewBag.Title=""} 

            if (ModelState.IsValid)
            {
                //Send the email
                _mailService.SendMessage(
                    "daya@gmail.com", 
                    model.Subject, 
                    $"From: {model.Name} - { model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Send";
                ModelState.Clear();
            }
            //else
            //{
            //    //Show the errors
            //}

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
