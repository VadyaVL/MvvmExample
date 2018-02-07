using System;
using System.Collections.Generic;

namespace MvvmExample
{
    public static class AppContainer
    {
        public static IDictionary<Type, Type> NavigationKeys { get; set; }   // ViewModelType -> ViewType
    }
}
