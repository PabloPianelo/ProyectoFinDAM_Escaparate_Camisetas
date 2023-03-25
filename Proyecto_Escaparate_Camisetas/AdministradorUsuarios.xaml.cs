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

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para AdministradorUsuarios.xaml
    /// </summary>
    public partial class AdministradorUsuarios : Window {
        public AdministradorUsuarios() {
            InitializeComponent();

              BD.ConexionBD conexionBD = new BD.ConexionBD();



               MySqlConnection conexion = conexionBD.conexion();


               String sql = "SELECT * FROM usuario";
               MySqlCommand command = new MySqlCommand(sql, conexion);


               DataTable dt = new DataTable();
          
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
               dataGrib.ItemsSource = dt.DefaultView;
            conexionBD.conexion();












        }
    }
}
