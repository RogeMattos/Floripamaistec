using Microsoft.EntityFrameworkCore;
using Semana09_Exercicio_1_a_3.Models.Configurations;

namespace Semana09_Exercicio_1_a_3.Models
{
    public class BercarioContexto : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ROGERIO-MATTOS\\SQLEXPRESS;User ID=sa;Password=1234;Database=BERCARIOS09;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());

        }
    }
}
