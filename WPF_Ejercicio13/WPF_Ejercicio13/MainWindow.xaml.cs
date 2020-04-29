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

namespace WPF_Ejercicio13
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double anchoTexto = 0;
        double altoTexto = 0;
        bool nuevo = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcerdaDe ventana = new AcerdaDe();

            ventana.ShowDialog();
        }

        private void WinPrincipal_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            anchoTexto = e.NewSize.Width - 20;
            altoTexto = e.NewSize.Height - stbEstado.Height - 70;

            scrollTexto.Width = anchoTexto;
            scrollTexto.Height = altoTexto;
        }

        private void MtiBarraEstado_Click(object sender, RoutedEventArgs e)
        {
            stbEstado.Visibility = (mtiBarraEstado.IsChecked) ? Visibility.Hidden : Visibility.Visible;
            scrollTexto.Height = (mtiBarraEstado.IsChecked) ? altoTexto + stbEstado.Height : 
                                                              altoTexto - stbEstado.Height;
        }

        private void MtiSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WinPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!nuevo)
            {
                if (MessageBox.Show("¿Seguro que quieres salir?", "Saliendo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    e.Cancel = true;
            }
        }

        private void MtiNuevo_Click(object sender, RoutedEventArgs e)
        {
            nuevo = true;

            MainWindow ventanaPrincipal = new MainWindow();

            ventanaPrincipal.Show();

            this.Close();

            nuevo = false;
        }

        private void MtiVentanaNuevo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipal = new MainWindow();

            ventanaPrincipal.Show();
        }
    }
}
