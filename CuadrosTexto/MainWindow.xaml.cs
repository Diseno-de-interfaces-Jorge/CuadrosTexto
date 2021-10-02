using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MostrarAyudaNombre(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MensajeAyudaUnoTextBlock.Text = "Nombre del cliente";
            }
        }

        private void OcultarAyudaNombre(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MensajeAyudaUnoTextBlock.Text = "";
            }
        }

        private void MostrarAyudaApellido(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MensajeAyudaDosTextBlock.Text = "Apellido del cliente";
            }
        }

        private void OcultarAyudaApellido(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MensajeAyudaDosTextBlock.Text = "";
            }
        }


        private void ComprobarEdad (object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            int numero;
            if (e.Key == Key.F2)
            {

                if (int.TryParse(texto.Text, out numero))
                {
                    MensajeAyudaTresTextBlock.Text = "";
                }
                else
                {
                    MensajeAyudaTresTextBlock.Text = "Edad no validad";
                }
            }
        }

        private void QuitarEdad(object sender, KeyEventArgs e)
        {
            MensajeAyudaTresTextBlock.Text = "";
        }


    }
}
