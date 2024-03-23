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
    /// Lógica de interacción para Mantenimientos.xaml
    /// </summary>
    public partial class Mantenimientos : Window
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }
        private void Button_Conductores(object sender, RoutedEventArgs e)
        {
            MantenimientoConductores mantenimientoconductores = new MantenimientoConductores();
            mantenimientoconductores.Show();
        }
        private void Button_Transportistas(object sender, RoutedEventArgs e)
        {
            MantenimientoCamiones mantenimientocamiones = new MantenimientoCamiones();
            mantenimientocamiones.Show();

        }
        private void Button_Camiones(object sender, RoutedEventArgs e)
        {
            MantenimientoCamiones mantenimientocamiones = new MantenimientoCamiones();
            mantenimientocamiones.Show();

        }
        private void Button_Productos(object sender, RoutedEventArgs e)
        {
            MantenimientoCamiones mantenimientocamiones = new MantenimientoCamiones();
            mantenimientocamiones.Show();

        }
    }
}
