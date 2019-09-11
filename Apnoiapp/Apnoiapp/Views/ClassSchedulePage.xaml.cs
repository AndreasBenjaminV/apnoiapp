﻿using Apnoiapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apnoiapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClassSchedulePage : ContentPage
	{
		public ClassSchedulePage ()
		{
			InitializeComponent ();

            BindingContext = new ClassScheduleViewModel();
		}
	}
}