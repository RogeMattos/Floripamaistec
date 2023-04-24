using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Semana09_Exercicio_1_a_3.Models.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(e => e.Id);

            // 1 para muitos
            builder.HasOne(x => x.Mae) // 1 
                    .WithMany(p => p.Bebes) // muitos
                    .HasForeignKey(x => x.Id_Mae) // FK representante
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bebe_Mae");



            // 1 para muitos
            builder.HasOne(x => x.Parto) // 1 
                    .WithMany(p => p.Bebes) // muitos
                    .HasForeignKey(x => x.Id_Parto) // FK representante
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bebe_Parto");

            builder.ToTable("Bebe");
        }
    }
}
