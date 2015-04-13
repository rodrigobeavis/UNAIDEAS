using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace unaideas8.Models.Mapping
{
    public class AutenticacaoMap : EntityTypeConfiguration<Autenticacao>
    {
        public AutenticacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_autenticacao);

            // Properties
            this.Property(t => t.login)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.pw)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.area_user)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.acesso_user)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Autenticacao");
            this.Property(t => t.id_autenticacao).HasColumnName("id_autenticacao");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.pw).HasColumnName("pw");
            this.Property(t => t.area_user).HasColumnName("area_user");
            this.Property(t => t.acesso_user).HasColumnName("acesso_user");
        }
    }
}
