using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasF.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.id_usuario);

            // Properties
            this.Property(t => t.id_usuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rg_usuario)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.ra_usuario)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.nome_usuario)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.telefone_usuario)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.id_usuario).HasColumnName("id_usuario");
            this.Property(t => t.rg_usuario).HasColumnName("rg_usuario");
            this.Property(t => t.ra_usuario).HasColumnName("ra_usuario");
            this.Property(t => t.nome_usuario).HasColumnName("nome_usuario");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.id_turma).HasColumnName("id_turma");
            this.Property(t => t.id_autenticacao).HasColumnName("id_autenticacao");
            this.Property(t => t.telefone_usuario).HasColumnName("telefone_usuario");

            // Relationships
            this.HasRequired(t => t.Autenticacao)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.id_autenticacao);
            this.HasRequired(t => t.Turma)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.id_turma);

        }
    }
}
