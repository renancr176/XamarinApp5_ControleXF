using System;
using Xamarin.Forms;
using XamarinApp5_ControleXF.Controles;
using XamarinApp5_ControleXF.Pages;

namespace XamarinApp5_ControleXF
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToHome(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToActivityIndicator(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ActivityIndicatorPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToProgressBar(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ProgressBarPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToBoxView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new BoxViewPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToLabel(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new LabelPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToButton(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ButtonPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToEntryOrEditor(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new EntryOrEditorPage())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }
        
    }
}
