using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Estilo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DinamicoView : ContentPage
	{
        bool temaPadrao;

        public DinamicoView()
        {
            InitializeComponent();

            temaPadrao = true;
            Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
        }

        private void OnClick_AlterarEstilo(object sender, EventArgs args)
        {
            if (temaPadrao)
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoVermelho"];
                temaPadrao = false;
            }
            else
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
                temaPadrao = true;
            }
        }

        private bool desligarRelogio = false;
        protected override void OnAppearing()
        {
            desligarRelogio = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Resources["Hora"] = DateTime.Now.ToString();
                return !desligarRelogio;
            });
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            desligarRelogio = true;
            base.OnDisappearing();
        }
    }
}