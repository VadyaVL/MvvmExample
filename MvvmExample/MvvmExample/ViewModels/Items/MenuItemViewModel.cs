using System;

namespace MvvmExample.ViewModels.Items
{
    public class MenuItemViewModel
    {
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public bool IsSelected { get; set; }
    }
}
