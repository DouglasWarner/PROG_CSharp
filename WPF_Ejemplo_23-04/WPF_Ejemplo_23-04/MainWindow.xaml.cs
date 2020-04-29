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

namespace WPF_Ejemplo_23_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] imagenes = null;
        private int posImg = 0;

        public MainWindow()
        {
            InitializeComponent();
            imagenes = System.IO.Directory.GetFiles("./../../Imagenes");

        }

        private void BtnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            imgImagenes.Source = new BitmapImage(new Uri(imagenes[posImg++], UriKind.RelativeOrAbsolute));
            if (posImg == imagenes.Length)
                btnSiguiente.IsEnabled = false;
        }

        private void BtnAnterior_Click(object sender, RoutedEventArgs e)
        {
            imgImagenes.Source = new BitmapImage(new Uri(imagenes[--posImg], UriKind.RelativeOrAbsolute));
            if (posImg == 0)
                btnAnterior.IsEnabled = false;
        }

        private void SldValor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbkValor.Text = sldValor.Value.ToString("000");

            //tbkValor.Text = e.NewValue.ToString("000");
        }
    }
}
