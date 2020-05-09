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

//---------------
using System.Windows.Threading;

namespace WPF_Ejemplo_14_04_Canvas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int dirInicial = 100;

        // Juego de la pelota
        double posXPelota;
        double posYPelota;
        double winAlto;
        double winAncho;
        double avanceXPelota = 10;
        double avanceYPelota = 10;
        DispatcherTimer tiempo = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            tiempo.Interval = TimeSpan.FromMilliseconds(20);
            tiempo.Tick += Tiempo_Tick;
            winAlto = cvnPanel.Height;
            winAncho = cvnPanel.Width;
            posXPelota = Canvas.GetLeft(Bola);
            posYPelota = Canvas.GetTop(Bola);
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            EmpezarJuego();
        }

        private void EmpezarJuego()
        {
            posXPelota += avanceXPelota;
            posYPelota += avanceYPelota;


            if (posXPelota >= (winAncho - Bola.Width))
                avanceXPelota *= -1;
            if (posXPelota <= 0)
                avanceXPelota *= -1;

            if (posYPelota >= (winAlto - Bola.Height))
                avanceYPelota *= -1;
            if (posYPelota <= 0)
                avanceYPelota *= -1;

            Canvas.SetTop(Bola, posYPelota);
            Canvas.SetLeft(Bola, posXPelota);

            if (Colision())
                Barra.Opacity = 0.5;
            else
                Barra.Opacity = 1;
        }

        private bool Colision()
        {
            Rect pelota = new Rect();
            Rect barra = new Rect();

            pelota.Location = new Point(posXPelota, posYPelota);
            pelota.Size = Bola.RenderSize;

            barra.Location = new Point(Canvas.GetLeft(Barra), Canvas.GetTop(Barra));
            barra.Size = Barra.RenderSize;

            return pelota.IntersectsWith(barra);
        }

        /*
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
        */
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
            //e.Cancel = true;
        }
        
        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Start();
        }

        private void BtnDetener_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
        }
    }
}
