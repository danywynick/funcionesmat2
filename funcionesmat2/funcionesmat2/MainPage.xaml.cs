using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace funcionesmat2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_clicked(object sender, EventArgs e )
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var resultado = dato1 + dato2;
            Resultado.Text = resultado.ToString();
        }
        private void Button_clicked2(object sender, EventArgs e)
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var resultado = dato1 - dato2;
            Resultado.Text = resultado.ToString();
        }
        private void Button_clicked3(object sender, EventArgs e)
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var resultado = dato1 * dato2;
            Resultado.Text = resultado.ToString();
        }
        private void Button_clicked4(object sender, EventArgs e)
        {
            var dato1 = double.Parse(Dato1.Text);
            var dato2 = double.Parse(Dato2.Text);
            var resultado = dato1 / dato2;
            Resultado.Text = resultado.ToString();
        }
    }
}
