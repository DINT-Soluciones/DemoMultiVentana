using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMultiVentana.Views;

namespace DemoMultiVentana.Services
{
    public class NavigacionService
    {
        // Abrir ventana nueva.
        public VentanaHija AbrirVentanaHija()
        {
            VentanaHija ventana = new VentanaHija();
            ventana.Show();
            return ventana;
        }

        // Cerrar la ventana indicada.
        public void CerrarVentanaHija(VentanaHija ventana)
        {
            ventana.Close();
        }
    }
}
