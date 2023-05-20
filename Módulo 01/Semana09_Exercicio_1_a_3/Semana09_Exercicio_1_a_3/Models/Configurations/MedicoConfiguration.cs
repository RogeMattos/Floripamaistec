using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Semana09_Exercicio_1_a_3.Models.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>

    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Medico");
        }
    }
}
