using MySql.Data.MySqlClient;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas.BD {
    class ConexionBD {
        MySqlConnection conex = null;

        static string server = "localhost";
        static string bd = "proyecto_escaparate_camisetas";
        static string usuario = "root";
        static string password = "";



        /* string cadenaConexion = "Server=proyectoescaparate.mysql.database.azure.com;UserID=Pablo;Password=Nexus@1234;" +
             "Database=proyectocamisetas;SslMode=Required;SslCa=C:\\BaltimoreCyberTrustRoot.crt.pem;";*/
         string cadenaConexion = "Database=" + bd + "; Data Source=" + server + "; User Id=" + usuario + "; Password=" + password + "";



        public MySqlConnection conexion() {

            try {

                conex = new MySqlConnection(cadenaConexion);

                conex.Open();


            } catch (MySqlException e) {
                
                MessageBox.Show("Error en la base de datos " + e.ToString());
            }

            return conex;



        }



        public void cerrarConexion() {
            conex.Close();

        }
    }
}
