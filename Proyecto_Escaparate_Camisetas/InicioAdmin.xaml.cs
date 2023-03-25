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
    /// Lógica de interacción para InicioAdmin.xaml
    /// </summary>
    public partial class InicioAdmin : Window
    {
        public InicioAdmin()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            AdministradorUsuarios admin = new AdministradorUsuarios();
            admin.Show();
            this.Close();
        }
    }
}
