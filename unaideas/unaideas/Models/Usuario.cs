using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Autenticacaos = new List<Autenticacao>();
            this.Equipes = new List<Equipe>();
            this.TelefoneUsuarios = new List<TelefoneUsuario>();
        }

        public long id_usuario { get; set; }
        public string rg_usuario { get; set; }
        public string ra_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string email { get; set; }
        public long id_turma { get; set; }
        public virtual ICollection<Autenticacao> Autenticacaos { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<TelefoneUsuario> TelefoneUsuarios { get; set; }
        public virtual Turma Turma { get; set; }
    }
}
