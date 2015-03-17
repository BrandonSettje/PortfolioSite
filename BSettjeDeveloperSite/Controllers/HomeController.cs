using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace BSettjeDeveloperSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string name, string email, string message)
        {
            //Add the form to the DB
          
            var messagebody = new MailMessage("BSettjeSeedPaths@sedpaths.com", "brandon.settje@gmail.com");
            var client = new SmtpClient("mail.dustinkraft.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1")
            };
            messagebody.Subject = "Someone is trying to contact you from SeedPaths!";
            messagebody.Body = name + " says: " + message + " from: " + email;
            client.Send(messagebody);
            ViewBag.Message = "Thank you for contact me! I will get back to you shortly!";
            return View();
        }
    }
}