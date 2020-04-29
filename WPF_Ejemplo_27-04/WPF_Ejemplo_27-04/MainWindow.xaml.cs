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
//-------------
using System.Windows.Threading;

namespace WPF_Ejemplo_27_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] lista = { "1. Málaga", "2. Cadiz", "3. Sevilla", "4. Madrid", "5. Leon", "6. Huelva", "7. Priego", "8. Estepona", "9. Fairola", "10. Cartama", "11. Coin", "12. Granada" };
        private double velocidadScroll = 0.5;
        DispatcherTimer tiempo = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            //recPanel.Opacity = sldOpacidad.Value;

            tbkTexto.Text = "";
        }

        private void BtnMostrarLista_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lista.Length; i++)
                tbkTexto.Text += lista[i]+"\n";

            // Poner la posicion vertical del Scroll
            srcTexto.ScrollToEnd();
            // Este metodo srcTexto.UpdateLayout(); se llama para forzar el Scroll en caso necesario.
        }

        private void BtnScrollAuto_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Tick += Tiempo_Tick;
            tiempo.Start();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            ScrollAuto();
        }

        private void ScrollAuto()
        {
            srcTexto.ScrollToVerticalOffset(velocidadScroll);
            velocidadScroll += 0.1;
            if (srcTexto.ScrollableHeight == srcTexto.VerticalOffset)
            {
                Title = "llego al final";
                velocidadScroll = 0.5;
                tiempo.Stop();
            }
        }

        /*
       private void SldOpacidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
       {
           recPanel.Opacity = sldOpacidad.Value;
           tbxValor.Text = sldOpacidad.Value.ToString("00.00");
       }*/
    }
}
