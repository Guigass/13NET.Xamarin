using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.EssentialAPI.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhoneView : ContentPage
	{
		public PhoneView ()
		{
			InitializeComponent ();
		}

        private void OnLigar_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(txtTelefone.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("Atenção", $"Ocorreu um erro inesperado: {ex.Message}", "Ok");
            }
        }
    }
}