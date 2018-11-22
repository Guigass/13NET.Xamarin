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

        private void OnControle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ControleView());
        }

        private void OnLocalizacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.LocalizacaoView());
        }

        private void OnMarker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.MarcarView());
        }

        private void OnAreaDemarcada_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.MapaDemarcadoView());
        }

        private void OnMarkerCustom_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.MapaPinCustom());
        }

        private void OnGps_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.GPSView());
        }
    }
}
