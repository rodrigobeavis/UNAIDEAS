using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class AutenticacaoMap : EntityTypeConfiguration<Autenticacao>
    {
        public AutenticacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_autenticacao);

            // Properties
            this.Property(t => t.login)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.pw)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Autenticacao");
            this.Property(t => t.id_autenticacao).HasColumnName("id_autenticacao");
            this.Property(t => t.tipo_usuario).HasColumnName("tipo_usuario");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.pw).HasColumnName("pw");

            // Relationships
            this.HasRequired(t => t.Investidor)
                .WithMany(t => t.Autenticacaos)
                .HasForeignKey(d => d.tipo_usuario);
            this.HasRequired(t => t.Professor)
                .WithMany(t => t.Autenticacaos)
                .HasForeignKey(d => d.tipo_usuario);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Autenticacaos)
                .HasForeignKey(d => d.tipo_usuario);

        }
    }
}
