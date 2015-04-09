using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class TelefoneProfessorMap : EntityTypeConfiguration<TelefoneProfessor>
    {
        public TelefoneProfessorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_telefone_professor);

            // Properties
            this.Property(t => t.telefone_professor)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TelefoneProfessor");
            this.Property(t => t.id_telefone_professor).HasColumnName("id_telefone_professor");
            this.Property(t => t.telefone_professor).HasColumnName("telefone_professor");
            this.Property(t => t.id_professor).HasColumnName("id_professor");

            // Relationships
            this.HasRequired(t => t.Professor)
                .WithMany(t => t.TelefoneProfessors)
                .HasForeignKey(d => d.id_professor);

        }
    }
}
