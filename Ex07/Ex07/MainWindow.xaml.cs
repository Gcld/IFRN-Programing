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

namespace Ex07
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
        Historico h;
        private void Button_Aluno(object sender, RoutedEventArgs e)
        {
            h = new Historico(aluno.Text);
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            Disciplina d = new Disciplina(nome.Text, semestre.Text, int.Parse(media.Text), cbA.IsChecked.Value);
            h.Inserir(d);
            materias.ItemsSource = h.Listar();
        }

        private void Button_Excluir(object sender, RoutedEventArgs e)
        {
            if (materias.SelectedIndex != -1)
                h.Excluir(materias.SelectedIndex);
            materias.ItemsSource = h.Listar();
        }

        private void Button_Ira(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(h.CalcIra().ToString());
        }
    }
}
