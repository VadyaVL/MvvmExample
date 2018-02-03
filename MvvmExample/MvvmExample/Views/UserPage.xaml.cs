using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmExample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : MasterDetailPage
    {
        // Detail="{Binding Detail}" not worked. Use DetailPage
        // This is necessary because the Detail is not Bindable
        // When we use M-V-VM we binding data.
        // It use only here.
        //#region Binding

        //public static readonly BindableProperty DetailPageProperty = BindableProperty.Create(nameof(DetailPage), typeof(Page), typeof(UserPage), null, BindingMode.TwoWay,
        //    propertyChanged: (bindable, oldValue, newValue) =>
        //    {
        //        if (bindable is UserPage self)
        //        {
        //            self.Detail = newValue as Page;
        //        }
        //    });

        //#endregion

        //#region Properties

        //public Page DetailPage
        //{
        //    get { return (Page)GetValue(DetailPageProperty); }
        //    set { SetValue(DetailPageProperty, value); }
        //}

        //#endregion

        public UserPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

        }
    }
}