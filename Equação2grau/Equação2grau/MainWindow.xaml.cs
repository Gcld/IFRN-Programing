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

namespace Equação2grau
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EqIIgrau equa = new EqIIgrau();
            equa.SetABC(double.Parse(A.Text), double.Parse(B.Text), double.Parse(C.Text));
            if (equa.Delta() >= 0)
            {
                delt.Text = equa.Delta().ToString();
                xizum.Text = equa.X1().ToString();
                xidos.Text = equa.X2().ToString();
            }
            else
            {
                delt.Text = equa.Delta().ToString();
                xizum.Text = "Raiz Indefinida";
                xidos.Text = "Raiz Indefinida";
            }
        }
    }
}
