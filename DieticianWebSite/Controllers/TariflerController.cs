using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DieticianWebSite.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DieticianWebSite.Controllers
{
    public class TariflerController : Controller
    {
        static int deneme { get; set; }
        DieticianWebSiteContext db = new DieticianWebSiteContext();
        

        public IActionResult Index()//tarifler listeleniyor
        {
            
            return View(db.Tarifler.ToList());
            
        }   
        public IActionResult TarifSil(int id)//tarif sil
        {
            db.Tarifler.Remove(db.Tarifler.Find(id));
            db.SaveChanges();
            return View("Index", db.Tarifler.ToList());
           
        }
        [HttpGet]
        public IActionResult AddTarif()//yeni tarif
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTarif(Tarifler tarif)
        {
            tarif.Tarih = DateTime.Now;
            tarif.Durum = true;
            db.Tarifler.Add(tarif);
            db.SaveChanges();
            return View("Index",db.Tarifler.ToList());
            
        }
        [HttpGet]
      public IActionResult TarifGüncelle(int? id)
        {
            if (id == null)
            {
                return null;
            }
            Tarifler tarif = db.Tarifler.Find(id);
            if (tarif == null)
            {
                return null;
            }
            return View(tarif);
        }
        [HttpPost]
        public IActionResult TarifGüncelle(Tarifler yenitarif)
        {
            Tarifler güncel = db.Tarifler.Find(yenitarif.Id);
            if (yenitarif != null)
            {
                güncel.Adi = yenitarif.Adi;
                güncel.Icindekiler = yenitarif.Icindekiler;
                güncel.Aciklama = yenitarif.Aciklama;
                güncel.Tarih=DateTime.Now;
                güncel.Durum = yenitarif.Durum;
                db.SaveChanges();
                return View("Index", db.Tarifler.ToList());
            }
            else
            {
                return null;
            }

        }
        public IActionResult TarifDetay( Tarifler detayGelen)
        {
             ViewModel Tarifler = new ViewModel();
          
           Tarifler.Tarif = db.Tarifler.Find(detayGelen.Id);
            deneme = detayGelen.Id;
            //ViewBag.Id = detayGelen.Id;
            //Tarifler.Yorum.YorumId.Equals( detayGelen.Id);
            return View("TarifDetay",Tarifler);         
            
        }

        [HttpGet]
        public IActionResult commentYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult commentYap(Yorum yorum)
        {   //yorum.YorumId = deneme;
            //foreach (var yorumcuk in db.Yorum.ToList())
            //{
                
            //}
            //yorum.Yorum.Yyb = 1;
            db.Yorum.Add(yorum);
            db.SaveChanges();
            ViewModel tarif = new ViewModel();
            tarif.Tarif = db.Tarifler.Find(yorum.YorumId);            
            return View("TarifDetay",tarif);
        }

    }
}