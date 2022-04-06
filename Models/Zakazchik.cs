using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdPractise.Models
{
    public class Zakazchik
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }

        public ICollection<Zakaz> Zakazs { get; set; }

        
    }
}