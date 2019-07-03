using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DieticianWebSite.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DieticianWebSite.Controllers
{
    public class SignUpController : Controller
    {
        DieticianWebSiteContext db = new DieticianWebSiteContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email,string password)
        {
            if (email == null)
            {
                ViewBag.ErrorMessage = "Lütfen kullanici adini giriniz..";
                return View();
            }
            else if (password==null)
            {
                ViewBag.ErrorMessage = "Lütfen şifrenizi giriniz adini giriniz..";
                return View();
            }
            else if (db.UyeGiris.Where(i => i.KullaniciAdi == email && i.Sifre == password).Any())
            {
                //var giris = db.UyeGiris.FirstOrDefault(i => i.KullaniciAdi == email && i.Sifre == password);
                //burda birşeyleri aktif yapıcaz girebilecek veya giremeyecek...
                return RedirectToAction("Index", "Home");//burdan tekrar online diyet veya soru-cevap sayfasına gidecek..
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı Adı veya Sifreniz yanlış..";
                return View();
            }
            
        }
    }
}
