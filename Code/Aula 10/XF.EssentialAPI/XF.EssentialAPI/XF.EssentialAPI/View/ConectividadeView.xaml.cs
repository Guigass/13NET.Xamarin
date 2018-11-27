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
	public partial class ConectividadeView : ContentPage
	{
        public string RedeDeAcesso =>
            Connectivity.NetworkAccess.ToString();

        public string Perfil
        {
            get
            {
                var perfis = string.Empty;
                foreach (var p in Connectivity.Profiles)
                    perfis += "\n" + p.ToString();
                return perfis;
            }
        }

        public ConectividadeView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Connectivity.ConnectivityChanged += OnConectividade;
        }

        protected override void OnDisappearing()
        {
            Connectivity.ConnectivityChanged -= OnConectividade;
            base.OnDisappearing();
        }

        void OnConectividade(object sender, ConnectivityChangedEventArgs e)
        {
            lblPerfil.Text = Perfil;
            lblRede.Text = RedeDeAcesso;
        }
    }
}