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
	public partial class WebViewPage : ContentPage
	{
	    private string _homeUrl = "http://www.google.com";
	    private string _goToUrl = "";

		public WebViewPage ()
		{
			InitializeComponent ();

		    Browser.Source = _homeUrl;

		    if (Device.RuntimePlatform == Device.UWP)
		    {
		        BtnGoBack.Image = "Image/back_arrow.png";
		        BtnGoForward.Image = "Image/forward_arrow.png";
            }
		    else
		    {
		        BtnGoBack.Image = "back_arrow.png";
		        BtnGoForward.Image = "forward_arrow.png";
            }

		    BtnGoBack.IsVisible = false;
            BtnGoForward.IsVisible = false;
		    AILoagindPage.IsVisible = false;

		}

	    private void GoToURL(object sender, EventArgs args)
	    {
	        Browser.Source = ((Navigation.Text.Contains("http://") || Navigation.Text.Contains("https://")) ? Navigation.Text:"http://"+Navigation.Text);
            BtnGoBack.IsVisible = true;
        }

	    private void GoBack(object sender, EventArgs args)
	    {
	        if (Browser.CanGoBack)
	        {
                Browser.GoBack();
	            BtnGoForward.IsVisible = true;
	        }

            if (!Browser.CanGoBack)
            { 
                BtnGoBack.IsVisible = false;
            }
        }

	    private void GoForward(object sender, EventArgs args)
	    {
	        if (Browser.CanGoForward)
	        {
                Browser.GoForward();
	            BtnGoBack.IsVisible = true;
            }

	        if (!Browser.CanGoForward)
	        {
	            BtnGoForward.IsVisible = false;
            }
        }

        private void ActionCarregando(object sender, WebNavigatingEventArgs args)
        {
            LblStatus.IsVisible = true;
            AILoagindPage.IsVisible = true;
            LblStatus.Text = "Loading";

            if (Browser.CanGoBack)
            {
                BtnGoBack.IsVisible = true;
            }
            else
            {
                BtnGoBack.IsVisible = false;
            }

            if (Browser.CanGoForward)
            {
                BtnGoForward.IsVisible = true;
            }
            else
            {
                BtnGoForward.IsVisible = false;
            }
        }

	    private void ActionCarregado(object sender, WebNavigatedEventArgs args)
	    {
	        Navigation.Text = args.Url;
	        LblStatus.Text = args.Result.ToString();
	        AILoagindPage.IsVisible = false;

            Task.Run(() =>
	        {
	            Task.Delay(2000).Wait();
                Device.BeginInvokeOnMainThread(() => { LblStatus.IsVisible = false; });
	        });
        }
	}
}