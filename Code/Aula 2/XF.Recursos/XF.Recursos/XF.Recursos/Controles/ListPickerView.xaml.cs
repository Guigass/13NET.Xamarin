using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPickerView : ContentPage
	{
        private Dictionary<int, string> cores = new Dictionary<int, string>
        {
            { 1, "#008000" },
            { 2, "#0000FF" },
            { 3, "#FF0000" },
            { 4, "#008000" }
        };

        public ListPickerView()
        {
            InitializeComponent();

            foreach (var item in cores.Values)
            {
                pikCor.Items.Add(item);
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxCor.Color = Color.FromHex(pikCor.SelectedItem.ToString());
        }
    }
}