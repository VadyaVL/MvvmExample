﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmExample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmailPage : ContentPage
	{
		public EmailPage ()
		{
			InitializeComponent ();

            // Call one. In xaml call twice.
            //var locator = new Locator.Locator();

            //this.BindingContext = locator.Email;
        }
    }
}