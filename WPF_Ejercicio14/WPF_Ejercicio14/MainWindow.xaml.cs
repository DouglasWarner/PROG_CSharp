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

//------------
using IO = System.IO;

namespace WPF_Ejercicio14
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char[] separadores = { ' ', '.', ',', ':', ';', '-', '\t' };
        private string[] lineas = null;
        private int nPalabras = 0;
        private int nLineas = 0;

        public MainWindow()
        {
            InitializeComponent();
            tbxNombreFichero.Focus();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            nLineas = 0;
            nPalabras = 0;

            if (!IO.File.Exists(tbxNombreFichero.Text))
                return;

            try
            {
                IO.FileInfo tmp = new IO.FileInfo(tbxNombreFichero.Text);

                LeerFichero(tbxNombreFichero.Text);
                tbkAtributos.Text = tmp.Attributes.ToString();
                tbkTamano.Text = (tmp.Length > 10000) ? ((tmp.Length / 1024) / 1024).ToString() + " mb" : (tmp.Length > 1000) ? (tmp.Length / 1024).ToString() + " kb" : tmp.Length.ToString() + " bytes";
                tbkNumeroLineas.Text = nLineas.ToString();
                tbkNumeroPalabras.Text = nPalabras.ToString();
            }
            catch
            {
                MessageBox.Show("Algo ocurrio con la lectura del fichero", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LeerFichero(string ruta)
        {
            using (IO.StreamReader sr = new IO.StreamReader(ruta))
            {
                while(!sr.EndOfStream)
                {
                    lineas = sr.ReadLine().Split(separadores, StringSplitOptions.RemoveEmptyEntries);
                    nLineas++;
                    nPalabras += lineas.Length;
                }
            }
        }
    }
}
