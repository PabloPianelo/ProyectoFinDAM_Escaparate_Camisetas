using Proyecto_Escaparate_Camisetas.Clases;
using System;

namespace Proyecto_Escaparate_Camisetas.Singleton {
    public sealed class RepositorioAplicacion {
        private readonly static RepositorioAplicacion _instance = new RepositorioAplicacion();
        private Clases.Usuarios usuario_login;
        private String nombre,texto;
        private RepositorioAplicacion() {
        }





        public static RepositorioAplicacion Instance {
            get {
                return _instance;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Texto { get => texto; set => texto = value; }
        internal Usuarios Usuario_login { get => usuario_login; set => usuario_login = value; }
    }




}
