using Microsoft.EntityFrameworkCore;
using WebAPI2.Data.Entities;

#nullable disable

namespace WebAPI2.Data.DBContext
{
    public partial class EstudoDBContext : DbContext
    {
        public EstudoDBContext(DbContextOptions<EstudoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbPessoa> TbPessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-11EO9URV\\SQLEXPRESS;Database=EstudoDB;Trusted_Connection=True;");
            }
        }

       
    }
}
