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

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string expresion = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            char[][] separadores =
            {
                new char[] { '+', '-', '*', '/' },
                new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' }
            };

            string[] numeros = expresion.Split(separadores[0]);
            string[] simbolos = expresion.Split(separadores[1],StringSplitOptions.RemoveEmptyEntries);
            double resultado = 0;

            if (!double.TryParse(numeros[0], out resultado))
                return;

            try
            {
                for (int i = 0; i < simbolos.Length; i++)
                {
                    switch (simbolos[i])
                    {
                        case "+":
                            resultado += double.Parse(numeros[i + 1]);
                            break;
                        case "-":
                            resultado -= double.Parse(numeros[i + 1]);
                            break;
                        case "*":
                            resultado *= double.Parse(numeros[i + 1]);
                            break;
                        case "/":
                            resultado /= double.Parse(numeros[i + 1], CultureInfo.InvariantCulture);
                            break;
                    }
                }
                tbkResultado.Text = resultado.ToString();
            }
            catch
            {
                
            }
        }
        
        public void QuitarTexto()
        {
            if (tbxExpresion.Text == "Introduce la expresión aqui...")
            {
                tbxExpresion.Foreground = Brushes.Black;
                tbxExpresion.Opacity = 1;
                tbxExpresion.Text = "";
            }
        }

        public void AnadirTexto()
        {
            if (string.IsNullOrWhiteSpace(tbxExpresion.Text))
            {
                tbxExpresion.Foreground = new SolidColorBrush(Colors.Gray);
                tbxExpresion.Opacity = 0.5;
                tbxExpresion.Text = "Introduce la expresión aqui...";
            }
        }

        private void TbxExpresion_GotFocus(object sender, RoutedEventArgs e)
        {
            QuitarTexto();
        }

        private void TbxExpresion_LostFocus(object sender, RoutedEventArgs e)
        {
            AnadirTexto();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Calcular();
        }

        private void TbxExpresion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
                return;

            char tmp = ((TextBox)sender).Text[((TextBox)sender).Text.Length-1];

            if (!char.IsNumber(tmp) && !tmp.Equals('.') && !tmp.Equals('+') && !tmp.Equals('-') && !tmp.Equals('*') && !tmp.Equals('/'))
                return;
            else
                expresion = ((TextBox)sender).Text;
        }
    }
}
