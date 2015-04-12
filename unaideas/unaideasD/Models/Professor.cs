using System;
using System.Collections.Generic;

namespace unaideasD.Models
{
    public partial class Professor
    {
        public Professor()
        {
            this.DisciplinaProfessors = new List<DisciplinaProfessor>();
            this.Qualificacaos = new List<Qualificacao>();
            this.TelefoneProfessors = new List<TelefoneProfessor>();
            this.Turmas = new List<Turma>();
        }

        public long id_professor { get; set; }
        public long mat_professor { get; set; }
        public string email_professor { get; set; }
        public string nome_professor { get; set; }
        public string tipo_professor { get; set; }
        public long id_autenticacao { get; set; }
        public virtual Autenticacao Autenticacao { get; set; }
        public virtual ICollection<DisciplinaProfessor> DisciplinaProfessors { get; set; }
        public virtual ICollection<Qualificacao> Qualificacaos { get; set; }
        public virtual ICollection<TelefoneProfessor> TelefoneProfessors { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
