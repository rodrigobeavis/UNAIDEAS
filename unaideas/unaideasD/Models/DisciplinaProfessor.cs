using System;
using System.Collections.Generic;

namespace unaideasD.Models
{
    public partial class DisciplinaProfessor
    {
        public long id_disciplina_professor { get; set; }
        public string disciplina_professor { get; set; }
        public long id_professor { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
