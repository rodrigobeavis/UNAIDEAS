using System;
using System.Collections.Generic;

namespace unaideasF.Models
{
    public partial class Professor
    {
        public Professor()
        {
            this.DisciplinaProfessors = new List<DisciplinaProfessor>();
            this.Qualificacaos = new List<Qualificacao>();
            this.Turmas = new List<Turma>();
        }

        public long id_professor { get; set; }
        public long mat_professor { get; set; }
        public string email_professor { get; set; }
        public string nome_professor { get; set; }
        public string tipo_professor { get; set; }
        public long id_autenticacao { get; set; }
        public string telefone_professor { get; set; }
        public string disciplinas_professor { get; set; }
        public virtual Autenticacao Autenticacao { get; set; }
        public virtual ICollection<DisciplinaProfessor> DisciplinaProfessors { get; set; }
        public virtual ICollection<Qualificacao> Qualificacaos { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
