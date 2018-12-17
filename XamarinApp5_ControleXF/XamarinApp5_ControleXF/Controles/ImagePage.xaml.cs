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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            var image = new Image();

		    if (Device.RuntimePlatform == Device.UWP)
		    {
                image.Source = ImageSource.FromFile("Image/usb.jpg");
		    }
            else
		    {
		        image.Source = ImageSource.FromFile("usb.jpg");
		    }

            Container.Children.Add(image);
		}
	}
}