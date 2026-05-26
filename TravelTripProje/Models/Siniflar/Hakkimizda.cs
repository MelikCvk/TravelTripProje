using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    [Table("Hakkimizdas")]
    public class Hakkimizda
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}