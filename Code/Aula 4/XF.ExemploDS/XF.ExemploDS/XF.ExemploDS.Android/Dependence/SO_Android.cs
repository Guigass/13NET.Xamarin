using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XF.ExemploDS.App_Code;
using XF.ExemploDS.Droid.Dependence;

[assembly: Dependency(typeof(SO_Android))]
namespace XF.ExemploDS.Droid.Dependence
{
    public class SO_Android : ISistemaOperacional
    {
        public string Plataforma()
        {
            return "Android";
        }
    }
}