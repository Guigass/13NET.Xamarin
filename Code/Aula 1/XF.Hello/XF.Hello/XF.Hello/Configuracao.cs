using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Configuracao
    {
        public bool RastrearLocalizacao { get; set; } = true;
        public bool PermitirCookies { get; set; } = false;
        public bool DisponibilizarMural { get; set; } = true;
        public bool EnviarEmail { get; set; } = false;
        public bool ReceberSMS { get; set; } = false;
    }
}
