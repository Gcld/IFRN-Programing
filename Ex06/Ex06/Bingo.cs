using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Bingo
    {
        private int numBolas, cont;
        private int[] vet;
        public void Iniciar(int numBolas)
        {
            this.numBolas = numBolas;
            vet = new int[numBolas];
            int k = 0;
            Random r = new Random();
            while (k < numBolas)
            {
                int n = r.Next(1, numBolas + 1);
                if (Array.IndexOf(vet, n) == -1)
                {
                    vet[k] = n; k++;
                }
            }
        }
        public int Proximo()
        {
            if (cont < numBolas)
            {
                int x = vet[cont];
                cont++;
                return x;
            }
            return -1;
        }
    }
}
