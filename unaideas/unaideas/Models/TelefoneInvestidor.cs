using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class TelefoneInvestidor
    {
        public long id_telefone_investidor { get; set; }
        public string telefone_investidor { get; set; }
        public long id_investidor { get; set; }
        public virtual Investidor Investidor { get; set; }
    }
}
