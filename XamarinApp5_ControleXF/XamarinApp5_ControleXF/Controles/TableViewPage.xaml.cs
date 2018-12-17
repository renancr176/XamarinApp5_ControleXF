﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp5_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableViewPage : ContentPage
	{
		public TableViewPage ()
		{
			InitializeComponent ();
		}

	    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs args)
	    {
	        LblQtdDiasSemana.Text = ((int) args.NewValue).ToString();
	    }
	}
}