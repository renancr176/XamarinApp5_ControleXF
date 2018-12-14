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
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();

		    var Items = new List<String>();
		    Items.Add("Banana");
		    Items.Add("Morango");

            foreach (var item in Items)
		    {
		        Picker1.Items.Add(item);
		    }
		}

	    private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
	    {
	        var selectedItem = (Picker) sender;

	        DisplayAlert("Opção selecionada", string.Concat(selectedItem.SelectedIndex.ToString(), " - ", selectedItem.SelectedItem.ToString()), "OK");
	    }
	}
}