using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escaparate_Camisetas.Registro_Login
{
    class Controlador
    {

        public string ctrRegistro(Clases.Usuarios usuario)
        {


            
            BD.Modelo modelo = new BD.Modelo();
            String respuesta = "";


            if (String.IsNullOrEmpty(usuario.Nombre) || String.IsNullOrEmpty(usuario.Contraseña))
            {
                respuesta = "Debes llenar todos los campos";
            }
            else
            {

                if (modelo.existeUsuario(usuario.Nombre))
                {
                    respuesta = "El usuario ya existe";
                }
                else
                {
                    modelo.registro(usuario);
                }

            }


            return respuesta;
        }


        public string ctrlLoging(String nombre, String pass)
        {
            BD.Modelo modelo = new BD.Modelo();
            String respuesta = "";
            Clases.Usuarios datosUsuario = null;

            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(pass))
            {
                respuesta = "Debes llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(nombre);

                if (datosUsuario == null)
                {
                    respuesta = "No existe el usuario";
                }
                else
                {
                    if (datosUsuario.Contraseña != pass)
                    {
                        respuesta = "El usuario o contraseña no coincide";
                    }
                    else
                    {
                        
                    }
                }
            }

            return respuesta;
        }
    }
}
