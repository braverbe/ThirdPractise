using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdPractise.Models
{
    public class Zakaz
    {
        public int Id { get; set; }
        public string Predmet { get; set; }
        public int Colichestvo { get; set; }
        
        public int? ZakazchikId { get; set; }
        public Zakazchik Zakazchik { get; set; }


    }
}