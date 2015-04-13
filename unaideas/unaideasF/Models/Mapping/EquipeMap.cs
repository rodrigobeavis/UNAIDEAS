using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasF.Models.Mapping
{
    public class EquipeMap : EntityTypeConfiguration<Equipe>
    {
        public EquipeMap()
        {
            // Primary Key
            this.HasKey(t => t.id_equipe);

            // Properties
            // Table & Column Mappings
            this.ToTable("Equipe");
            this.Property(t => t.id_equipe).HasColumnName("id_equipe");
            this.Property(t => t.id_usuario).HasColumnName("id_usuario");
            this.Property(t => t.id_projeto).HasColumnName("id_projeto");

            // Relationships
            this.HasRequired(t => t.Projeto)
                .WithMany(t => t.Equipes)
                .HasForeignKey(d => d.id_projeto);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Equipes)
                .HasForeignKey(d => d.id_usuario);

        }
    }
}
