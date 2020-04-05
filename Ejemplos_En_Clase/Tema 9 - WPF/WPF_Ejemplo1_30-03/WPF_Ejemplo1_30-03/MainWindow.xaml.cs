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

//using System.Windows.UIElement; Clase padre de todos los controles.

namespace WPF_Ejemplo1_30_03
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool pulsado = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPulsame_Click(object sender, RoutedEventArgs e)
        {
            //winPrincipal.Background = (pulsado) ? Brushes.Red : Brushes.Blue;
            btnPulsame.Background = (pulsado) ? Brushes.Red : Brushes.Blue;
            pulsado = !pulsado;
        }
    }
}
