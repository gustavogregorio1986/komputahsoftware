using komputahsoftware.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("tb_Usuarios");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.NomeUsuario)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Senha)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Role)
            .IsRequired()
            .HasMaxLength(50);
    }
}