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

namespace Proyecto_Escaparate_Camisetas
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
            Registro registro = new Registro();
            registro.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            String nombres = nombre.Text;

            String pas = pass.Password;
            try
            {

                Registro_Login.Controlador controlador = new Registro_Login.Controlador();
                BD.Modelo modelo = new BD.Modelo();
                String respuesta = controlador.ctrlLoging(nombres, pas);
                if (respuesta.Length > 0)
                {

                    MessageBox.Show(respuesta);
                }
                else if(modelo.adminorUsuario(nombres).Equals("1"))
                {
                    InicioAdmin admin = new InicioAdmin();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    InicioUsuario usuario = new InicioUsuario();
                    usuario.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
