using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escaparate_Camisetas.Registro_Login
{
    class Modelo
    {
        public int registro(Clases.Usuarios usuario)
        {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO usuario (nombre,pass) VALUES (" + "'" + usuario.Nombre + "'," + "'" + usuario.Pass + "')";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;

             
        }

        public bool existeUsuario(String usuario)
        {
           BD.ConexionBD conexionBD = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = conexionBD.conexion();

            String sql = "SELECT * FROM usuario where nombre=" + "'" + usuario + "'";

            MySqlCommand command = new MySqlCommand(sql, conexion);
            

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                conexionBD.cerrarConexion();
                return true;
            }
            else
            {
                conexionBD.cerrarConexion();
                return false;
            }
        }

        public Clases.Usuarios porUsuario(String usuario)
        {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();

            String sql = "SELECT nombre,pass FROM usuario where nombre=" + "'" + usuario + "'";

            MySqlCommand command = new MySqlCommand(sql, conexion);


            reader = command.ExecuteReader();

            Clases.Usuarios usr = null;


            while (reader.Read())
            {
                usr = new Clases.Usuarios();
                usr.Nombre = reader["nombre"].ToString();
                usr.Pass = reader["pass"].ToString();

            }
            class1.cerrarConexion();
            return usr;


        }
    }
}
