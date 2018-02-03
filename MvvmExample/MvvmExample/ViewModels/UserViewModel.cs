using MvvmExample.Services;
using MvvmExample.ViewModels.Items;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class UserViewModel : BasicViewModel
    {
        #region Fields
        
        private ObservableCollection<MenuItemViewModel> _collection = new ObservableCollection<MenuItemViewModel>();

        private MenuItemViewModel _selectedItem;
        
        private bool _isPresented;

        #endregion

        #region Properties
        
        public ObservableCollection<MenuItemViewModel> Collection  => this._collection;

        public MenuItemViewModel SelectedItem
        {
            get => this._selectedItem;
            set
            {
                if (value == null)
                {
                    return;
                }

                if (this._selectedItem != null)
                {
                    this._selectedItem.IsSelected = false;
                }

                this._selectedItem = value;

                if (this._selectedItem != null)
                {
                    this._selectedItem.IsSelected = true;
                }

                this.OnPropertyChanged();
                
                this.NavigationService.SetRootPage(this._selectedItem.TargetType, true);

                this.IsPresented = false;
            }
        }
        
        public bool IsPresented
        {
            get => this._isPresented;
            set
            {
                this._isPresented = value;
                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public ICommand Initialize
        {
            get
            {
                return new Command(() =>
                {
                    this.SelectedItem = this.Collection.FirstOrDefault(x => x.TargetType == typeof(EmailViewModel));
                });
            }
        }

        #endregion

        #region Constructors

        public UserViewModel(INavigationService navService) : base(navService)
        {
#if DEBUG
            Debug.WriteLine(this.GetType().Name);
#endif

            var pageEmail = new MenuItemViewModel()
            {
                Title = "Email",
                TargetType = typeof(EmailViewModel),
            };

            this.Collection.Add(pageEmail);
        }

        #endregion
    }
}
