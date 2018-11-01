using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Recursos.App_Code
{
    public class MessagingViewModel
    {
        public enum Navegacao
        {
            Inserir,
            Alterar,
            Remover,
            Visualizar
        }
        public Navegacao TipoNavegacao { get; set; } = new Navegacao();
    }
}
