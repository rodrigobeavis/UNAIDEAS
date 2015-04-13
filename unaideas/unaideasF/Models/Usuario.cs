using System;
using System.Collections.Generic;

namespace unaideasF.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Equipes = new List<Equipe>();
        }

        public long id_usuario { get; set; }
        public string rg_usuario { get; set; }
        public string ra_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string email { get; set; }
        public long id_turma { get; set; }
        public long id_autenticacao { get; set; }
        public string telefone_usuario { get; set; }
        public virtual Autenticacao Autenticacao { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual Turma Turma { get; set; }
    }
}
