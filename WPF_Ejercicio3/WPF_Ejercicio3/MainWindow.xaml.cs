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

namespace WPF_Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int nIntentos = 0;
        private int numeroAleatorio = 0;
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbxVerNumero_Click(object sender, RoutedEventArgs e)
        {
            tbkVerNumero.Visibility = (cbxVerNumero.IsChecked.Value) ? Visibility.Visible : Visibility.Hidden;
        }

        private void BtnGenerarNumero_Click(object sender, RoutedEventArgs e)
        {
            btnProbar.IsEnabled = true;
            numeroAleatorio = rnd.Next(1000);
            tbkVerNumero.Text = numeroAleatorio.ToString();
            btnGenerarNumero.IsEnabled = false;
        }

        private void BtnProbar_Click(object sender, RoutedEventArgs e)
        {
            int tmp = tbxNumero.Text.CompareTo(tbkVerNumero.Text);

            nIntentos++;

            if (tmp == 0)
            {
                cbxVerNumero.IsChecked = true;
                btnGenerarNumero.IsEnabled = true;
                btnProbar.IsEnabled = false;
                tbkMensaje.Text = "";
                tbxNumero.Text = "";
                MessageBox.Show("Enhorabuena has acertado en " + nIntentos +" intentos", "Winner", MessageBoxButton.OK);
            }
            else if(tmp < 0)
            { 
                tbxNumero.Focus();
                tbkMensaje.Text = "El número es mayor.";
            }
            else if(tmp > 0)
            {
                tbxNumero.Focus();
                tbkMensaje.Text = "El número es menor.";
            }

        }
    }
}
