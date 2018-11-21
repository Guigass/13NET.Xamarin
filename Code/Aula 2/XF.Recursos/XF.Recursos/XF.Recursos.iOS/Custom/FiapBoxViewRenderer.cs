using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.Recursos.CustomControl;
using XF.Recursos.iOS.Custom;

[assembly: ExportRenderer(typeof(FiapButton), typeof(FiapButtonRenderer))]
namespace XF.Recursos.iOS.Custom
{
    public class FiapBoxViewRenderer : BoxRenderer
    {
        public override void Draw(CGRect rect)
        {
            FiapBoxView boxView = (FiapBoxView)Element;
            using (var context = UIGraphics.GetCurrentContext())
            {
                context.SetFillColor(boxView.Color.ToCGColor());
                context.SetStrokeColor(boxView.CorDaBorda.ToCGColor());
                context.SetLineWidth((float)boxView.EspessuraDaBorda);

                var ret = Bounds.Inset((int)boxView.EspessuraDaBorda,
                    (int)boxView.EspessuraDaBorda);

                var path = CGPath.FromRect(ret);
                context.AddPath(path);
                context.DrawPath(CGPathDrawingMode.FillStroke);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == FiapBoxView.EspessuraDaBordaProperty.PropertyName)
            {
                SetNeedsDisplay();
            }
        }
    }
}