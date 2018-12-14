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
	public partial class EntryOrEditorPage : ContentPage
	{
		public EntryOrEditorPage ()
		{
			InitializeComponent ();

		    EntryCompleted.Completed += EntryOnCompleted; // <-- Atribuido o metodo handler via Delegate
		}

	    private void EntryOnTextChanged(object sender, TextChangedEventArgs args)
	    {
            /*var entry = (Entry) sender;
	        LblEntryOnTextChanged.Text = entry.Text;*/

	        LblEntryOnTextChangedNewVal.Text = args.NewTextValue;
	        LblEntryOnTextChangedOldVal.Text = args.OldTextValue;
        }

	    private void EntryOnCompleted(object sender, EventArgs args)
	    {
	        var entry = (Entry) sender;
	        LblEntryOnCompleted.Text = entry.Text;
	    }

	    private void EditorOnTextChanged(object sender, TextChangedEventArgs args)
	    {
	        LblQtdCaracteres.Text = String.Format("Quantidade: {0}", args.NewTextValue.Length);
	    }
	}
}