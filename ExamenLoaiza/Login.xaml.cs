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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String passw = txtPass.Text;

            if (usuario == "estudiante2021" && passw == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario, passw));
            }
            else {
                DisplayAlert("Alerta", "Datos incorrectos", "ok").ToString();                            
            }
            

        }
    }
}