using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideasD.Models.Mapping
{
    public class TelefoneInvestidorMap : EntityTypeConfiguration<TelefoneInvestidor>
    {
        public TelefoneInvestidorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_telefone_investidor);

            // Properties
            this.Property(t => t.telefone_investidor)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("TelefoneInvestidor");
            this.Property(t => t.id_telefone_investidor).HasColumnName("id_telefone_investidor");
            this.Property(t => t.telefone_investidor).HasColumnName("telefone_investidor");
            this.Property(t => t.id_investidor).HasColumnName("id_investidor");

            // Relationships
            this.HasRequired(t => t.Investidor)
                .WithMany(t => t.TelefoneInvestidors)
                .HasForeignKey(d => d.id_investidor);

        }
    }
}
