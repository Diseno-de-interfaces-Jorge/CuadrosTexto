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
            NombreTextBox.Tag = MensajeAyudaUnoTextBlock;
            ApellidoTextBox.Tag = MensajeAyudaDosTextBlock;
            MensajeAyudaUnoTextBlock.Text = "Nombre del cliente";
            MensajeAyudaDosTextBlock.Text = "Apellido del cliente";

        }

        private void MostrarAyuda(object sender, KeyEventArgs e)
        {
            TextBox texblockInput = (TextBox)sender;
            TextBlock mensajeAyuida = (TextBlock)texblockInput.Tag;
            if (e.Key == Key.F1)
            {
                if(mensajeAyuida.Visibility == Visibility.Hidden)
                {
                    mensajeAyuida.Visibility = Visibility.Visible;

                }
                else
                {
                    mensajeAyuida.Visibility = Visibility.Hidden;
                }
            }
        }


        private void ComprobarEdad (object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            int numero;// esto se puede poner en el TryParse "out_"
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

    }
}
