using MySql.Data.MySqlClient;
using System;

namespace Proyecto_Escaparate_Camisetas.BD {
    class Modelo {


        //registro
        public int registro(Clases.Usuarios usuario) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO usuario (nombre,contraseña,rol) VALUES (" + "'" + usuario.Nombre + "'," + "'" + usuario.Contraseña + "',false)";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;


        }


        public bool existeUsuario(String usuario) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = conexionBD.conexion();

            String sql = "SELECT * FROM usuario where nombre=" + "'" + usuario + "'";

            MySqlCommand command = new MySqlCommand(sql, conexion);


            reader = command.ExecuteReader();

            if (reader.HasRows) {
                conexionBD.cerrarConexion();
                return true;
            } else {
                conexionBD.cerrarConexion();
                return false;
            }
        }

        public Clases.Usuarios porUsuario(String usuario) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();

            String sql = "SELECT nombre,contraseña FROM usuario where nombre=" + "'" + usuario + "'";

            MySqlCommand command = new MySqlCommand(sql, conexion);


            reader = command.ExecuteReader();

            Clases.Usuarios usr = null;


            while (reader.Read()) {
                usr = new Clases.Usuarios();
                usr.Nombre = reader["nombre"].ToString();
                usr.Contraseña = reader["contraseña"].ToString();

            }
            class1.cerrarConexion();
            return usr;


        }

        public String adminorUsuario(String nombre) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            String result = " ";
            String sql = "SELECT rol FROM usuario where nombre=" + "'" + nombre + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();

            while (reader.Read()) {

                result = reader["rol"].ToString();


            }

            class1.cerrarConexion();
            return result;

        }


        public int idUsuario(String nombre) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id=0;
            String sql = "SELECT * FROM usuario where nombre=" + "'" + nombre + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                 id = (int) reader["idUsuario"];
            }

            class1.cerrarConexion();
            return id;


        }






        //Camisetas-Imagenes

        public long insertarCamiseta(Clases.Camiseta camiseta) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO camiseta (nombre,colorCamiseta,img_Camiseta) VALUES (" + "'" + camiseta.Nombre + "'," + "'" + camiseta.ColorCamiseta + "'," + "'" + camiseta.Img + "')";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            conexionBD.cerrarConexion();
            return id;


        }

        public int insertarImagen(Clases.Imagen imagen) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO imagen (nombre,idUsuario,colorCamiseta,img_Imagen) VALUES (" + "'" + imagen.Nombre + "'," + "'" + imagen.IdUsuario + "'," + "'" + imagen.ColorCamiseta + "'," + "'" + imagen.Img_Imagen + "')";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;


        }

        public int insertarCamisetas_Usuarios(long idUsuario, long idCamiseta) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO usuario_camiseta (idUsuario,idCamiseta) VALUES (" + idUsuario + "," + idCamiseta + ")";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;


        }



        public int insertarCamisetas_Imagenes1(long idCamiseta) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO imagen_camiseta (idCamiseta) VALUES (" + idCamiseta + ")";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;



        }


        public int insertarCamisetas_Imagenes2(long idImagen) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO imagen_camiseta (idImagen) VALUES (" + idImagen + ")";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;



        }


    }
}
