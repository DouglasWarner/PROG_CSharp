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

namespace WPF_Ejercicio8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> primos = new List<string>();
        private string[] ejemplosPalindromo = { "No deseo ese don", "A Mafalda dad la fama", "Otro pone oro en oporto", "Yo hago yoga hoy", "Onís es asesino", "Dábale arroz a la zorra el abad", "Anita lava la tina" };
        
        public MainWindow()
        {
            InitializeComponent();
            LlenarEjemplosPalindromos();
        }

        private void LlenarEjemplosPalindromos()
        {
            foreach (var item in ejemplosPalindromo)
            {
                cmbEjemplosPalindromo.Items.Add(item);
            }
        }

        private bool EsPalindromo(string texto)
        {
            StringBuilder tmpTexto = new StringBuilder(QuitarTildes(QuitarEspacios(texto)));

            int indiceFinal = tmpTexto.Length - 1;

            for (int i = 0; i < tmpTexto.Length; i++)
            {
                if (tmpTexto[i] != tmpTexto[indiceFinal - i])
                    return false;
            }
            return true;
        }

        private string QuitarTildes(string texto)
        {
            StringBuilder tmpTexto = new StringBuilder(texto);
            
            tmpTexto.Replace('á', 'a');
            tmpTexto.Replace('é', 'e');
            tmpTexto.Replace('í', 'i');
            tmpTexto.Replace('ó', 'o');
            tmpTexto.Replace('ú', 'u');

            return tmpTexto.ToString().ToLower();
        }

        private string QuitarEspacios(string texto)
        {
            return string.Join("",texto.Split(new char[] { ' ', ',', ';', ':', '\'' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void BtnPalindromo_Click(object sender, RoutedEventArgs e)
        {
            lblResultadoPalindromo.Content = (EsPalindromo(tbxPalindromo.Text)) ? "ES PALINDROMO" : "NO ES PALINDROMO";
        }

        private void NumerosPrimos(int numero)
        {
            for (int i = numero; i >= 0; i--)
            {
                if (EsPrimo(i))
                    primos.Add(i.ToString());
            }
        }

        private bool EsPrimo(int numero)
        {
            int contador = 0;

            if (numero <= 1)
                return false;
            if (numero == 2 || numero == 3)
                return true;

            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                    contador++;
                if (contador >= 2)
                    return false;
            }
            return true;
        }

        private void BtnCalcularPrimos_Click(object sender, RoutedEventArgs e)
        {
            tbkListaNumerosPrimos.Inlines.Clear();
            primos.Clear();

            if (!int.TryParse(tbxPrimos.Text, out int tmpPrimo))
                return;

            NumerosPrimos(tmpPrimo);

            for (int i = 0; i < primos.Count; i++)
            {
                tbkListaNumerosPrimos.Inlines.Add(primos[i] + ", ");
            }
        }

        private void TbxPalindromo_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbxPalindromo.Text != "Introduce una frase")
                return;

            tbxPalindromo.Foreground = Brushes.Black;
            tbxPalindromo.Text = "";
        }

        private void TbxPalindromo_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxPalindromo.Text))
                return;

            tbxPalindromo.Foreground = Brushes.LightGray;
            tbxPalindromo.Text = "Introduce una frase";
        }

        private void TbxPrimos_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbxPrimos.Text != "Introduce una cantidad")
                return;

            tbxPrimos.Foreground = Brushes.Black;
            tbxPrimos.Text = "";
        }

        private void TbxPrimos_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxPrimos.Text))
                return;

            tbxPrimos.Foreground = Brushes.LightGray;
            tbxPrimos.Text = "Introduce una cantidad";
        }

        private void CmbEjemplosPalindromo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbxPalindromo.Foreground = Brushes.Black;
            tbxPalindromo.Text = cmbEjemplosPalindromo.SelectedValue.ToString();
        }
    }
}
