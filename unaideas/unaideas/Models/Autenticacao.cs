using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class Autenticacao
    {
        public long id_autenticacao { get; set; }
        public long tipo_usuario { get; set; }
        public string login { get; set; }
        public string pw { get; set; }
        public virtual Investidor Investidor { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
