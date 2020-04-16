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

namespace WPF_Ejemplo_16_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush defecto;
        public MainWindow()
        {
            InitializeComponent();
            defecto = (SolidColorBrush)this.Background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy el botón " + ((Button)sender).Content);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy el botón " + ((Button)sender).Content);
        }

        private void RbtColor_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush colorNuevo = new SolidColorBrush(Colors.Blue);
            this.Background = colorNuevo;
        }

        private void RbtColor_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Background = defecto;
        }
    }
}
