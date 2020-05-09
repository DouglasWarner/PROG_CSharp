using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
//--------------------
using System.Windows.Threading;

namespace WPF_Ejercicio17
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Juego de la pelota
        DispatcherTimer tiempo = new DispatcherTimer();
        int vidas = 3;
        bool empezarPartida = false;
        double ticksPorSegundo = 40;
        //      Pelota
        double posXPelota;
        double posYPelota;
        double winAlto;
        double winAncho;
        double avanceXPelota = 5;
        double avanceYPelota = 5;
        //      Barra
        double posXBarra;
        double movimientoBarra = 10;
        // Puntuaciones
        int nJugador = 1;
        TimeSpan segundosPasadosJuego;
        int puntosPorSegundo = 2;
        int puntosPorDificultad = 1;

        public MainWindow()
        {
            InitializeComponent();
            tiempo.Interval = TimeSpan.FromMilliseconds(ticksPorSegundo);
            tiempo.Tick += Tiempo_Tick;
            winAlto = cvnPanel.Height;
            winAncho = cvnPanel.Width;
            posXPelota = Canvas.GetLeft(Bola);
            posYPelota = Canvas.GetTop(Bola);
            posXBarra = Canvas.GetLeft(Barra);

            tbkVidas.Text = vidas.ToString();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if(vidas > 0)
                EmpezarJuego();
            if (vidas == 0)
            {
                MessageBox.Show("Perdiste todas las vidas\nPulsa reiniciar para volver a jugar.", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                ContabilizarPuntos();
                tbrIniciar.Click -= MtiIniciar_Click;
            }
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
            {
                vidas--;
                ReiniciarPosPelota();
            }
            if (posYPelota <= 0)
                avanceYPelota *= -1;

            Canvas.SetTop(Bola, posYPelota);
            Canvas.SetLeft(Bola, posXPelota);

            Colision();

            tbkVidas.Text = vidas.ToString();
        }

        private void Colision()
        {
            Rect pelota = new Rect();
            Rect barra = new Rect();

            pelota.Location = new Point(posXPelota, posYPelota);
            pelota.Size = Bola.RenderSize;

            barra.Location = new Point(Canvas.GetLeft(Barra), Canvas.GetTop(Barra));
            barra.Size = Barra.RenderSize;

            if (pelota.IntersectsWith(barra))
            {
                if ((pelota.Left == barra.Right ||  pelota.Right == barra.Left) && pelota.Bottom != barra.Top)
                    avanceXPelota *= -1;
                if (pelota.Bottom == barra.Top)
                    avanceYPelota *= -1;
            }
        }

        private void ReiniciarPosPelota()
        {
            posXPelota = 100;
            posYPelota = 100;

            Canvas.SetTop(Bola, posYPelota);
            Canvas.SetLeft(Bola, posXPelota);

            tiempo.Stop();
        }

        private void ContabilizarPuntos()
        {
            int puntos = new TimeSpan(DateTime.Now.Ticks).Subtract(segundosPasadosJuego).Seconds;

            puntos = (puntos * puntosPorDificultad) + (puntos * puntosPorSegundo);

            cbxPuntuacion.Items.Add(string.Format("Jugador {0} ; Puntos : {1} ; Dificultad : {2}", nJugador++.ToString("00"), puntos.ToString("000"), 
                (mtiFacil.IsChecked) ? "Facil" : (mtiNormal.IsChecked) ? "Normal" : (mtiDificil.IsChecked) ? "Dificil" : ""));
        }

        private void Barra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                if (Canvas.GetLeft(Barra) < (winAncho - Barra.Width))
                    posXBarra += movimientoBarra;
            }
            if (e.Key == Key.Left)
            {
                if (Canvas.GetLeft(Barra) > 0)
                    posXBarra -= movimientoBarra;
            }
            Canvas.SetLeft(Barra, posXBarra);
        }

        private void MtiIniciar_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Start();
            if(!empezarPartida)
                segundosPasadosJuego = new TimeSpan(DateTime.Now.Ticks);

            empezarPartida = true;
        }

        private void MtiDetener_Click(object sender, RoutedEventArgs e)
        {
            tiempo.Stop();
        }

        private void MtiReinicar_Click(object sender, RoutedEventArgs e)
        {
            ReiniciarPosPelota();
            vidas = 3;
            tbkVidas.Text = vidas.ToString();
            empezarPartida = false;
            tbrIniciar.Click += MtiIniciar_Click;
        }
        
        private void MtiFacil_Click(object sender, RoutedEventArgs e)
        {
            mtiFacil.IsChecked = true;
            mtiNormal.IsChecked = false;
            mtiDificil.IsChecked = false;

            puntosPorDificultad = 1;
            tiempo.Interval = TimeSpan.FromMilliseconds(ticksPorSegundo);
        }

        private void MtiNormal_Click(object sender, RoutedEventArgs e)
        {
            mtiFacil.IsChecked = false;
            mtiNormal.IsChecked = true;
            mtiDificil.IsChecked = false;

            puntosPorDificultad = 2;
            tiempo.Interval = TimeSpan.FromMilliseconds(ticksPorSegundo - 10);
        }

        private void MtiDificil_Click(object sender, RoutedEventArgs e)
        {
            mtiFacil.IsChecked = false;
            mtiNormal.IsChecked = false;
            mtiDificil.IsChecked = true;

            puntosPorDificultad = 3;
            tiempo.Interval = TimeSpan.FromMilliseconds(ticksPorSegundo - 30);
        }

        private void MtiAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe ventana = new AcercaDe();

            ventana.ShowDialog();
        }
    }
}
