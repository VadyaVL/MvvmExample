using Autofac;
using System;
using System.Collections.Generic;

namespace MvvmExample
{
    public static class AppContainer
    {
        public static IContainer Container { get; set; }

        public static IDictionary<Type, Type> NavigationKeys { get; set; }   // ViewModelType -> ViewType
    }
}
