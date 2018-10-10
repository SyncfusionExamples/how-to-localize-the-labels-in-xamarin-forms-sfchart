using Syncfusion.SfChart.XForms;
using System;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SfChartLocalization
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            ChartResourceManager.Manager = new ResourceManager("SfChartLocalization.Resources.Syncfusion.SfChart.XForms", Application.Current.GetType().Assembly);

            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
