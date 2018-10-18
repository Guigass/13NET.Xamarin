using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF.Recursos.Exemplo
{
    public class ExemploViewModel
    {
        public ICommand EventoOK { get; set; }
        public EventoAdicionar EventoADD;
        public ExemploViewModel()
        {
            EventoOK = new Command(Mensagem);
            EventoADD = new EventoAdicionar(this);
        }

        public void Mensagem()
        {
            App.Current.MainPage.DisplayAlert("Olá", "Teste", "OK");
        }
    }

    public class EventoAdicionar : ICommand
    {
        ExemploViewModel viewModel;

        public EventoAdicionar(ExemploViewModel vm)
        {
            viewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.Mensagem();
        }
    }
}
