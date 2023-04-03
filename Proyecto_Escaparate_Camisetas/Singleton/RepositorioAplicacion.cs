using Proyecto_Escaparate_Camisetas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escaparate_Camisetas.Singleton {
  public sealed class RepositorioAplicacion {
        private readonly static RepositorioAplicacion _instance = new RepositorioAplicacion();
        private Clases.Usuarios usuario_login;
        private String nombre;
        private RepositorioAplicacion() {
        }





        public static RepositorioAplicacion Instance {
            get {
                return _instance;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Usuarios Usuario_login { get => usuario_login; set => usuario_login = value; }
    }

   
        
    
}
