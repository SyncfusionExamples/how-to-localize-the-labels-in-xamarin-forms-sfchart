using Syncfusion.SfChart.XForms;
using System;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfChartLocalization
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ChartResourceManager.Manager = new ResourceManager("SfChartLocalization.Resources.Syncfusion.SfChart.XForms", Application.Current.GetType().Assembly);

            MainPage = new MainPage();
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
