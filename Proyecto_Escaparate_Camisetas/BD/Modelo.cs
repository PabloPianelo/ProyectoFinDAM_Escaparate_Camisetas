using MySql.Data.MySqlClient;
using System;
using System.Collections;

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

            String sql = "SELECT nombre,contrasena FROM usuario where nombre=" + "'" + usuario + "'";

            MySqlCommand command = new MySqlCommand(sql, conexion);


            reader = command.ExecuteReader();

            Clases.Usuarios usr = null;


            while (reader.Read()) {
                usr = new Clases.Usuarios();
                usr.Nombre = reader["nombre"].ToString();
                usr.Contraseña = reader["contrasen" +
                    "a"].ToString();

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
            int id = 0;
            String sql = "SELECT * FROM usuario where nombre=" + "'" + nombre + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idUsuario"];
            }

            class1.cerrarConexion();
            return id;


        }






        //Camisetas-Imagenes

        public long insertarCamiseta(Clases.Camiseta camiseta) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO camiseta (nombre,colorCamiseta,img_Camiseta) VALUES (@Nombre,@colorCamiseta,@img_Camiseta)";


            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.AddWithValue("@Nombre", camiseta.Nombre);
            command.Parameters.AddWithValue("@colorCamiseta", camiseta.ColorCamiseta);
            command.Parameters.AddWithValue("@img_Camiseta", camiseta.Img);

            int resultado = command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            conexionBD.cerrarConexion();
            return id;


        }

        public long insertarImagen(Clases.Imagen imagen) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO imagen (nombre,idUsuario,colorCamiseta,img_Imagen) VALUES (@Nombre,@idUsuario,@colorCamiseta,@Img_Imagen)";

            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.Parameters.AddWithValue("@Nombre", imagen.Nombre);
            command.Parameters.AddWithValue("@idUsuario", imagen.IdUsuario);
            command.Parameters.AddWithValue("@colorCamiseta", imagen.ColorCamiseta);
            command.Parameters.AddWithValue("@Img_Imagen", imagen.Img_Imagen);

            int resultado = command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            conexionBD.cerrarConexion();
            return id;


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



        public int insertarCamisetas_Imagenes_Usuario(long idImagen, long idCamiseta,long idUsuario) {
            BD.ConexionBD conexionBD = new BD.ConexionBD();

            MySqlConnection conexion = conexionBD.conexion();

            String sql = "INSERT INTO imagen_camiseta (idImagen,idCamiseta,idUsuario) VALUES (" + idImagen + "," + idCamiseta + "," + idUsuario + ")";

            MySqlCommand command = new MySqlCommand(sql, conexion);

            int resultado = command.ExecuteNonQuery();
            conexionBD.cerrarConexion();
            return resultado;


        }

        public ArrayList img_Camiseta() {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            ArrayList array = new ArrayList();

            String sql = "SELECT img_Camiseta  FROM camiseta";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Clases.Camiseta camiseta = new Clases.Camiseta();
                camiseta.Img = (byte[])reader["img_Camiseta"];
                array.Add(camiseta);

            }

            class1.cerrarConexion();
            return array;


        }


        public ArrayList img_Imagen(int idUsuario) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            ArrayList array = new ArrayList();
            String sql = "SELECT img_Imagen FROM imagen where idUsuario=" + "'" + idUsuario + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Clases.Imagen imagen = new Clases.Imagen();
                imagen.Img_Imagen = (byte[])reader["img_Imagen"];
                array.Add(imagen);
            }

            class1.cerrarConexion();
            return array;


        }




        
        public Clases.Camiseta porImg_Camiseta(Byte[] imagen_camiseta) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();

            String sql = "SELECT  colorCamiseta,nombre  FROM camiseta where img_Camiseta=@imagen_camiseta";

            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.Parameters.AddWithValue("@imagen_camiseta", imagen_camiseta);

            reader = command.ExecuteReader();

            Clases.Camiseta usr = null;


            while (reader.Read()) {
                usr = new Clases.Camiseta();
                usr.ColorCamiseta = reader["colorCamiseta"].ToString();
                usr.Nombre = reader["nombre"].ToString();


            }
            class1.cerrarConexion();
            return usr;

        }




        public Clases.Imagen porImg_Imagen(Byte[] imagen_imagen) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();

            String sql = "SELECT  colorCamiseta,nombre  FROM imagen where img_Imagen= @imagen_imagen";

            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.Parameters.AddWithValue("@imagen_imagen", imagen_imagen);

            reader = command.ExecuteReader();

            Clases.Imagen usr = null;


            while (reader.Read()) {
                usr = new Clases.Imagen();
                usr.ColorCamiseta = reader["colorCamiseta"].ToString();
                usr.Nombre = reader["nombre"].ToString();


            }
            class1.cerrarConexion();
            return usr;

        }


        //mensaje

        public int idImagen(String nombre) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id = 0;
            String sql = "SELECT * FROM imagen where nombre=" + "'" + nombre + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idImagen"];
            }

            class1.cerrarConexion();
            return id;


        }

        public int idCamiseta(String nombre) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id = 0;
            String sql = "SELECT * FROM camiseta where nombre=" + "'" + nombre + "'";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idCamiseta"];
            }

            class1.cerrarConexion();
            return id;


        }






        public String nombreImagen(long id) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            String nombre = null;
            String sql = "SELECT * FROM imagen where idImagen=" + id ;
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                nombre = (string)reader["nombre"];
            }

            class1.cerrarConexion();
            return nombre;


        }

        public String nombreCamiseta(long id) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            String nombre = null;
            String sql = "SELECT * FROM camiseta where idCamiseta=" + id;
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                nombre = (string)reader["nombre"];
            }

            class1.cerrarConexion();
            return nombre;


        }


        public String nombreUsuario(long id) {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            String nombre = null;
            String sql = "SELECT * FROM usuario where idUsuario=" + id;
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                nombre = (string)reader["nombre"];
            }

            class1.cerrarConexion();
            return nombre;


        }




        public int mensajeIdUsuario() {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id = 0;
            String sql = "SELECT * FROM imagen_camiseta ";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idUsuario"];
            }

            class1.cerrarConexion();
            return id;


        }

        public int mensajeIdCamiseta() {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id = 0;
            String sql = "SELECT * FROM imagen_camiseta ";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idCamiseta"];
            }

            class1.cerrarConexion();
            return id;


        }

        public int mensajeIdImagen() {
            BD.ConexionBD class1 = new BD.ConexionBD();
            MySqlDataReader reader = null;
            MySqlConnection conexion = class1.conexion();
            int id = 0;
            String sql = "SELECT * FROM imagen_camiseta ";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            reader = command.ExecuteReader();
            while (reader.Read()) {
                id = (int)reader["idImagen"];
            }

            class1.cerrarConexion();
            return id;


        }





    }



}
