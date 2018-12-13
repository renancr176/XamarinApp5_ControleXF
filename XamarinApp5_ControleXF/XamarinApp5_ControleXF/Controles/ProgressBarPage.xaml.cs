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
	public partial class ProgressBarPage : ContentPage
	{
	    private double _progressBar1 = 0;
        private double _progressBar2 = 0;

        public ProgressBarPage ()
		{
			InitializeComponent();

		    Barra2.Progress = _progressBar2 / 100;

		    Barra1AutoProgress();
		}

	    private void Barra1AutoProgress()
	    {
	        Task.Run(() =>
	        {
	            while (true)
	            {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Barra1.Progress = _progressBar1 / 100;
	                    _progressBar1 += 5;
	                    if (_progressBar1 > 100)
	                    {
	                        _progressBar1 = 0;
	                    }
                    });
	                Task.Delay(1000).Wait();
                }
	        });
	    }

	    private void ElevarProgresso(object sender, EventArgs args)
	    {
	        _progressBar2 += 5;

	        if (_progressBar2 > 100)
	        {
	            _progressBar2 = 0;
	        }

	        Barra2.Progress = (_progressBar2 / 100);
        }
    }
}