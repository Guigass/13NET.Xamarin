using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Mapas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
        }

        private void OnMapa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.MapaView());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ControleView());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LocalizacaoView());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.MarcarView());
        }
    }
}
