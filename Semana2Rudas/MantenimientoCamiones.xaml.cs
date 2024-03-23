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
    /// Lógica de interacción para MantenimientoCamiones.xaml
    /// </summary>
    public partial class MantenimientoCamiones : Window
    {
        public MantenimientoCamiones()
        {
            InitializeComponent();
        }
        private void Button_Registrar(object sender, RoutedEventArgs e)
        {
            txtMensaje.Text = "Registro exitoso!";
            txtMensaje.Visibility = Visibility.Visible;
        }
    }
}
