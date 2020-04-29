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

namespace WPF_Ejercicio11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FontStyle[] estilo = { FontStyles.Italic, FontStyles.Normal, FontStyles.Oblique };
        private FontWeight[] espesor = { FontWeights.Normal, FontWeights.Bold, FontWeights.Light };

        private List<FontFamily> fuentes = Fonts.SystemFontFamilies.ToList();

        private List<Rectangle> colorFuente = new List<Rectangle>();
        private List<Rectangle> colorFondo = new List<Rectangle>();

        private Color tmpColor = new Color();
        private Random rnd = new Random();
        private const int MAXCOLORES = 10;

        // Valores por defecto
        private FontFamily fuentePorDefecto = new FontFamily("Segoe UI");
        private SolidColorBrush colorFuentePorDefecto = new SolidColorBrush(Colors.Black);
        private SolidColorBrush colorFondoPorDefecto = new SolidColorBrush(Colors.White);
        private FontStyle estiloPorDefecto = FontStyles.Normal;

        public MainWindow()
        {
            InitializeComponent();
            Inicar();
        }

        private void Inicar()
        {
            // COLORES
            for (int i = 0; i < MAXCOLORES; i++)
            {
                tmpColor = Color.FromRgb((byte)rnd.Next(Colors.Red.R), (byte)rnd.Next(Colors.Green.G), (byte)rnd.Next(Colors.Blue.B));
                Rectangle tmp = new Rectangle();
                tmp.Height = 10;
                tmp.Width = 30;
                tmp.Fill = new SolidColorBrush(tmpColor);
                colorFuente.Add(tmp);
                tmpColor = Color.FromRgb((byte)rnd.Next(Colors.Red.R), (byte)rnd.Next(Colors.Green.G), (byte)rnd.Next(Colors.Blue.B));
                tmp = new Rectangle();
                tmp.Height = 10;
                tmp.Width = 30;
                tmp.Fill = new SolidColorBrush(tmpColor);
                colorFondo.Add(tmp);
            }
            lbxColorFuente.ItemsSource = colorFuente;
            lbxColorFondo.ItemsSource = colorFondo;
            // FUENTES
            lbxFuentes.ItemsSource = fuentes;
            //ESTILOS
            lbxEstilos.ItemsSource = estilo;
            lbxEspesor.ItemsSource = espesor;
        }

        private void CambiarFuente()
        {
            if(lbxFuentes.SelectedItem != null)
                lblCambiaFuente.FontFamily = (FontFamily)lbxFuentes.SelectedItem;
        }

        private void CambiarColor()
        {
            if (lbxColorFondo.SelectedItem != null)
                lblCambiaColor.Background = ((Rectangle)lbxColorFondo.SelectedItem).Fill;
            if (lbxColorFuente.SelectedItem != null)
                lblCambiaColor.Foreground = ((Rectangle)lbxColorFuente.SelectedItem).Fill;
        }
        
        private void CambiarEstilo()
        {
            if (lbxEstilos.SelectedItem != null)
                lblCambiaAspecto.FontStyle = (FontStyle)lbxEstilos.SelectedItem;
            if (lbxEspesor.SelectedItem != null)
                lblCambiaAspecto.FontWeight = (FontWeight)lbxEspesor.SelectedItem;
        }

        private void LblCambiaFuente_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CambiarFuente();
        }

        private void LblCambiaColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CambiarColor();
        }

        private void LblCambiaAspecto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CambiarEstilo();
        }
    }
}
