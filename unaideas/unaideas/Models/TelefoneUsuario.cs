using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class TelefoneUsuario
    {
        public long id_telefone_usuario { get; set; }
        public string telefone_usuario { get; set; }
        public long id_usuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
