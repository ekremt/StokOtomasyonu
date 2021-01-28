using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Entities
{
    [Table("Urun")]
    public class Urun
    {
        public int id { get; set; }
        public string urunAdi { get; set; }
        public string urunModel { get; set; }
        public string urunSeriNo { get; set; }
        public DateTime urunTarihi { get; set; } 
        public float urunFiyati { get; set; }
        public int isyeriId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}