using MvvmExample.Models;
using MvvmExample.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class EmailViewModel : BasicViewModel
    {
        #region Fields

        private string _addressFrom;

        private string _addressTo;

        private string _message;

        #endregion

        #region Properties

        public string AddressFrom
        {
            get => this._addressFrom;
            set
            {
                this._addressFrom = value;
                this.OnPropertyChanged();
            }
        }

        public string AddressTo
        {
            get => this._addressTo;
            set
            {
                this._addressTo = value;
                this.OnPropertyChanged();
            }
        }

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

        public EmailViewModel(IEmailService emailService)
        {
            this.EmailService = emailService;

            this.AddressFrom = "vadyavl@gmail.com";
            this.AddressTo = "ivanmr@ukr.net";
            this.Message = "Hello MVVM!";
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
