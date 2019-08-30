using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Numeros
    {
        private int inicio, fim;
        public Numeros(int inicio, int fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }
        public int[] Calcular(bool p, bool i)
        {
            int[] vet = new int[fim];
            int cont = 0;
            for (int k = inicio; k <= fim; k++)
            {
                if (p == true && i == false && k % 2 == 0) vet[cont++] = k;
                if (p == false && i == true && k % 2 != 0) vet[cont++] = k;
                if (p == true && i == true) vet[cont++] = k;
            }
            int[] retornar = new int[cont];
            Array.Copy(vet, retornar, cont);
            return retornar;
        }
    }
}
