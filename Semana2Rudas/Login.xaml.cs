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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            bool datosValidos = ValidarDatos(usuario, password);
            if (datosValidos)
            {
                Menu menu = new Menu();
                //menu.show(); para mostrar una ventana de manera modal
                menu.ShowDialog();
            }
            else
            {
                txtMensaje.Text = "Usuario o contraseña incorrectos";
            }
        }
        private bool ValidarDatos(string usuario, string password)
        {

            if (usuario == "sharon" && password == "010203")
            {
                return true;
            }
            return false;
        }
    }
}
