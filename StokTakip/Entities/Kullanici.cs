using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Entities
{
    [Table("Kullanici")]
    public class Kullanici
    {
        public int id { get; set; }

        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public int isyeriId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}