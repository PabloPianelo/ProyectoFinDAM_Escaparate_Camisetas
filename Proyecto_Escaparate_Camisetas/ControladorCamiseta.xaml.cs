using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para ControladorCamiseta.xaml
    /// </summary>
    public partial class ControladorCamiseta : Window
    {
        public ControladorCamiseta()
        {
            InitializeComponent();

            BD.ConexionBD conexionBD = new BD.ConexionBD();
            BD.Modelo modelo = new BD.Modelo();

            MySqlConnection conexion = conexionBD.conexion();


            String sql = "SELECT * FROM camiseta";
            MySqlCommand command = new MySqlCommand(sql, conexion);


            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            dataGrib.ItemsSource = dt.DefaultView;
            conexionBD.conexion();


        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

            InicioAdmin admin = new InicioAdmin();
            admin.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String dato = nombre.Text;
            BD.Modelo modelo = new BD.Modelo();

            if (dato != null && modelo.existeUsuario(dato))
            {
                modelo.eliminarCamiseta(dato);
                MessageBox.Show("Elemento Borrado");
                nombre.Text = null;

            }
            else
            {
                MessageBox.Show("Error vuelve a intentarlo!!!");
                nombre.Text = null;
            }

        }
    }
}
