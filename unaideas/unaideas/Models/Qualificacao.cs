using System;
using System.Collections.Generic;

namespace unaideas.Models
{
    public partial class Qualificacao
    {
        public long id_qualificacao { get; set; }
        public System.DateTime data_hora_qualificacao { get; set; }
        public string tipo_qualificacao { get; set; }
        public long id_professor { get; set; }
        public long id_projeto { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}
