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

namespace WPF_Ejemplo_14_04_Canvas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int dirInicial = 100;

        public MainWindow()
        {
            InitializeComponent();
            //EmpezarJuego();
        }
        /*
        private void EmpezarJuego()
        {
            dirInicial = rnd.Next(1);

            while(true)
            { 
                if(dirInicial == 0)
                    Canvas.SetLeft(Bola, Canvas.GetLeft(Bola) - 1);
                if(dirInicial == 1)
                    Canvas.SetLeft(Bola, Canvas.GetLeft(Bola) + 1);
            }
        }
        */
        private void BtnAnadirContenido_Click(object sender, RoutedEventArgs e)
        {
            Rectangle nuevoRect = new Rectangle();
            nuevoRect.Width = 150;
            nuevoRect.Height = 150;
            nuevoRect.Fill = new SolidColorBrush(Colors.Blue);

            if (!cnvPrincipal.Children.Contains(nuevoRect))
            {
                cnvPrincipal.Children.Add(nuevoRect);

                Canvas.SetTop(nuevoRect, dirInicial);
                Canvas.SetLeft(nuevoRect, dirInicial);

                dirInicial += 20;
            }
        }

        private void EjemploVentana()
        {
            /*
            winVentana.Activate();
            winVentana.Hide();
            winVentana.Close();
            winVentana.Show();
            winVentana.ShowDialog();
            */

            // Eventos
            winVentana.Activated += WinVentana_Activated;
            
        }

        // Se produce cuando se activa la ventana
        private void WinVentana_Activated(object sender, EventArgs e)
        {
            
        }

        private void WinVentana_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
