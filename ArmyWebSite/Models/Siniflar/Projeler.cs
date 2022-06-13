using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmyWebSite.Models.Siniflar
{
    public class Projeler
    {
        [Key]
        public int ID { get; set; }
        public string Adi { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string ProjeImage { get; set; }
    }
}