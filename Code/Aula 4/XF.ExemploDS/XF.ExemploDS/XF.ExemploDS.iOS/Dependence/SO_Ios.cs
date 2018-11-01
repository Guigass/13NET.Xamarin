using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XF.ExemploDS.App_Code;

namespace XF.ExemploDS.iOS.Dependence
{
    public class SO_Ios : ISistemaOperacional
    {
        public string Plataforma()
        {
            return "iPhone Ios";
        }
    }
}