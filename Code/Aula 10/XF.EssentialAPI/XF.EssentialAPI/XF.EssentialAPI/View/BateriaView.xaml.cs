using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.EssentialAPI.AppCode;

namespace XF.EssentialAPI.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BateriaView : ContentPage
	{
        public BateriaViewModel BateriaVM { get; set; }
        public BateriaView()
        {
            BateriaVM = new BateriaViewModel();
            BindingContext = BateriaVM;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Battery.BatteryChanged += BateriaVM.OnBatteryChanged;
            Power.EnergySaverStatusChanged += BateriaVM.OnEnergySaverStatusChanged;
        }

        protected override void OnDisappearing()
        {
            Battery.BatteryChanged -= BateriaVM.OnBatteryChanged;
            Power.EnergySaverStatusChanged -= BateriaVM.OnEnergySaverStatusChanged;

            BateriaVM = null;

            base.OnDisappearing();
        }
    }
}