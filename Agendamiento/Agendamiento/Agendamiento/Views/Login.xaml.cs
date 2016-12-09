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
        }

        private async void enterButton_Clicked(object sender, EventArgs e)
        {
            EjemploModel a = new EjemploModel();
            string result = a.InitDataAsync();
            DisplayAlert("", result, "cancelar");
        }
    }
}
