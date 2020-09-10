
using Tituto.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



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
            FirstQuiz.Text = "Rekord: " + val.FirstQuizPkt1;
            SecondQuiz.Text = "Rekord: " + val.SecondQuizPkt1;
            ThirdQuiz.Text = "Rekord: " + val.ThirdQuizPkt1;
            FourthQuiz.Text = "Rekord: "+ val.FourthQuizPkt1;




        }
    }
}