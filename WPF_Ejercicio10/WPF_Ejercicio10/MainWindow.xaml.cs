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

namespace WPF_Ejercicio10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder expresion = new StringBuilder();
        private StringBuilder ultimaExpresion = new StringBuilder();
        private bool conSigno = false;
        private List<string> historialExpresiones = new List<string>();
        private bool mostrarHistorial = false;

        char[][] botones =
            {
                new char[] { '+', '-', '*', '/', '(', ')'},
                new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', '(', ')' }
            };

        public MainWindow()
        {
            InitializeComponent();
            tbxCuadro.Text = "0";
            winVentanaPrincipal.Height = 415;
            winVentanaPrincipal.Width = 350;
            lbxHistorial.ItemsSource = historialExpresiones;

            Clipboard.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char tmp = char.Parse(((Button)sender).Content.ToString());

            try
            {
                if (botones[1].Contains(tmp))
                {
                    if (tmp == '.')
                    {
                        if (!ultimaExpresion.ToString().Contains('.'))
                        {
                            if (tbxCuadro.Text.Length == 1 && tbxCuadro.Text == "0")
                                ultimaExpresion.Append("0");
                            if (botones[0].Contains(tbxCuadro.Text[tbxCuadro.Text.Length - 1]))
                            {
                                ultimaExpresion.Append("0");
                                expresion.Append("0");
                            }
                            ultimaExpresion.Append(tmp);
                            expresion.Append(tmp);
                        }
                    }
                    else
                    {
                        ultimaExpresion.Append(tmp);
                        expresion.Append(tmp);
                    }
                }

                if (botones[0].Contains(tmp) && !botones[0].Contains(tbxCuadro.Text[tbxCuadro.Text.Length - 1]))
                {
                    if (tbxCuadro.Text.Length == 1 && tbxCuadro.Text == "0")
                        ultimaExpresion.Append("0");

                    if (ultimaExpresion.Length > 0 && ultimaExpresion[ultimaExpresion.Length - 1] == '.')
                    {
                        ultimaExpresion.Remove(ultimaExpresion.Length - 1, 1);
                        expresion.Remove(expresion.Length - 1, 1);
                    }
                    
                    expresion.Append(string.Concat(' ', tmp, ' '));

                    ultimaExpresion.Clear();
                }

            }
            catch
            {

            }
            tbxCuadro.Text = expresion.ToString();
        }

        private double Calcular()
        {
            string[] expresionSeparada = expresion.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double resultado = 0;

            try
            {
                if (!double.TryParse(expresionSeparada[0], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
                    return 0;

                for (int i = 0; i < expresionSeparada.Length; i++)
                {
                    switch (expresionSeparada[i])
                    {
                        case "+":
                            resultado += double.Parse(expresionSeparada[i + 1], CultureInfo.InvariantCulture);
                            break;
                        case "-":
                            resultado -= double.Parse(expresionSeparada[i + 1], CultureInfo.InvariantCulture);
                            break;
                        case "*":
                            resultado *= double.Parse(expresionSeparada[i + 1], CultureInfo.InvariantCulture);
                            break;
                        case "/":
                            resultado /= double.Parse(expresionSeparada[i + 1], CultureInfo.InvariantCulture);
                            break;
                    }
                }
            }
            catch
            {

            }

            return resultado;
        }

        private void BtnBorrarUltimaOperacion_Click(object sender, RoutedEventArgs e)
        {
            int posBorrar = expresion.ToString().LastIndexOf(' ') + 1;

            expresion.Remove(posBorrar, ultimaExpresion.Length);
            ultimaExpresion.Clear();
            tbxCuadro.Text = expresion.ToString();
        }

        private void BtnBorrarTodo_Click(object sender, RoutedEventArgs e)
        {
            tbxCuadro.Text = "0";
            expresion.Clear();
            ultimaExpresion.Clear();
            conSigno = false;
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ultimaExpresion.Clear();
            ultimaExpresion.Append(Calcular().ToString());
            historialExpresiones.Add(expresion.ToString()+" = " + ultimaExpresion.ToString());
            expresion.Clear();
            expresion.Append(ultimaExpresion);
            tbxCuadro.Text = expresion.ToString();
            lbxHistorial.Items.Refresh();
        }

        private void BtnSigno_Click(object sender, RoutedEventArgs e)
        {
            conSigno = !conSigno;
            double cambioSigno = 0;
            string tmp = string.Empty;

            cambioSigno = double.Parse(ultimaExpresion.ToString()) * -1;
            tmp = ultimaExpresion.ToString();

            ultimaExpresion.Clear();
            ultimaExpresion.Append(cambioSigno);

            int posInsertar = expresion.ToString().LastIndexOf(' ');
            int longitudInsertar = expresion.ToString().Substring(posInsertar).Length;

            expresion.Replace(tmp, cambioSigno.ToString(), posInsertar, longitudInsertar);

            tbxCuadro.Text = expresion.ToString();
        }
        
        private void CbxHistorial_Checked(object sender, RoutedEventArgs e)
        {
            mostrarHistorial = cbxHistorial.IsChecked.Value;
            Historial();
        }

        private void Historial()
        {
            if(mostrarHistorial)
            {
                winVentanaPrincipal.Height = 415;
                winVentanaPrincipal.Width = 612;
                stpHistorial.Visibility = Visibility.Visible;
            }
            else
            {
                winVentanaPrincipal.Height = 415;
                winVentanaPrincipal.Width = 345;
                stpHistorial.Visibility = Visibility.Hidden;
            }
        }

        private void CbxHistorial_Unchecked(object sender, RoutedEventArgs e)
        {
            CbxHistorial_Checked(this, null);
        }

        private void Pegar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void Pegar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbxCuadro.Paste();
            ultimaExpresion.Clear();
            ultimaExpresion.Append(Clipboard.GetText());
            expresion.Append(Clipboard.GetText());
            tbxCuadro.Text = expresion.ToString();
        }

        private void Copiar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = tbxCuadro.SelectionLength > 0;
        }

        private void Copiar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbxCuadro.Copy();
        }

        private void Cortar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = tbxCuadro.SelectionLength > 0;
        }

        private void Cortar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            tbxCuadro.Cut();
            expresion.Clear();
            expresion.Append(tbxCuadro.Text);
        }

        private void TbxCuadro_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!botones[1].Contains(e.Text[e.Text.Length - 1]))
                e.Handled = true;
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe ventana = new AcercaDe();

            ventana.ShowDialog();
        }
    }
}
