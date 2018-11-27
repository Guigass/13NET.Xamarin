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
	public partial class CompassoView : ContentPage
	{
        public CompassoView()
        {
            InitializeComponent();
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            LabelInfo.Text = $"Bússola: {e.Reading.HeadingMagneticNorth}";
            ImageArrow.Rotation = e.Reading.HeadingMagneticNorth;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Compass.Start(SensorSpeed.UI);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Compass.Stop();
        }
    }
}