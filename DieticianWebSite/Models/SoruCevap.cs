using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class SoruCevap
    {
        public SoruCevap()
        {
            InverseSoruCevapNavigation = new HashSet<SoruCevap>();
        }

        public int Id { get; set; }
        public int? SoruCevapId { get; set; }
        public int? UyeId { get; set; }
        public string UserName { get; set; }
        public string Icerik { get; set; }
        public bool? SoruMuCevapMi { get; set; }
        public bool? Durum { get; set; }

        public SoruCevap SoruCevapNavigation { get; set; }
        public ICollection<SoruCevap> InverseSoruCevapNavigation { get; set; }
    }
}
