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

namespace WPF_Ejemplo_20_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string password = "123";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Key[] teclaPermitida = {Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4, Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9,
                Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8, Key.D9};

            e.Handled = !teclaPermitida.Contains<Key>(e.Key);
        }

        private void TbxTextoBinario_KeyDown(object sender, KeyEventArgs e)
        {
            Key[] teclaPermitida = {Key.NumPad0, Key.NumPad1, Key.D0, Key.D1};

            e.Handled = !teclaPermitida.Contains<Key>(e.Key);
        }

        private void TbxTexto_GotFocus(object sender, RoutedEventArgs e)
        {
            ((Control)sender).Background = new SolidColorBrush(Colors.LightBlue);
            ((Control)sender).Height += 10;
            ((Control)sender).Width += 50;
        }

        private void TbxTexto_LostFocus(object sender, RoutedEventArgs e)
        {
            ((Control)sender).Background = new SolidColorBrush(Colors.White);
            ((Control)sender).Height -= 10;
            ((Control)sender).Width -= 50;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            tbxNombre.Clear();
            pswBoxCont.Clear();
            tbxNombre.Focus();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (tbxNombre.Text.Equals("") && pswBoxCont.Password.Equals(password))
                MessageBox.Show("Bienvenido al sistema");
        }

        /*pswBoxCont.Password += e.Key.ToString();
            this.Title = pswBoxCont.Password;*/

        /* Otra Forma de hacerlo
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string teclaPermitida = "0123456789";

            if (!teclaPermitida.Contains(e.Text[e.Text.Length-1]))
                e.Handled = true;
        }
        */
    }
}
