using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DieticianWebSite.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace DieticianWebSite.Controllers
{
    public class HomeController : Controller
    {
        DieticianWebSiteContext db = new DieticianWebSiteContext();
       
        public IActionResult Index()
        {

            IEnumerable<Tarifler> tarif = db.Tarifler;
            //IEnumerable<Makale> makale = mabc.Makale;
            //return View(Tuple.Create(kategori, makale));
            return View(tarif);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(string name, string email, string message)
        {
            var senderEmail = new MailAddress("e-mail", "Neslihan");
            var receiverEmail = new MailAddress(email, name);
            var password = "password";
            var sub = "Diyetisyen Sitesinden";
            var body = message;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = sub,
                Body = body

            })
            {
                smtp.Send(mess);
            }
            return RedirectToAction("Hakkimda");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Hakkimda()
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
