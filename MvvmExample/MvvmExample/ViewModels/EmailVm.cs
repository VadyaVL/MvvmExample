using MvvmExample.Models;
using MvvmExample.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class EmailVm : BasicVm, INotifyPropertyChanged
    {
        #region Fields

        private string addressFrom;

        private string addressTo;

        private string message;

        #endregion

        #region Properties

        public string AddressFrom
        {
            get => this.addressFrom;
            set
            {
                this.addressFrom = value;
                this.OnPropertyChanged();
            }
        }

        public string AddressTo
        {
            get => this.addressTo;
            set
            {
                this.addressTo = value;
                this.OnPropertyChanged();
            }
        }

        public string Message
        {
            get => this.message;
            set
            {
                this.message = value;
                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Constructors

        public EmailVm(IEmailService emailService)
        {
            this.EmailService = emailService;

            this.AddressFrom = "vadyavl@gmail.com";
            this.AddressTo = "ivanmr@ukr.net";
            this.Message = "Hello MVVM!";
        }

        #endregion

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Commands

        public ICommand Send
        {
            get
            {
                return new Command(() =>
                {
                    // Validate
                    // Create Model

                    // Maybe use mapper or instead of fields use one field EmailDto Email
                    var email = new EmailDto()
                    {
                        AddressFrom = this.AddressFrom,
                        AddressTo = this.AddressTo,
                        Message = this.Message
                    };

                    this.EmailService.Send(email);
                });
            }
        }

        #endregion

        #region 

        #endregion

    }
}
