using System;
using System.Collections.Generic;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.ViewModel
{
    public class AlunoViewModel
    {
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        public AlunoViewModel(Aluno aluno)
        {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }

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
