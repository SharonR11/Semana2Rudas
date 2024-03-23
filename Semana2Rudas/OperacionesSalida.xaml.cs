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
    /// Lógica de interacción para OperacionesSalida.xaml
    /// </summary>
    public partial class OperacionesSalida : Window
    {
        public OperacionesSalida()
        {
            InitializeComponent();
        }
        private void Button_Registrar(object sender, RoutedEventArgs e)
        {
            //string documento = archivoTipoDocumento.Text;
            //string numDocumento = txtNumDocumento.Text;
            //string peso = txtPeso.Text;
            //string tipoAuto = txtNumTipoAuto.Text;
            //string nombreTransportista = txtNombreTransportista.Text;
            ////string fechaHora = dpFechaHora.SelectedDate.ToString();
            //string pesoIngreso = txtPesoIngreso.Text;
            //string pesoSalida = txtPesoSalida.Text;


            txtMensaje.Text = "Registro exitoso!";
            txtMensaje.Visibility = Visibility.Visible;

        }
    }
}