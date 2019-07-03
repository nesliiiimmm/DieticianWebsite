using System;
using System.Collections.Generic;

namespace DieticianWebSite.Models
{
    public partial class Yorum
    {
        public int Id { get; set; }
        public int? YorumId { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciAdi { get; set; }
        public string Icerik { get; set; }
        public byte? Yyb { get; set; }
    }
}
