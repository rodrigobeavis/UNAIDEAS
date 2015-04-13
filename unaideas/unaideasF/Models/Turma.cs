using System;
using System.Collections.Generic;

namespace unaideasF.Models
{
    public partial class Turma
    {
        public Turma()
        {
            this.Usuarios = new List<Usuario>();
        }

        public long id_turma { get; set; }
        public string nome_turma { get; set; }
        public string periodo_turma { get; set; }
        public long id_entidade_ensino { get; set; }
        public long id_professor { get; set; }
        public System.DateTime ano_turma { get; set; }
        public virtual EntidadeDeEnsino EntidadeDeEnsino { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
