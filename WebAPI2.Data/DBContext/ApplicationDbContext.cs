using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI2.DBContext
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(Data.DataBase.Configuration.GetSection("DefaultConnection").Value.ToString());
                optionsBuilder.UseSqlServer("Server=LAPTOP-11EO9URV\\SQLEXPRESS;Database=EstudoDB;Trusted_Connection=True;");
            }
        }
    }
}
