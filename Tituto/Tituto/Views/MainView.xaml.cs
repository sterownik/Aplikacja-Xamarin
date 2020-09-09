
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Tituto.Models;



namespace Tituto.Views
{
    
   
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage 
    {
        public MainView()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            Values val = new Values();
            ExpLabel.Text = val.ExpEarn + "/" + val.ExpToEarn;
            ExpProgress.Progress = 0.6;
            DisplayAlert("Login", val.ExpEarn+"", "Ok");
        }
    }
}