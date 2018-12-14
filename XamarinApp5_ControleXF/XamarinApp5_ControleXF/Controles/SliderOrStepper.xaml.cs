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
	public partial class SliderOrStepper : ContentPage
	{
		public SliderOrStepper ()
		{
			InitializeComponent ();
		}

	    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs args)
	    {
	        LblSliderNewVal.Text = args.NewValue.ToString();
	        LblSliderOldVal.Text = args.OldValue.ToString();
	    }

	    private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs args)
	    {
	        LblStepperNewVal.Text = args.NewValue.ToString();
	        LblStepperOldVal.Text = args.OldValue.ToString();
        }
	}
}