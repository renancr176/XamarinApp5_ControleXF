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
	public partial class DatePickerPage : ContentPage
	{
		public DatePickerPage ()
		{
			InitializeComponent ();

		    DatePicker1.MaximumDate = DateTime.Now;
            DatePicker1.Date = DateTime.Now;
        }

	    private void DatePicker1_OnDateSelected(object sender, DateChangedEventArgs args)
	    {
	        DisplayAlert(
	            "Data selecionada",
	            args.NewDate.ToString("dd/MM/yyyy"),
	            "OK"
	        );

	        LblNewDate.Text = args.NewDate.ToString("dd/MM/yyyy");
	        LblOldDate.Text = args.OldDate.ToString("dd/MM/yyyy");
        }
	}
}