using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasF.Models.Mapping
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

            this.Property(t => t.telefone_professor)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.disciplinas_professor)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Professor");
            this.Property(t => t.id_professor).HasColumnName("id_professor");
            this.Property(t => t.mat_professor).HasColumnName("mat_professor");
            this.Property(t => t.email_professor).HasColumnName("email_professor");
            this.Property(t => t.nome_professor).HasColumnName("nome_professor");
            this.Property(t => t.tipo_professor).HasColumnName("tipo_professor");
            this.Property(t => t.id_autenticacao).HasColumnName("id_autenticacao");
            this.Property(t => t.telefone_professor).HasColumnName("telefone_professor");
            this.Property(t => t.disciplinas_professor).HasColumnName("disciplinas_professor");

            // Relationships
            this.HasRequired(t => t.Autenticacao)
                .WithMany(t => t.Professors)
                .HasForeignKey(d => d.id_autenticacao);

        }
    }
}
