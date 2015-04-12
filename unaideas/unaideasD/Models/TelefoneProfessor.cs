using System;
using System.Collections.Generic;

namespace unaideasD.Models
{
    public partial class TelefoneProfessor
    {
        public long id_telefone_professor { get; set; }
        public byte[] telefone_professor { get; set; }
        public long id_professor { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
