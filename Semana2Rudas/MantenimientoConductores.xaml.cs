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
    /// Lógica de interacción para MantenimientoConductores.xaml
    /// </summary>
    public partial class MantenimientoConductores : Window
    {
        public MantenimientoConductores()
        {
            InitializeComponent();
            CargarListaConductores();
        }
        private void CargarListaConductores()
        {
            List<Conductor> conductores = ObtenerConductores();

            datosConductores.ItemsSource = conductores;
        }
        private List<Conductor> ObtenerConductores()
        {
            return new List<Conductor>()
            {
                new Conductor() { Nombre = "Sharon", PesoMaximo = 1000, Placa = "1a2b3c", PesoVacio = 20 },
                new Conductor() { Nombre = "Deysi", PesoMaximo = 2000, Placa = "1a2b3c", PesoVacio = 30 },
                new Conductor() { Nombre = "Estefany", PesoMaximo = 3000, Placa = "1a2b3c", PesoVacio = 40 }
            };
        }
        private class Conductor
            {
                public string Nombre { get; set; }
                public int PesoMaximo { get; set; }
                public string Placa { get; set; }
                public int PesoVacio { get; set; }
            }

    }
}
