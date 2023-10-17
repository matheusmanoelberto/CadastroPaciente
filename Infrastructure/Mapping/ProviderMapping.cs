using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CadastroPaciente.Infrastructure.Mapping;
public class ProviderMapping
{
    public void Configure(EntityTypeBuilder<Domain.Entities.ProviderEntity> builder)
    {
        builder.ToTable("fornecedor");

        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Name).HasColumnType("varchar(120)");
        builder.Property(prop => prop.Thumbnail).HasColumnType("varchar(50)");
        builder.Property(prop => prop.Email).HasColumnType("varchar(120)");
        builder.Property(prop => prop.Cpf_Or_Cnpj).HasColumnType("varchar(14)");
        builder.Property(prop => prop.Sexo).HasColumnType("varchar(9)");
        builder.Property(prop => prop.Password);
        builder.Property(prop => prop.Active);
        builder.Property(prop => prop.CreatedAt).HasColumnType("timestamp");
        builder.Property(prop => prop.UpdatedAt).HasColumnType("timestamp");
    }
}