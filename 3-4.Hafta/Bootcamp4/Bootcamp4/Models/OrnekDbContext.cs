using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bootcamp4.Models
{
    public class OrnekDbContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }

        public DbSet<Kullanicilar> Kullanici { get; set; }
    }
}