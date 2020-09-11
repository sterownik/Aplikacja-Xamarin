
using System;
using System.Threading.Tasks;
using Tituto.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace Tituto.Views
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public NavigationPage MainPage { get; private set; }

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
            FirstQuiz.Text = "Rekord: " + val.FirstQuizPkt1;
            SecondQuiz.Text = "Rekord: " + val.SecondQuizPkt1;
            ThirdQuiz.Text = "Rekord: " + val.ThirdQuizPkt1;
            FourthQuiz.Text = "Rekord: "+ val.FourthQuizPkt1;
            NumberStars.Text = val.NumberOfStars1+"";
            Level.Text ="Poziom "+ val.NumberLevel1;
            LabelName.Text = val.Name1;

        }

        async void OnClickButtons(object sender, EventArgs args)
        {
           
            var button = (ImageButton)sender;
            await button.FadeTo(0, 200);
            await button.FadeTo(1, 200);
           
            await DisplayAlert("Informacja", button.ClassId, "OK");
            
            
        }

      async void OnTappedFirstFrame(object sender, EventArgs e)
        {
            // Do stuff
            await this.FirstFrame.FadeTo(0, 200);
            await this.FirstFrame.FadeTo(1, 200);
            GoToNextPage("Regulaminowym Królu");

        }
       async void OnTappedSecondFrame(object sender, EventArgs e)
        {
            // Do stuff
            await this.SecondFrame.FadeTo(0, 200);
            await this.SecondFrame.FadeTo(1, 200);
            GoToNextPage("Prawdzie czy Fałsz");
        }
        async void OnTappedThirdFrame(object sender, EventArgs e)
        {
            // Do stuff
            await this.ThirdFrame.FadeTo(0, 200);
            await this.ThirdFrame.FadeTo(1, 200);
            GoToNextPage("Sali treningowej");
        }
        async void OnTappedFourthFrame(object sender, EventArgs e)
        {
            // Do stuff
            await this.FourthFrame.FadeTo(0, 200);
            await this.FourthFrame.FadeTo(1, 200);
            GoToNextPage("Egzaminie");
            
        }
        async void GoToNextPage(string name)
        {
            await Navigation.PushModalAsync(new SecondPage(name));
        }
    }
}