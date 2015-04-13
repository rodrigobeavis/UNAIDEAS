using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasF.Models.Mapping
{
    public class QualificacaoMap : EntityTypeConfiguration<Qualificacao>
    {
        public QualificacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_qualificacao);

            // Properties
            this.Property(t => t.obs_qualificacao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Qualificacao");
            this.Property(t => t.id_qualificacao).HasColumnName("id_qualificacao");
            this.Property(t => t.data_hora_qualificacao).HasColumnName("data_hora_qualificacao");
            this.Property(t => t.obs_qualificacao).HasColumnName("obs_qualificacao");
            this.Property(t => t.id_professor).HasColumnName("id_professor");
            this.Property(t => t.id_projeto).HasColumnName("id_projeto");
            this.Property(t => t.valor_qualificacao).HasColumnName("valor_qualificacao");

            // Relationships
            this.HasRequired(t => t.Professor)
                .WithMany(t => t.Qualificacaos)
                .HasForeignKey(d => d.id_professor);
            this.HasRequired(t => t.Projeto)
                .WithMany(t => t.Qualificacaos)
                .HasForeignKey(d => d.id_projeto);

        }
    }
}
