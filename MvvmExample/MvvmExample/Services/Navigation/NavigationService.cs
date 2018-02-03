using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmExample.Services
{
    public class NavigationService : INavigationService
    {
        #region Fields

        private INavigation _navigation;

        #endregion

        #region Pros

        public bool IsRootMasterDetail => App.Current.MainPage is MasterDetailPage;

        #endregion

        #region Methods

        public async Task PopAsync()
        {
            if (this._navigation.NavigationStack.Count > 1)
            {
                await this._navigation.PopAsync();
            }
        }

        public async Task PushAsync(Type vmType)
        {
            if (AppContainer.NavigationKeys.Keys.Contains(vmType))
            {
                var pageType = AppContainer.NavigationKeys[vmType];
                var page = Activator.CreateInstance(pageType/*, this._selectedItem.Params*/) as Page;

                await this._navigation.PushAsync(page);
            }
        }

        public void SetRootPage(Type vmType, bool isMasterDetail = false)
        {
            if (AppContainer.NavigationKeys.Keys.Contains(vmType))
            {
                var pageType = AppContainer.NavigationKeys[vmType];
                var page = Activator.CreateInstance(pageType/*, this._selectedItem.Params*/) as Page;
                
                if (this._navigation != null)
                {
                    // Clear stack
                    this._navigation = null;
                }
                
                Application.Current.MainPage = new NavigationPage(page);
                this._navigation = page.Navigation;
            }
        }

        #endregion
    }
}
