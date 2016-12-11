using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agendamiento.Views;
using Xamarin.Forms;

namespace Agendamiento
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new Login();
            //if ((Current.Properties.ContainsKey("IsLoged")) && ((bool)Application.Current.Properties["IsLoged"]))
            //    MainPage = new NavigationPage(new Agendas(""));
            //else
            //{
            //    MainPage = new NavigationPage(new Login());
            //    Current.Properties["IsLoged"] = true;
            //}

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
