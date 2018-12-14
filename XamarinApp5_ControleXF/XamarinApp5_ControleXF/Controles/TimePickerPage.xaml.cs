using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp5_ControleXF.Shared;

namespace XamarinApp5_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimePickerPage : ContentPage
	{
		public TimePickerPage ()
		{
			InitializeComponent ();

		    TimePicker1.Time = DateTime.Now.ToTimeSpan();
		}


	    private void Button_OnClicked(object sender, EventArgs e)
	    {
            DisplayAlert("Horario selecionado", TimePicker1.Time.ToString(), "OK");
	    }
	}
}