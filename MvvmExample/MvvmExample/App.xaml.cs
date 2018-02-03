using MvvmExample.Views;
using Xamarin.Forms;

namespace MvvmExample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            AppSetup.Instance.InitializeApp();

            this.MainPage = new MainPage();
		}
	}
}
