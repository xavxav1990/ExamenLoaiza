using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenLoaiza
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(String user, String nombre, String cuota)
        {
            InitializeComponent();
            txtUsuario.Text = user;
            txtNombre.Text = nombre;
            txtCuota1.Text = cuota;
            txtCuota2.Text = cuota;
            txtCuota3.Text = cuota;
            double Total = (Convert.ToDouble(cuota))*3;
            txtTotal.Text = Convert.ToString(Total);


        }
    }
}