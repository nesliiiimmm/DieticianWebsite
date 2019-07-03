using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class DanismaSoruları
    {
        public int Id { get; set; }
        public int? UyeId { get; set; }
        public string Baslık { get; set; }
        public bool? Cevap { get; set; }
        public string Icerik { get; set; }
        public DateTime? Tarih { get; set; }

        public Uye Uye { get; set; }
    }
}
