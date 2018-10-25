using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;
using XF.Recursos.Controles;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } }
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "Home.png",
                TargetType = typeof(HomeView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                Icone = "Home.png",
                TargetType = typeof(EditorView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Picker",
                Icone = "Home.png",
                TargetType = typeof(PickerView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "List Picker View",
                Icone = "Home.png",
                TargetType = typeof(ListPickerView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Stepper View",
                Icone = "Home.png",
                TargetType = typeof(StepperView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Progresso View",
                Icone = "Home.png",
                TargetType = typeof(ProgressoView)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Exemplo",
                Icone = "Home.png",
                TargetType = typeof(Exemplo.Exemplo)
            });

            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Estilo Dinamico",
                Icone = "Home.png",
                TargetType = typeof(Estilo.DinamicoView)
            });

            lstMenu.ItemsSource = menuItems;
        }
    }
}