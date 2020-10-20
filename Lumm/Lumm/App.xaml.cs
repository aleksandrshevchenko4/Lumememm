using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsLumememm();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
