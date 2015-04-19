using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasweb.Models.Mapping
{
    public class EntidadeDeEnsinoMap : EntityTypeConfiguration<EntidadeDeEnsino>
    {
        public EntidadeDeEnsinoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_entidade_ensino);

            // Properties
            this.Property(t => t.nome_entidade_ensino)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.descricao_entidade_ensino)
                .IsRequired()
                .HasMaxLength(350);

            // Table & Column Mappings
            this.ToTable("EntidadeDeEnsino");
            this.Property(t => t.id_entidade_ensino).HasColumnName("id_entidade_ensino");
            this.Property(t => t.nome_entidade_ensino).HasColumnName("nome_entidade_ensino");
            this.Property(t => t.descricao_entidade_ensino).HasColumnName("descricao_entidade_ensino");
        }
    }
}
