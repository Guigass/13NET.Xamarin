using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage()
		{
            Aluno aluno = InitAluno("Anderson Silva", "anderson@ufc.com");

            BindingContext = aluno;

			InitializeComponent();
		}

        private Aluno InitAluno(string nome, string email)
        {
            return new Aluno
            {
                id = Guid.NewGuid(),
                Nome = nome,
                Email = email
            };
        }
    }
}