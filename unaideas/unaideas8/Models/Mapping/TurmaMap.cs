using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas8.Models.Mapping
{
    public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            // Primary Key
            this.HasKey(t => t.id_turma);

            // Properties
            this.Property(t => t.nome_turma)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.periodo_turma)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Turma");
            this.Property(t => t.id_turma).HasColumnName("id_turma");
            this.Property(t => t.nome_turma).HasColumnName("nome_turma");
            this.Property(t => t.periodo_turma).HasColumnName("periodo_turma");
            this.Property(t => t.id_entidade_ensino).HasColumnName("id_entidade_ensino");
            this.Property(t => t.id_professor).HasColumnName("id_professor");
            this.Property(t => t.ano_turma).HasColumnName("ano_turma");

            // Relationships
            this.HasRequired(t => t.EntidadeDeEnsino)
                .WithMany(t => t.Turmas)
                .HasForeignKey(d => d.id_entidade_ensino);
            this.HasRequired(t => t.Professor)
                .WithMany(t => t.Turmas)
                .HasForeignKey(d => d.id_professor);

        }
    }
}
