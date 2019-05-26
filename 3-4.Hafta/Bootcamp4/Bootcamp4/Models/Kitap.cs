using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootcamp4.Models
{
    public class Kitap
    {
        public int ID { get; set; }

        public string KitapAdi { get; set; }

        public int? SayfaSayisi { get; set; }

        public string YazarAdi { get; set; }


    }
}