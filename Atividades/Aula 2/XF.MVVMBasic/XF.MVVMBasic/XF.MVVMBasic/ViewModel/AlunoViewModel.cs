using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF.MVVMBasic.Model;
using XF.MVVMBasic.View;

namespace XF.MVVMBasic.ViewModel
{
    public class AlunoViewModel : INotifyPropertyChanged
    {
        #region Propriedades

        public List<Aluno> Alunos { get; set; }
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        #endregion

        public ICommand OnNovoCMD { get; private set; }

        public AlunoViewModel(Aluno aluno)
        {
            OnNovoCMD = new Command(OnNovo);
        }

        private async void OnNovo()
        {
            // App.AlunoVM.AlunoModel.Nome = App.AlunoVM.AlunoModel.Email = App.AlunoVM.AlunoModel.RM = string.Empty;
            //App.AlunoVM.AlunoModel = new Aluno();
            await App.Current.MainPage.Navigation.PushAsync(new NovoAlunoView() { BindingContext = App.AlunoVM });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Aluno GetAluno()
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "542621",
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com"
            };
            return aluno;
        }
    }
}
