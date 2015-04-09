using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class InvestidorMap : EntityTypeConfiguration<Investidor>
    {
        public InvestidorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_investidor);

            // Properties
            this.Property(t => t.nome_investidor)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.rg_investidor)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.email_investidor)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Investidor");
            this.Property(t => t.id_investidor).HasColumnName("id_investidor");
            this.Property(t => t.nome_investidor).HasColumnName("nome_investidor");
            this.Property(t => t.rg_investidor).HasColumnName("rg_investidor");
            this.Property(t => t.cod_investidor).HasColumnName("cod_investidor");
            this.Property(t => t.email_investidor).HasColumnName("email_investidor");
            this.Property(t => t.id_entidade_ensino).HasColumnName("id_entidade_ensino");

            // Relationships
            this.HasRequired(t => t.EntidadeDeEnsino)
                .WithMany(t => t.Investidors)
                .HasForeignKey(d => d.id_entidade_ensino);

        }
    }
}
