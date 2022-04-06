using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ThirdPractise.Models
{
    public class SellsContext : DbContext
    {
        public DbSet<Zakaz> Zakazs { get; set; }
        public DbSet<Zakazchik> Zakazchiks { get; set; }
    }
}