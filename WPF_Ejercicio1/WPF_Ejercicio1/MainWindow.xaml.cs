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

namespace WPF_Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbxNumero.Focus();
        }

        void CalcularSumaN_Numeros(long numero)
        {
            lblResultado.Content = ((numero * (numero + 1)) / 2).ToString("N");
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            long numero = 0;
            if(long.TryParse(tbxNumero.Text, out numero))
                CalcularSumaN_Numeros(numero);
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
