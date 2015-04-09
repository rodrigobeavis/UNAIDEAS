using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class TelefoneUsuarioMap : EntityTypeConfiguration<TelefoneUsuario>
    {
        public TelefoneUsuarioMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_telefone_usuario, t.telefone_usuario, t.id_usuario });

            // Properties
            this.Property(t => t.id_telefone_usuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.telefone_usuario)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.id_usuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TelefoneUsuario");
            this.Property(t => t.id_telefone_usuario).HasColumnName("id_telefone_usuario");
            this.Property(t => t.telefone_usuario).HasColumnName("telefone_usuario");
            this.Property(t => t.id_usuario).HasColumnName("id_usuario");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.TelefoneUsuarios)
                .HasForeignKey(d => d.id_usuario);

        }
    }
}
