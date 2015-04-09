using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class Investidor
    {
        public Investidor()
        {
            this.Autenticacaos = new List<Autenticacao>();
            this.TelefoneInvestidors = new List<TelefoneInvestidor>();
        }

        public long id_investidor { get; set; }
        public string nome_investidor { get; set; }
        public string rg_investidor { get; set; }
        public long cod_investidor { get; set; }
        public string email_investidor { get; set; }
        public long id_entidade_ensino { get; set; }
        public virtual ICollection<Autenticacao> Autenticacaos { get; set; }
        public virtual EntidadeDeEnsino EntidadeDeEnsino { get; set; }
        public virtual ICollection<TelefoneInvestidor> TelefoneInvestidors { get; set; }
    }
}
