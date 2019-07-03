using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class DiyetProgrami
    {
        public int Id { get; set; }
        public int? UyeId { get; set; }
        public string Pdf { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? HaftalikMiAylikMi { get; set; }

        public Uye Uye { get; set; }
    }
}
