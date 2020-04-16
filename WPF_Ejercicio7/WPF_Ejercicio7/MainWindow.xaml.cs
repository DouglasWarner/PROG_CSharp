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

namespace WPF_Ejercicio7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] primeraMatriz = new int[3];
        private int[] segundaMatriz = new int[3];
        private int[,] resultadoMatriz = new int[3, 3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (   !int.TryParse(tbxMat1Num1.Text, out primeraMatriz[0])
                || !int.TryParse(tbxMat1Num2.Text, out primeraMatriz[1])
                || !int.TryParse(tbxMat1Num3.Text, out primeraMatriz[2])
                || !int.TryParse(tbxMat2Num1.Text, out segundaMatriz[0])
                || !int.TryParse(tbxMat2Num2.Text, out segundaMatriz[1])
                || !int.TryParse(tbxMat2Num3.Text, out segundaMatriz[2]))
                return;

            CalcularResultado();

            MostrarResultado();
        }

        private void CalcularResultado()
        {
            for (int i = 0; i < resultadoMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < resultadoMatriz.GetLength(1); j++)
                {
                    resultadoMatriz[i, j] = primeraMatriz[i] * segundaMatriz[j];
                }
            }
        }

        private void MostrarResultado()
        {
            foreach (var item in grdResultado.Children)
            {
                ((Label)item).Content = resultadoMatriz[Grid.GetRow(((Label)item)), Grid.GetColumn(((Label)item))];
            }
        }
    }
}
