using MvvmExample.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmExample.ViewModels
{
    public abstract class BasicViewModel : INotifyPropertyChanged
    {
        protected IEmailService EmailService { get; set; }

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}