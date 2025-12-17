using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using DemoMultiVentana.Views;
using DemoMultiVentana.Services;

namespace DemoMultiVentana.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        // Servicio para abrir la ventana.
        private NavigacionService sn;

        // Para la gestión de las ventanas que vamos abriendo.
        private List<VentanaHija> listaVentanas;

        // Constructor de la VISTA-MODELO.
        public MainWindowVM()
        {
           sn = new NavigacionService();
           listaVentanas = new List<VentanaHija>();
        }

        // Acciones que vienen de la VISTA.
        [RelayCommand]
        private void AbrirVentana()
        {
            // Código para abrir ventana hija.
            listaVentanas.Add(sn.AbrirVentanaHija());
        }

        [RelayCommand]
        private void CerrarVentana()
        {
            // Cerramos todas las ventanas hijas creadas.
            foreach (VentanaHija ventana in listaVentanas)
            {
                sn.CerrarVentanaHija(ventana);
            }
        }
    }
}
