using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using unaideasweb.Models.Mapping;

namespace unaideasweb.Models
{
    public partial class unaideasbdContext : DbContext
    {
        static unaideasbdContext()
        {
            Database.SetInitializer<unaideasbdContext>(null);
        }

        public unaideasbdContext()
            : base("Name=unaideasbdContext")
        {
        }

        public DbSet<Autenticacao> Autenticacaos { get; set; }
        public DbSet<EntidadeDeEnsino> EntidadeDeEnsinoes { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Investidor> Investidors { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Projeto> Projetoes { get; set; }
        public DbSet<Qualificacao> Qualificacaos { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutenticacaoMap());
            modelBuilder.Configurations.Add(new EntidadeDeEnsinoMap());
            modelBuilder.Configurations.Add(new EquipeMap());
            modelBuilder.Configurations.Add(new InvestidorMap());
            modelBuilder.Configurations.Add(new ProfessorMap());
            modelBuilder.Configurations.Add(new ProjetoMap());
            modelBuilder.Configurations.Add(new QualificacaoMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TurmaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
