using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agendamiento.Views
{
    public partial class Agendas : ContentPage
    {
        public Agendas(string datos)
        {
            InitializeComponent();
            label.Text = datos;
        }
    }
}
