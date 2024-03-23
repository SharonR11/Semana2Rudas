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
    /// Lógica de interacción para ReporteSalida.xaml
    /// </summary>
    public partial class ReporteSalida : Window
    {
        public ReporteSalida()
        {
            InitializeComponent();
            CargarListaConductores();
        }
        private void CargarListaConductores()
        {
            List<Conductor> conductores = ObtenerConductores();
            listasalidas.ItemsSource = conductores;
        }

        private List<Conductor> ObtenerConductores()
        {
            return new List<Conductor>()
            {
                new Conductor() { Fecha = DateTime.Now, Peso = 1000, TipoAuto = "Tipo1", NombreTransportista = "Sharon", PesoIngreso = 20, PesoSalida = 30 },
                new Conductor() { Fecha = DateTime.Now, Peso = 2000, TipoAuto = "Tipo2", NombreTransportista = "Deysi", PesoIngreso = 30, PesoSalida = 40 },
                new Conductor() { Fecha = DateTime.Now, Peso = 3000, TipoAuto = "Tipo3", NombreTransportista = "Estefany", PesoIngreso = 40, PesoSalida = 50 }
            };
        }

        private class Conductor
        {
            public DateTime Fecha { get; set; }
            public int Peso { get; set; }
            public string TipoAuto { get; set; }
            public string NombreTransportista { get; set; }
            public int PesoIngreso { get; set; }
            public int PesoSalida { get; set; }
        }
    }
}
