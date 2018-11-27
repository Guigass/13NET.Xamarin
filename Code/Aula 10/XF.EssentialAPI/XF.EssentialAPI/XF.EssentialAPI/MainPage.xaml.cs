using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.EssentialAPI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void OnPhoneClass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.PhoneView());
        }

        private void OnConectividade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ConectividadeView());
        }

        private void OnCompartilhar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CompartilharView());
        }

        private void OnBateria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.BateriaView());
        }

        private void OnCompasso_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CompassoView());
        }
    }
}
