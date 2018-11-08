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
    }
}
