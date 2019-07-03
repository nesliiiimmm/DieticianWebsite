using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class TarifAsama
    {
        public int Id { get; set; }
        public int? TarifId { get; set; }
        public int? Sira { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }

        public Tarifler Tarif { get; set; }
    }
}
