using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Disciplina
    {
        private string nome, semestre;
        private int media;
        private string situacao;
        public Disciplina(string nome, string semestre, int media, bool situacao)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.media = media;
            if (situacao == true) this.situacao = "Aprovado";
            else this.situacao = "Reprovado";
        }
        public double GetMedia() { return media; }
        public override string ToString()
        {
            return nome + " - " + semestre + " - " + media + " - " + situacao;
        }
    }
}
