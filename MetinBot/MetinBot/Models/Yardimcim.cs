using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetinBot.Models
{
    public class Yardimcim:DbContext
    {
        public DbSet<SoruCevap> Sorular { get; set; }
    }
}