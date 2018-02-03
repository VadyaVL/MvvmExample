using MvvmExample.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class DetailViewModel : BasicViewModel
    {
        #region Fields
        
        private string _message;

        #endregion

        #region Properties
        
        public string Message
        {
            get => this._message;
            set
            {
                this._message = value;
                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Constructors

        public DetailViewModel(INavigationService navService) : base(navService)
        {
            this.Message = "DetailPage";
        }

        #endregion

        #region Commands

        public ICommand Close
        {
            get
            {
                return new Command(() =>
                {
                    this.NavigationService.PopAsync();
                });
            }
        }

        #endregion
    }
}
