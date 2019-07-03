using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DieticianWebSite.Models;

namespace DieticianWebSite.Controllers
{
    public class YazilarsController : Controller
    {
        DieticianWebSiteContext Db = new DieticianWebSiteContext();

        public IActionResult Index(string q)
        {    var yazi = Db.Yazilar
                             .OrderByDescending(i=>i.Tarih)
                 
                             .Select(i => new Yazilar
                             {
                                 Id = i.Id,
                                 Icerik = i.Icerik.Length > 100 ? i.Icerik.Substring(0, 100) + "..." : i.Icerik,
                                 Adi = i.Adi,
                                 Tarih = i.Tarih,
                                 Durum=i.Durum,
                                 Resim = i.Resim
                                
                             }).AsQueryable();
            if (string.IsNullOrEmpty(q)==false) // boş değilse
            {
                yazi = yazi.Where(i => i.Adi.Contains(q) || i.Icerik.Contains(q));


            }


            return View(yazi.ToList());

        }

        public IActionResult Create()
        {
            
            return View(new Yazilar());
        }

        [HttpPost]
        public IActionResult Create(Yazilar yazi)
        {
            yazi.Tarih = DateTime.Now.Date;
            yazi.Durum = true;
            Db.Yazilar.Add(yazi);
            Db.SaveChanges();
            return RedirectToAction("Index","Yazilars");
        }


        public IActionResult Delete(int id)
        {

            Db.Yazilar.Remove(Db.Yazilar.Find(id));
            Db.SaveChanges();
            return View("Index", Db.Yazilar.ToList());

        }
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return View("Error");
            }
            Yazilar yazi = Db.Yazilar.Find(id);
            if (yazi == null)
            {
                return View("Error");
            }
           
            return View(yazi);

        }
        [HttpPost]
        public IActionResult Edit(Yazilar yeniyazi)
        {
            Yazilar son = Db.Yazilar.Find(yeniyazi.Id);
            if (yeniyazi!= null)
            {
                son.Adi = yeniyazi.Adi;
                son.Icerik = yeniyazi.Icerik;
                son.Resim = yeniyazi.Resim;
                son.Tarih = DateTime.Now.Date; 
                Db.SaveChanges();
                return View("Index", Db.Yazilar.ToList());
            }
            else
            {
                return null;
            }

        }
        
            public ActionResult Details(int? id)
            {
                    
                Yazilar yazi = Db.Yazilar.Find(id);
                if (yazi == null)
                {
                return View("Error");
                }
                return View(yazi);
            }
        

        [HttpPost]
        public IActionResult Comment(string Icerik,int UyeId)
        {
            DanismaSoruları soru = new DanismaSoruları();
            soru.UyeId = UyeId;
            soru.Icerik = Icerik;
            soru.Tarih = DateTime.Now;
            Db.SaveChanges();


            return RedirectToAction("","");
           
        }







    }
    
}
