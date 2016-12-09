using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agendamiento.Models;

using Xamarin.Forms;

namespace Agendamiento.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            Title = "Iniciar sesión";
        }

        private async void enterButton_Clicked(object sender, EventArgs e)
        {
            waitActivityIndicator.IsRunning = true;
            EnterButton.IsEnabled = false;
            EjemploModel a = new EjemploModel();
            string result =await a.InitDataAsync();
            

            waitActivityIndicator.IsRunning = false;
            EnterButton.IsEnabled = true;
            //await Navigation.PushAsync(new Agendas(result));
            App.Current.MainPage = new NavigationPage(new Agendas(result));
        }
    }
}
