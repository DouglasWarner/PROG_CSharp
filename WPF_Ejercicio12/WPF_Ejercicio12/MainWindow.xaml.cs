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

namespace WPF_Ejercicio12
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double cRojo = 0;
        private double cVerde = 0;
        private double cAzul = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScbRojo_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cRojo = scbRojo.Value;
            CambiarColorRectangulo();
        }

        private void ScbVerde_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cVerde = scbVerde.Value;
            CambiarColorRectangulo();
        }

        private void ScbAzul_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cAzul = scbAzul.Value;
            CambiarColorRectangulo();
        }

        private void CambiarColorRectangulo()
        {
            recColor.Fill = new SolidColorBrush(Color.FromArgb(200,(byte)cRojo, (byte)cVerde, (byte)cAzul));
        }
    }
}
