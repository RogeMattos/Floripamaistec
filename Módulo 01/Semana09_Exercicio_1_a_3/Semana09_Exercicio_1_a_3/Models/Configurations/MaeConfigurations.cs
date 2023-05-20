using Microsoft.EntityFrameworkCore;

namespace Semana09_Exercicio_1_a_3.Models.Configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Mae");

        }
    }
}
