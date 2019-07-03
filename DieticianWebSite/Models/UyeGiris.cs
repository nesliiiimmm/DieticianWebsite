using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class UyeGiris
    {
        public int UyeId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool? IsActive { get; set; }

        public Uye Uye { get; set; }
    }
}
