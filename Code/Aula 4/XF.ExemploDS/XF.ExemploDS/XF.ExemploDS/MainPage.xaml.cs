using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ExemploDS.App_Code;

namespace XF.ExemploDS
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var resultado = DependencyService.Get<ISistemaOperacional>();

            DisplayAlert("Sistema", $"A plataforma em execução é {resultado}", "Ok");
        }
    }
}
