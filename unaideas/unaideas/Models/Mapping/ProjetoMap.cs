using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas.Models.Mapping
{
    public class ProjetoMap : EntityTypeConfiguration<Projeto>
    {
        public ProjetoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_projeto);

            // Properties
            this.Property(t => t.tipo_projeto)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.tema_projeto)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.palavras_chave_projeto)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.resumo_projeto)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Projeto");
            this.Property(t => t.id_projeto).HasColumnName("id_projeto");
            this.Property(t => t.cod_projeto).HasColumnName("cod_projeto");
            this.Property(t => t.tipo_projeto).HasColumnName("tipo_projeto");
            this.Property(t => t.tema_projeto).HasColumnName("tema_projeto");
            this.Property(t => t.palavras_chave_projeto).HasColumnName("palavras_chave_projeto");
            this.Property(t => t.resumo_projeto).HasColumnName("resumo_projeto");
        }
    }
}
