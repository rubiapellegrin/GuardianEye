using GuardianEye.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuardianEye.Infrastructure.Configurations;

// Essa interface obriga você a implementar o método Configure
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        // 1. Mapeia o nome da tabela (exatamente como está no seu banco)
        builder.ToTable("People");

        // 2. Define a Chave Primária
        builder.HasKey(p => p.Id);

        // 3. Mapeia as colunas (tamanho, obrigatoriedade, etc)
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("Name"); // Opcional se o nome da coluna for igual à propriedade

        builder.Property(p => p.ReferenceImagePath)
            .HasMaxLength(500);

        builder.Property(p => p.CreatedAt)
            .IsRequired();

        builder.Property(p => p.IsActive)
            .IsRequired();
    }
}