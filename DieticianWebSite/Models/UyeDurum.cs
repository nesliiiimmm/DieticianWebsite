using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class UyeDurum
    {
        public int Id { get; set; }
        public int? UyeId { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? Kilo { get; set; }

        public Uye IdNavigation { get; set; }
    }
}
