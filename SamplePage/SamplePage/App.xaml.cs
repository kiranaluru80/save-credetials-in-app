using System;

using Xamarin.Forms;

namespace SamplePage
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
         
            MainPage = new NavigationPage(new FirstPage());
        }
    }
}
