using HaftaCode.Models.Tablolarim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaftaCode.Models.Veritabanim
{
    public class Yardimci:DbContext
    {
        public DbSet<ilac> ilaclar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
    }
}