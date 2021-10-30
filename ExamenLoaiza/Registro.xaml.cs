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
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, String passw)
        {
            InitializeComponent();
            lblUser.Text = usuario;


        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            double monto = Convert.ToDouble(txtMonto.Text);

            if (monto <= 1800 && monto >= 0)
            {

                double cuotas = ((1800 - monto) / 3) * 1.05;
                txtCuota1.Text = Convert.ToString(cuotas);
                txtCuota2.Text = Convert.ToString(cuotas);
                txtCuota3.Text = Convert.ToString(cuotas);

            }
            else {
                DisplayAlert("Alerta", "Valor debe ser entre: 0 y 1800", "ok").ToString();
            
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            string nombre = txtNombre.Text;
            string cuota = txtCuota1.Text;


            await Navigation.PushAsync(new Resumen(user, nombre, cuota));
        }
    }
}