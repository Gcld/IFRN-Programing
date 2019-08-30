using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
        private string aluno;
        private Disciplina[] disc = new Disciplina[10];
        private int l = 0;
        public Historico()
        {

        }
        public Historico(string aluno)
        {
            this.aluno = aluno;
        }
        public void Inserir(Disciplina d)
        {
            disc[l++] = d;
        }
        public void Excluir(int x)
        {
            for (int i = x; i < l - 1; i++)
                disc[i] = disc[i + 1];
            l--;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] d = new Disciplina[l];
            Array.Copy(disc, d, l);
            return d;
        }
        public double CalcIra()
        {
            double ira = 0;
            Disciplina[] d = Listar();
            foreach (Disciplina di in d) ira += di.GetMedia();
            ira /= l;
            return ira;
        }
    }
}
