using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HaftaCode.Models.Tablolarim
{
    public class ilac
    {
        [Key]
        public int Barkod { get; set; }

        public string ilacadi { get; set; }

        public DateTime SkTarihi { get; set; }

        public int? FirmaID { get; set; }

        [ForeignKey("FirmaID")]
        public virtual Firma Firmalar { get; set; }
    }
}