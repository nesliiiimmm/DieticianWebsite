using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DieticianWebSite.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DieticianWebSite.Controllers
{
    public class SignInController : Controller
    {
        DieticianWebSiteContext db = new DieticianWebSiteContext();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Adi, string Soyadi, string email, string username, string Parola,
            string ParolaTekrar, bool CinsiyetKız, bool CinsiyetErkek, DateTime DogumTarihi, decimal Kilo,
            decimal Boy, string submitButton)
        {
            Uye u = new Uye();
            UyeGiris ug = new UyeGiris();

            u.Adi = Adi;
            u.Soyadi = Soyadi;
            u.Kilo = Kilo;
            u.Boy = Boy;
            //radio buttondan değer almaya bak...
            if (CinsiyetErkek == true)
                u.Cinsiyet = false;//çünkü yaşasın feminizimmmm :P:P:P
            else
                u.Cinsiyet = true;
            u.DogumTarihi = DogumTarihi;
            u.Tarih = DateTime.Now.ToShortDateString();
            db.Uye.Add(u);
            db.SaveChanges();
            ug.UyeId = u.Id;
            ug.KullaniciAdi = username;
            ug.Sifre = Parola;
            ug.IsActive = true;
            db.UyeGiris.Add(ug);
            db.SaveChanges();
            if (submitButton == "Kayit")
            {
                return RedirectToAction("Index", "Home");//üyenin girişi kabul edilerek ana sayfaya gitsin artık yorum yapabilir..
            }
            else
            {
                return RedirectToAction("Danisman","SignIn");//Danısman sayfasında üye işlemleri devam edicekkk
            }

        }
        [HttpGet]
        public IActionResult Danisman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Danisman(string Hastalik,string Hastalik2)
        {
            return View();
        }
    }
}
