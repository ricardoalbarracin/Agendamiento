using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://weblayer.us-east-1.elasticbeanstalk.com");
            string url = string.Format("/account/UserValidate");
            try
            {
                var response = await client.GetAsync(url);
                var result = response.Content.ReadAsByteArrayAsync().Result;
            }
            catch (Exception errr)
            {

                DisplayAlert("", errr.ToString(), "cerrar");
            }
            
            
        }
    }
}
