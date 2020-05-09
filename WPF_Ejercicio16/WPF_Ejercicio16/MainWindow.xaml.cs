using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WPF_Ejercicio16
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MAXDADO = 6;
        
        private int puntosTirada;
        private int puntosJugador;
        private Random rnd;
        private bool esPrimerTiro;
        private BitmapImage[] arrayImgDados = new BitmapImage[6];

        public MainWindow()
        {
            InitializeComponent();

            Inicializar();
            LlenarArrayImagenesDados();
        }

        private void Inicializar()
        {
            puntosTirada = 0;
            puntosJugador = 0;
            rnd = new Random();
            esPrimerTiro = true;
        }

        private void LlenarArrayImagenesDados()
        {
            DirectoryInfo tmp = new DirectoryInfo(@".\..\..\Dados\");

            for (int i = 0; i < tmp.GetFiles().Length; i++)
            {
                arrayImgDados[i] = new BitmapImage(new Uri(tmp.GetFiles()[i].FullName, UriKind.RelativeOrAbsolute));
            }
        }

        private void TirarDado_Click(object sender, RoutedEventArgs e)
        {
            Tirar();
        }

        private void Tirar()
        {
            int tmpTirada = 0;

            tmpTirada = rnd.Next(1, MAXDADO + 1);
            imgDado1.Source = arrayImgDados[tmpTirada-1];
            puntosTirada = tmpTirada;

            tmpTirada = rnd.Next(1, MAXDADO + 1);
            imgDado2.Source = arrayImgDados[tmpTirada-1];
            puntosTirada += tmpTirada;
            
            switch (ComprobarPuntos(puntosTirada))
            {
                case 1:
                    tbkMensaje.Text = "Ganaste";
                    btnTirar.IsEnabled = false;
                    break;
                case -1:
                    tbkMensaje.Text = "Perdiste";
                    btnTirar.IsEnabled = false;
                    break;
                case 0:
                    if(esPrimerTiro)
                        puntosJugador = puntosTirada;
                    tbkMensaje.Text = "Sigue tirando";
                    break;
                default:
                    break;
            }

            esPrimerTiro = false;
            tbkPuntosJugador.Text = puntosJugador.ToString();
            tbkResultados.Inlines.Add(new Run(puntosTirada.ToString() + "\n"));

            if (scrResultados.ScrollableHeight == scrResultados.VerticalOffset)
                scrResultados.ScrollToBottom();
        }

        /// <summary>
        /// Comprueba los puntos obtenidos en cada ronda.
        /// </summary>
        /// <param name="puntos">puntos obtenidos de la tirada de dos dados</param>
        /// <returns>Ganar: devuelve 1. Perder: devuelve -1. Sigue tirando: devuelve 0.</returns>
        private int ComprobarPuntos(int puntos)
        {
            if(esPrimerTiro)
            {
                if (puntos == 2 || puntos == 3 || puntos == 12)
                    return -1;
                else if (puntos == 7 || puntos == 11)
                    return 1;
                else
                    return 0;
            }
            else
            {
                if (puntos == puntosJugador)
                    return 1;
                else if (puntos == 7)
                    return -1;
                else
                    return 0;
            }
        }

        private void BtnReiniciar_Click(object sender, RoutedEventArgs e)
        {
            btnTirar.IsEnabled = true;
            tbkMensaje.Inlines.Clear();
            tbkPuntosJugador.Inlines.Clear();
            tbkResultados.Inlines.Clear();

            Inicializar();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quieres salir?", "Saliendo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}

// Codigos
/*          Manera de reinicar la aplicación
 *          Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();*/
