using MvvmExample.Views;
using Xamarin.Forms;

namespace MvvmExample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var setup = new AppSetup();
            AppContainer.Container = setup.CreateContainer(); // Dependency Injection

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
