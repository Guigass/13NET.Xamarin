using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.PassParameter
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MCDetalheView : ContentPage
	{
        public MCDetalheView()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<MCHomeView, Contato>(this,
                MessagingViewModel.Navegacao.Alterar.ToString(),
               (navegarParametro, param) =>
               {
                   BindingContext = param;
                   MessagingCenter.Unsubscribe<MCHomeView, Contato>(
                       this, MessagingViewModel.Navegacao.Alterar.ToString());
               });
        }
    }
}