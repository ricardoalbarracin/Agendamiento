using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agendamiento
{
    public enum MenuType
    {
        About,
        Blog,
        Twitter,
        Hanselminutes,
        Ratchet,
        DeveloperLife
    }
    public class BaseModel
    {
        public BaseModel()
        {
        }

        public string Title { get; set; }
        public string Details { get; set; }
        public int Id { get; set; }

    }
    public class HomeMenuItem : BaseModel
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.About;
        }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }
    }
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
                BackgroundColor = Color.FromHex("#03A9F4");
                ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");
            ListViewMenu.ItemsSource  = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "About", MenuType = MenuType.About, Icon ="about.png" },
                    new HomeMenuItem { Title = "Blog", MenuType = MenuType.Blog, Icon = "blog.png" }
                };
        }
    }
}
