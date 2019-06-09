using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaftaCode.Models.Tablolarim
{
    public class Firma
    {
        [Key]
        public int ID { get; set; }

        public string FirmaAdi { get; set; }
    }
}