using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Entities
{
    [Table("Isyeri")]
    public class Isyeri
    {
        public int id { get; set; }
        public string isyeriAdi { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}