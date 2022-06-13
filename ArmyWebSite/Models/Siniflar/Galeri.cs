using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmyWebSite.Models.Siniflar
{
    public class Galeri
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public string VideoUrl { get; set; }
        public string ResimUrl { get; set; }
    }
}