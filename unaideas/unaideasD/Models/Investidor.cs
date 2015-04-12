using System;
using System.Collections.Generic;

namespace unaideasD.Models
{
    public partial class Investidor
    {
        public long id_investidor { get; set; }
        public string nome_investidor { get; set; }
        public string rg_investidor { get; set; }
        public long cod_investidor { get; set; }
        public string email_investidor { get; set; }
        public long id_entidade_ensino { get; set; }
        public long id_autenticacao { get; set; }
        public string telefone_investidor { get; set; }
        public virtual Autenticacao Autenticacao { get; set; }
        public virtual EntidadeDeEnsino EntidadeDeEnsino { get; set; }
    }
}
