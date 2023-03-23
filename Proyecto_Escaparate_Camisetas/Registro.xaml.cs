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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Clases.Usuarios usuario = new Clases.Usuarios();
            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = txtPass.Password;




            try
            {

                Registro_Login.Controlador controlador = new Registro_Login.Controlador();

                string respuesta = controlador.ctrRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("Usuario reguistrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
    }

