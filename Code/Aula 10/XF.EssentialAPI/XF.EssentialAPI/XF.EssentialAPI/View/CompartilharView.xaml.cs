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
	public partial class CompartilharView : ContentPage
	{
		public CompartilharView ()
		{
			InitializeComponent ();
		}

        private async void OnTransferir_Clicked(object sender, EventArgs e)
        {
            await DataTransfer.RequestAsync(new ShareTextRequest
            {
                Subject = txtAssunto.Text,
                Text = swtTexto.IsToggled ? txtTexto.Text : null,
                Uri = swtUri.IsToggled ? txtUri.Text : null,
                Title = txtTitulo.Text
            });
        }
    }
}