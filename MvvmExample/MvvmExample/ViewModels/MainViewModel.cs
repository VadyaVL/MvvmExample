using MvvmExample.Services;
using MvvmExample.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class MainViewModel : BasicViewModel
    {
        #region Constructors

        public MainViewModel(INavigationService navService) : base(navService)
        {
            // Init Services
        }

        #endregion

        #region Commands

        public ICommand Initialize
        {
            get
            {
                return new Command(() =>
                {
                    // Some logic
                    // Auth - open page A
                    // NotAuth - open page B

                    //this.NavigationService.SetRootPage(typeof(EmailViewModel));
                    this.NavigationService.SetRootPage(typeof(UserViewModel));
                });
            }
        }

        #endregion

    }
}
