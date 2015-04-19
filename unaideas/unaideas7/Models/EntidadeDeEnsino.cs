using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace unaideas7.Models
{
    public partial class EntidadeDeEnsino
    {
        public EntidadeDeEnsino()
        {
            this.Investidors = new List<Investidor>();
            this.Turmas = new List<Turma>();
        }
        
        public long id_entidade_ensino { get; set; }
        public string nome_entidade_ensino { get; set; }
        public string descricao_entidade_ensino { get; set; }
        public virtual ICollection<Investidor> Investidors { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
