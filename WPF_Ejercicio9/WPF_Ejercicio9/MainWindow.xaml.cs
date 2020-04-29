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
//----------------
using System.IO;

namespace WPF_Ejercicio9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MAXDADO = 6;
        private BitmapImage[] arrayImgDados = new BitmapImage[6];
        private int[] historialDados = new int[MAXDADO];
        private Random rnd = new Random();
        private int tirada = 0;
        private int totalTiradas = 0;

        public MainWindow()
        {
            InitializeComponent();
            LlenarArrayImagenesDados();
        }

        private void LlenarArrayImagenesDados()
        {
            DirectoryInfo tmp = new DirectoryInfo(@".\..\..\ImagenesDados\");

            for (int i = 0; i < tmp.GetFiles().Length; i++)
            {
                arrayImgDados[i] = new BitmapImage(new Uri(tmp.GetFiles()[i].FullName, UriKind.RelativeOrAbsolute));
            }
        }

        private void BtnTirar_Click(object sender, RoutedEventArgs e)
        {
            Tirar(1);
        }

        private void BtnAutomatico_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbxNTiradas.Text, out int tmpTiradaAuto))
                return;

            Tirar(tmpTiradaAuto);
        }

        private void Tirar(int nVeces)
        {
            for (int i = 0; i < nVeces; i++)
            {
                tirada = rnd.Next(MAXDADO);
                historialDados[tirada]++;
                imgDado.Source = arrayImgDados[tirada];
                totalTiradas++;
                MostrarResultados();
            }
            
            tbkTotalTiradas.Text = totalTiradas.ToString();
            MostrarEstadisticas();
        }

        private void MostrarEstadisticas()
        {
            tbkEstadisticas.Inlines.Clear();

            for (int i = 0; i < MAXDADO; i++)
            {
                int nNumDado = historialDados[i];
                double porcentajeDados = ((nNumDado * 100) / totalTiradas);
                tbkEstadisticas.Inlines.Add(string.Format("{0} -> {1} -> {2} %\n",
                                            (i + 1),
                                            nNumDado,
                                            porcentajeDados
                                            ));
            }
        }

        private void MostrarResultados()
        {
            tbkResultados.Inlines.Add(string.Format("{0} -> {1}\n", totalTiradas, tirada+1));
            scrResultados.ScrollToEnd();
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            totalTiradas = 0;
            historialDados = new int[MAXDADO];
            tbkTotalTiradas.Inlines.Clear();
            tbkResultados.Inlines.Clear();
            tbkEstadisticas.Inlines.Clear();
        }

        private void CbxSimular_Checked(object sender, RoutedEventArgs e)
        {
            imgDado.Source = arrayImgDados[rnd.Next(MAXDADO)];
        }
    }
}
