using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_JAGS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void suma(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);

            int resultado = n1 + n2;

            Respuesta.Text = resultado.ToString();
        }

        private void resta(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);

            int resultado = n1 - n2;

            Respuesta.Text = resultado.ToString();
        }

        private void multiplicacion(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);

            int resultado = n1 * n2;

            Respuesta.Text = resultado.ToString();
        }

        private void division(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);

            int resultado = n1 / n2;

            Respuesta.Text = resultado.ToString();
        }

    }
}
