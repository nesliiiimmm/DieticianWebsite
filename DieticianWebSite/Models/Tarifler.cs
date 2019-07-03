using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class Tarifler
    {
        public Tarifler()
        {
            TarifAsama = new HashSet<TarifAsama>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Icindekiler { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? Durum { get; set; }

        public ICollection<TarifAsama> TarifAsama { get; set; }
    }
}
