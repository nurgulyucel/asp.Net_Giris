using Microsoft.EntityFrameworkCore;
using OOP_Temelleri_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.ProjeContext
{
    public class Context : DbContext //ctrl+. ile core kullanıldı

        //kalıtım yapma

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-DMD5S6B7;database=DbNewOopCore;integrated security=true;");
            
        }
        public DbSet<Product> products { get; set; }
        //Product c# da kullanılan isim.
        //products Sql de tanımlanacak tablo ismi
        public DbSet<Customer> customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
