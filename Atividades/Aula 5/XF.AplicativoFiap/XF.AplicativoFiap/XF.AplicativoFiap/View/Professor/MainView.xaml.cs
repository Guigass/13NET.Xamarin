using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.AplicativoFiap.View.Professor
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent();
		}

        private async void lstProfessores_Refreshing(object sender, EventArgs e)
        {
            await App.ProfessorVM.Carregar();

            lstProfessores.EndRefresh();
        }
    }
}