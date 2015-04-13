using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasF.Models.Mapping
{
    public class DisciplinaProfessorMap : EntityTypeConfiguration<DisciplinaProfessor>
    {
        public DisciplinaProfessorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_disciplina_professor);

            // Properties
            this.Property(t => t.disciplina_professor)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DisciplinaProfessor");
            this.Property(t => t.id_disciplina_professor).HasColumnName("id_disciplina_professor");
            this.Property(t => t.disciplina_professor).HasColumnName("disciplina_professor");
            this.Property(t => t.id_professor).HasColumnName("id_professor");

            // Relationships
            this.HasRequired(t => t.Professor)
                .WithMany(t => t.DisciplinaProfessors)
                .HasForeignKey(d => d.id_professor);

        }
    }
}
