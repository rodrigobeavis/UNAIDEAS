using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_professor);

            // Properties
            this.Property(t => t.email_professor)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.nome_professor)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.tipo_professor)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Professor");
            this.Property(t => t.id_professor).HasColumnName("id_professor");
            this.Property(t => t.mat_professor).HasColumnName("mat_professor");
            this.Property(t => t.email_professor).HasColumnName("email_professor");
            this.Property(t => t.nome_professor).HasColumnName("nome_professor");
            this.Property(t => t.tipo_professor).HasColumnName("tipo_professor");
        }
    }
}
