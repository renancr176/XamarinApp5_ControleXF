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
	public partial class SearchBarPage : ContentPage
	{
	    private List<string> _empresas;

		public SearchBarPage ()
		{
			InitializeComponent ();

		    _empresas = new List<string>();
		    _empresas.Add("Microsoft");
		    _empresas.Add("Google");
            _empresas.Add("Apple");
		    _empresas.Add("Oracle");
		    _empresas.Add("IBM");
		    _empresas.Add("SAP");

            Listar(_empresas);
        }

	    private void Listar(List<string> empresas)
	    {
	        ListResult.Children.Clear();
	        foreach (var item in empresas)
	        {
	            ListResult.Children.Add(new Label { Text = item });
	        }
        }

	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs args)
	    {
	        Listar(_empresas.Where(e => e.ToLower().Contains(args.NewTextValue.ToLower())).ToList<string>());
	    }

	    private void SearchBar_OnSearchButtonPressed(object sender, EventArgs args)
	    {
	        var searchBar = (SearchBar) sender;
	        Listar(_empresas.Where(e => e.ToLower().Contains(searchBar.Text.ToLower())).ToList<string>());
        }
	}
}