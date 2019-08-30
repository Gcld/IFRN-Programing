using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Loja
    {
        private string nome;
        private int cont = 0;
        Veiculo[] v = new Veiculo[10];
        public Lojaa(string nome) { this.nome = nome; }
        public void Inserir(Veiculo v)
        {
            this.v[cont++] = v;
        }
        public void Excluir(int k)
        {
            for (int i = k; i < cont - 1; i++)
                v[i] = v[i + 1];
            cont--;
        }
        public Veiculo[] Listar()
        {
            Veiculo[] veic = new Veiculo[cont];
            Array.Copy(v, veic, cont);
            return veic;
        }
        public decimal Total()
        {
            decimal tot = 0;
            Veiculo[] v = Listar();
            foreach (Veiculo ve in v)
            {
                if (ve.GetVendido() == false)
                    tot += ve.GetPreco();
            }
            return tot;
        }
        public Veiculo[] ListarValor(decimal limite)
        {
            int x = 0;
            Veiculo[] veic = new Veiculo[cont];
            foreach (Veiculo a in Listar())
                if (a.GetVendido() == false)
                    if (a.GetPreco() <= limite) veic[x++] = a;
            Veiculo[] retorno = new Veiculo[x];
            Array.Copy(veic, retorno, x);
            return retorno;
        }
    }
}
