using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp5_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();

		    LblSwitchVal.Text = Switch1.IsToggled.ToString();
		}

	    private void Switch_OnToggled(object sender, ToggledEventArgs args)
	    {
	        LblSwitchVal.Text = args.Value.ToString();
	    }
	}
}