using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class Uye
    {
        public Uye()
        {
            DanismaSoruları = new HashSet<DanismaSoruları>();
            DiyetProgrami = new HashSet<DiyetProgrami>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool? Cinsiyet { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Sehir { get; set; }
        public string Tarih { get; set; }
        public bool? MedeniDurum { get; set; }
        public string Meslek { get; set; }
        public decimal? Boy { get; set; }
        public decimal? Kilo { get; set; }
        public decimal? Bel { get; set; }
        public decimal? Kalca { get; set; }

        public UyeDurum UyeDurum { get; set; }
        public UyeGiris UyeGiris { get; set; }
        public ICollection<DanismaSoruları> DanismaSoruları { get; set; }
        public ICollection<DiyetProgrami> DiyetProgrami { get; set; }
    }
}
