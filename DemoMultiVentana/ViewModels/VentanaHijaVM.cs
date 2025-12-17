using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMultiVentana.Views;
using CommunityToolkit.Mvvm.Input;
using DemoMultiVentana.Services;

namespace DemoMultiVentana.ViewModels
{
    public partial class VentanaHijaVM : ObservableObject
    {
        [ObservableProperty]
        private string _cadena;
        
        public VentanaHijaVM()
        {
            // Inicializamos la propiedad.
            Cadena = "Estoy en una ventana hija.";
        }
    }
}
