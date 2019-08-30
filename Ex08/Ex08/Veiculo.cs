using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Veiculo
    {
        private string placa, fabricante, modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public Veiculo(string placa, string fabricante, string modelo, int ano, decimal preco, bool vendido)
        {
            this.placa = placa;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
            this.vendido = vendido;
        }
        public void Vender()
        {
            if (vendido != true) vendido = true;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public bool GetVendido()
        {
            return vendido;
        }
        public override string ToString()
        {
            string vendeu;
            if (vendido == true) vendeu = "Vendido";
            else vendeu = "Não vendido";
            return $"{placa} {fabricante} {modelo} - {ano} - {preco} - {vendeu}";
        }
    }
}
