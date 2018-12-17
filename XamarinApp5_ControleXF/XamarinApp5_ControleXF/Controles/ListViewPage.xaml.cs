using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp5_ControleXF.Model;

namespace XamarinApp5_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
	    public List<PessoaModel> _pessoas;

		public ListViewPage ()
		{
			InitializeComponent();

            _pessoas = new List<PessoaModel>();

		    _pessoas.Add(new PessoaModel() { Nome = "João", Idade = 18});
		    _pessoas.Add(new PessoaModel() { Nome = "Maria", Idade = 20 });
		    _pessoas.Add(new PessoaModel() { Nome = "Lagherta", Idade = 19 });
		    _pessoas.Add(new PessoaModel() { Nome = "Moramed", Idade = 25 });
		    _pessoas.Add(new PessoaModel() { Nome = "Ragnar", Idade = 25 });

		    LvDinamico.ItemsSource = _pessoas;
		}
	}
}