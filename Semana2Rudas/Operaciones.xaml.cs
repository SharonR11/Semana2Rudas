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
using System.Windows.Shapes;

namespace Semana2Rudas
{
    /// <summary>
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }
        private void Button_Ingresos(object sender, RoutedEventArgs e)
        {
            OperacionesSalida operacionessalida = new OperacionesSalida();
            operacionessalida.Show();
        }
        private void Button_Salida(object sender, RoutedEventArgs e)
        {
            OperacionesSalida operacionessalida = new OperacionesSalida();
            operacionessalida.Show();

        }
    }
}
