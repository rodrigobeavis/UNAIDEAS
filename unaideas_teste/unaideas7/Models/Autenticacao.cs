using System;
using System.Collections.Generic;

namespace unaideas7.Models
{
    public partial class Autenticacao
    {
        public Autenticacao()
        {
            this.Investidors = new List<Investidor>();
            this.Professors = new List<Professor>();
            this.Usuarios = new List<Usuario>();
        }

        public long id_autenticacao { get; set; }
        public string login { get; set; }
        public string pw { get; set; }
        public string area_user { get; set; }
        public string acesso_user { get; set; }
        public virtual ICollection<Investidor> Investidors { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
