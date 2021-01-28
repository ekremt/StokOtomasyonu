using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Entities
{
    [Table("Depo")]
    public class Depo
    {
        public int id { get; set; }
        public string depoAdi { get; set; }
        public string depoLokasyon { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}