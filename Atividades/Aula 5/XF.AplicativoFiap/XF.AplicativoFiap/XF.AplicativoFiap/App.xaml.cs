using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.AplicativoFiap.ViewModel;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.AplicativoFiap
{
	public partial class App : Application
	{
        public static ProfessorViewModel ProfessorVM = new ProfessorViewModel();
        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new View.Professor.MainView() { BindingContext = ProfessorVM });
		}

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
