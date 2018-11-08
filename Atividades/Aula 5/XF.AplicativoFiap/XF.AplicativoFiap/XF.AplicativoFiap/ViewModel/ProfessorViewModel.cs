using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF.AplicativoFiap.Model;

namespace XF.AplicativoFiap.ViewModel
{
    public class ProfessorViewModel : INotifyPropertyChanged
    {
        #region Propriedades

        public Professor ProfessorModel { get; set; }

        private Professor selecionado;
        public Professor Selecionado
        {
            get { return selecionado; }
            set
            {
                selecionado = value as Professor;
                EventPropertyChanged();
            }
        }

        private string pesquisaPorNome;
        public string PesquisaPorNome
        {
            get { return pesquisaPorNome; }
            set
            {
                if (value == pesquisaPorNome) return;

                pesquisaPorNome = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PesquisaPorNome)));
                AplicarFiltro();
            }
        }

        public List<Professor> CopiaListaProfessores;
        public ObservableCollection<Professor> Professores { get; set; } = new ObservableCollection<Professor>();

        // UI Events
        public OnAdicionarProfessorCMD OnAdicionarProfessorCMD { get; }
        public OnEditarProfessorCMD OnEditarProfessorCMD { get; }
        public OnDeleteProfessorCMD OnDeleteProfessorCMD { get; }
        public ICommand OnSairCMD { get; private set; }
        public ICommand OnNovoCMD { get; private set; }

        #endregion

        public bool isAtualizado = true;
        public ProfessorViewModel()
        {
            
            OnAdicionarProfessorCMD = new OnAdicionarProfessorCMD(this);
            OnEditarProfessorCMD = new OnEditarProfessorCMD(this);
            OnDeleteProfessorCMD = new OnDeleteProfessorCMD(this);
            OnSairCMD = new Command(OnSair);
            OnNovoCMD = new Command(OnNovo);

            CopiaListaProfessores = new List<Professor>();
            Carregar();
        }

        public async Task<bool> Carregar()
        {
            CopiaListaProfessores = await ProfessorRepository.GetProfessoresSqlAzureAsync();
            AplicarFiltro();

            return true;
        }

        private void AplicarFiltro()
        {
            Professores.Clear();

            if (pesquisaPorNome == null)
                pesquisaPorNome = "";

            var resultado = CopiaListaProfessores.Where(n => n.Nome.ToLowerInvariant()
                                .Contains(PesquisaPorNome.ToLowerInvariant().Trim())).ToList();

            for (int index = 0; index < resultado.Count; index++)
            {
                var item = resultado[index];
                Professores.Insert(index, item);
            }

            isAtualizado = false;
        }

        public async void Adicionar(Professor paramProfessor)
        {
            if ((paramProfessor == null) || (string.IsNullOrWhiteSpace(paramProfessor.Nome)))
                await App.Current.MainPage.DisplayAlert("Atenção", "O campo nome é obrigatório", "OK");

            var sucesso = await ProfessorRepository.PostProfessorSqlAzureAsync(paramProfessor);

            if (sucesso)
            {
                CopiaListaProfessores.Add(paramProfessor);
                Carregar();

                await App.Current.MainPage.Navigation.PopAsync();
            }
            else
                await App.Current.MainPage.DisplayAlert("Falhou", "Desculpe, ocorreu um erro inesperado =(", "OK");
        }

        public async void Editar()
        {
            await App.Current.MainPage.Navigation.PushAsync(
                new View.Professor.NovoProfessorView() { BindingContext = App.ProfessorVM });
        }

        public async void Remover()
        {
            if (await App.Current.MainPage.DisplayAlert("Atenção?", string.Format("Tem certeza que deseja remover o {0}?", Selecionado.Nome), "Sim", "Não"))
            {
                var sucesso = await ProfessorRepository.DeleteProfessorSqlAzureAsync(Selecionado.Id.ToString());

                if (sucesso)
                {
                    CopiaListaProfessores.Remove(Selecionado);
                    Carregar();
                }
                else
                    await App.Current.MainPage.DisplayAlert("Falhou", "Desculpe, ocorreu um erro inesperado =(", "OK");
            }
        }

        private async void OnSair()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        private void OnNovo()
        {
            App.ProfessorVM.Selecionado = new Model.Professor();
            App.Current.MainPage.Navigation.PushAsync(
                new View.Professor.NovoProfessorView() { BindingContext = App.ProfessorVM });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class OnAdicionarProfessorCMD : ICommand
    {
        private ProfessorViewModel professorVM;
        public OnAdicionarProfessorCMD(ProfessorViewModel paramVM)
        {
            professorVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void AdicionarCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            professorVM.Adicionar(parameter as Professor);
        }
    }

    public class OnEditarProfessorCMD : ICommand
    {
        private ProfessorViewModel professorVM;
        public OnEditarProfessorCMD(ProfessorViewModel paramVM)
        {
            professorVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void EditarCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter) => (parameter != null);
        public void Execute(object parameter)
        {
            App.ProfessorVM.Selecionado = parameter as Professor;
            professorVM.Editar();
        }
    }

    public class OnDeleteProfessorCMD : ICommand
    {
        private ProfessorViewModel professorVM;
        public OnDeleteProfessorCMD(ProfessorViewModel paramVM)
        {
            professorVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void DeleteCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter) => (parameter != null);
        public void Execute(object parameter)
        {
            App.ProfessorVM.Selecionado = parameter as Professor;
            professorVM.Remover();
        }
    }
}