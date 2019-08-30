using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex08
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Loja loja;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loja = new Loja(nome.Text);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo(placa.Text, fabricante.Text, modelo.Text, int.Parse(ano.Text), decimal.Parse(preco.Text), vendido.IsChecked.Value);
            loja.Inserir(v);
            listBox.ItemsSource = loja.Listar();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = loja.Listar();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            loja.Excluir(listBox.SelectedIndex);
            listBox.ItemsSource = loja.Listar();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(loja.Total().ToString());
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = loja.ListarValor(decimal.Parse(limite.Text));
        }
    }
}
