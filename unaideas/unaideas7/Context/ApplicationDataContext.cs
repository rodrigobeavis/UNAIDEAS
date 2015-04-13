using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using unaideas7.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace unaideas7.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Turma> Turmas { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.EntidadeDeEnsino> EntidadeDeEnsinoes { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Professor> Professors { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Investidor> Investidors { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Autenticacao> Autenticacaos { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<unaideas7.Models.Projeto> Projetoes { get; set; }
    }
}