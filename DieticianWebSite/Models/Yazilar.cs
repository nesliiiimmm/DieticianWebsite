using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class Yazilar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? Durum { get; set; }
    }
}
