using Microsoft.Win32;
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
//-------------------

namespace WPF_Ejemplo_07_05
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

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {
            Title = "Se ejecuto salvar todos los datos";
        }

        private void BtnAbrirImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.DefaultExt = "*.png";
            ventana.Filter = "*.png|*.png |*.jpg|*.jpg";
            
            if (ventana.ShowDialog() == true)
            {
                BitmapImage imagen = new BitmapImage(new Uri(ventana.FileName, UriKind.RelativeOrAbsolute));
                imgImagen.Source = imagen;
                imgImagen.ToolTip = ventana.FileName;
            }
        }
    }
}
