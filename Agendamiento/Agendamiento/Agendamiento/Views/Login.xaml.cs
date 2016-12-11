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
            //waitActivityIndicator1.IsVisible = true;
            //waitActivityIndicator2.IsRunning = true;
            EnterButton.IsEnabled = false;
            string result="";
            EjemploModel a = new EjemploModel();
            try
            {
                 result = await a.InitDataAsync();
            }
            catch (Exception)
            {

            }
            //waitActivityIndicator.IsRunning = false;
            EnterButton.IsEnabled = true;
            //await Navigation.PushAsync(new Agendas(result));
            App.Current.MainPage = new NavigationPage(new Agendas(result));
        }
    }
}
