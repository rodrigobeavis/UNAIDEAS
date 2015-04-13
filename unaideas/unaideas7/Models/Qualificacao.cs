using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace unaideas7.Models
{
    public partial class Qualificacao
    {
        [Key]
        public long id_qualificacao { get; set; }
        public System.DateTime data_hora_qualificacao { get; set; }
        public string obs_qualificacao { get; set; }
        public long id_professor { get; set; }
        public long id_projeto { get; set; }
        public int valor_qualificacao { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}
