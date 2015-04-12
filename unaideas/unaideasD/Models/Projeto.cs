using System;
using System.Collections.Generic;

namespace unaideasD.Models
{
    public partial class Projeto
    {
        public Projeto()
        {
            this.Equipes = new List<Equipe>();
            this.Qualificacaos = new List<Qualificacao>();
        }

        public long id_projeto { get; set; }
        public long cod_projeto { get; set; }
        public string tipo_projeto { get; set; }
        public string tema_projeto { get; set; }
        public string palavras_chave_projeto { get; set; }
        public string resumo_projeto { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Qualificacao> Qualificacaos { get; set; }
    }
}
