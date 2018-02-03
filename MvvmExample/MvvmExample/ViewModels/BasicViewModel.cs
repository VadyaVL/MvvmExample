using MvvmExample.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmExample.ViewModels
{
    public abstract class BasicViewModel : INotifyPropertyChanged
    {
        #region Services

        protected IEmailService EmailService { get; set; }

        protected INavigationService NavigationService { get; set; }

        #endregion

        #region Constructors

        public BasicViewModel(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        #endregion

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}