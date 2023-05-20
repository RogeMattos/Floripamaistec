using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Semana09_Exercicio_1_a_3.Models.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id);
            //1 para 1
            builder.HasOne(x => x.Medico)//1
                  .WithMany(p => p.Partos)//1
                 .HasForeignKey(x => x.Id_Medico) // FK representante
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK__Parto_Medico");

            builder.ToTable("Parto");
        }


    }
}
