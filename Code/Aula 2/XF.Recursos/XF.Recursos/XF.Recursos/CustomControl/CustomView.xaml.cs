using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.CustomControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomView : ContentPage
	{
		public CustomView ()
		{
			InitializeComponent();
		}

        private void FiapButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Clique OK", "OK");
        }
    }

    public class FiapButton : Button { }

    public class ColorFromRGBExtension : IMarkupExtension
    {
        public int Vermelho { get; set; }
        public int Verde { get; set; }
        public int Azul { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgb(Vermelho, Verde, Azul);
        }
    }

    public class FiapBoxView : BoxView
    {
        public static readonly BindableProperty CorDaBordaProperty =
            BindableProperty.Create<FiapBoxView, Color>(p => p.CorDaBorda, default(Color));

        public Color CorDaBorda
        {
            get { return (Color)GetValue(CorDaBordaProperty); }
            set { SetValue(CorDaBordaProperty, value); }
        }

        public static readonly BindableProperty EspessuraDaBordaProperty =
            BindableProperty.Create<FiapBoxView, double>(p => p.EspessuraDaBorda, default(double));

        public double EspessuraDaBorda
        {
            get { return (double)GetValue(EspessuraDaBordaProperty); }
            set { SetValue(EspessuraDaBordaProperty, value); }
        }
    }
}