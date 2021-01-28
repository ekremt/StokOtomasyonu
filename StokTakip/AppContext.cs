using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StokTakip
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("Name=AppContext")
        {

        }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<Admin> Admin { get; set; }

        public DbSet<Isyeri> Isyeri { get; set; }

        public DbSet<Depo> Depo { get; set; }
        public DbSet<Urun> Urun { get; set; }
    }
}