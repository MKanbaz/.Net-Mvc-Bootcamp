using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetinBot.Models
{
    public class SoruCevap
    {
        public int ID { get; set; }

        public string Soru { get; set; }

        public string Cevap { get; set; }
    }
}