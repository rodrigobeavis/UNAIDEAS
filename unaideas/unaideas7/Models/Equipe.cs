using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace unaideas7.Models
{
    public partial class Equipe
    {
        [Key]
        public long id_equipe { get; set; }
        public long id_usuario { get; set; }
        public long id_projeto { get; set; }
        public virtual Projeto Projeto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
