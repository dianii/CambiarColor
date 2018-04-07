using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CambiarColor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void ValueChanged(object sender, EventArgs e) {
            var rojo = this.sldRojo.Value;
            var verde = this.sldRojo.Value;
            var azul = this.sldAzul.Value;
            var opacidad = this.sldOpacidad.Value;
            Color bgColor = new Color(rojo, verde, azul, opacidad);
            boxColor.BackgroundColor = bgColor;
            lbDisplay.Text = colorHexa(bgColor);

        }

        private string colorHexa(Color bgColor)
        {
            int rojo = (int)(bgColor.R * 255);
            int verde= (int)(bgColor.G * 255);
            int azul = (int)(bgColor.B * 255);
            int opacidad = (int)(bgColor.A * 255);
            return$"# {rojo:x2}{verde:x2}{azul:x2}{opacidad:x2}";
        }
    }
}
