using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StokTakip.Entities
{
    [Table("Stok")]
    public class Stok
    {
        public int id { get; set; }
        public int stokAdedi { get; set; }
        public int urunId { get; set; }
        public int depoId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

}
}