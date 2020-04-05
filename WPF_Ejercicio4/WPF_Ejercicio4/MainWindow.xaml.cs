using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPF_Ejercicio4
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

        private void BtnSumar_Click(object sender, RoutedEventArgs e)
        {
            int numeroInicial = 0;
            int numeroFinal = 0;

            if (!int.TryParse(tbxNumeroInicial.Text, out numeroInicial))
                return;
            if (!int.TryParse(tbxNumeroFinal.Text, out numeroFinal))
                return;

            tbkMensaje.Text = string.Format(" La suma desde {0} hasta {1} es: {2}",
                numeroInicial, numeroFinal, CalcularSumaDeAaB(numeroInicial, numeroFinal));
        }

        private int CalcularSumaDeAaB(int a, int b)
        {
            int resultado = 0;

            for (int i = a; i <= b; i++)
            {
                resultado += i;
            }

            return resultado;
        }
    }
}
