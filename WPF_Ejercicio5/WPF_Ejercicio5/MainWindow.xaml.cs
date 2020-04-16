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

//---------------
using IO = System.IO;
using F = System.Windows.Forms;

namespace WPF_Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int desplazamiento = 3;

        public MainWindow()
        {
            InitializeComponent();
            tbxDesplazamiento.Text = desplazamiento.ToString();
            tbxFrase.Focus();
        }
        
        private void BtnBajarDesplazamiento_Click(object sender, RoutedEventArgs e)
        {
            if (desplazamiento == 0)
                return;
            desplazamiento--;
            tbxDesplazamiento.Text = desplazamiento.ToString();
        }

        private void BtnAumentarDesplazamiento_Click(object sender, RoutedEventArgs e)
        {
            if (desplazamiento == 10)
                return;
            desplazamiento++;
            tbxDesplazamiento.Text = desplazamiento.ToString();
        }

        private void BtnEncriptar_Click(object sender, RoutedEventArgs e)
        {
            tbxOriginal.Text = tbxFrase.Text;
            tbxEncriptado.Text = Encriptar(tbxFrase.Text);
        }

        private void BtnDesencriptar_Click(object sender, RoutedEventArgs e)
        {
            tbxOriginal.Text = tbxEncriptado.Text;
            tbxDesencriptado.Text = Desencriptar(tbxEncriptado.Text);
        }

        private string Encriptar(string frase)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < frase.Length; i++)
            {
                resultado.Append(frase[(i + desplazamiento) % frase.Length]);
            }

            return resultado.ToString();
        }

        private string Desencriptar(string frase)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < frase.Length; i++)
            {
                resultado.Append(frase[(frase.Length + (i - desplazamiento)) % frase.Length]);
            }

            return resultado.ToString();
        }
        
        [STAThread]
        private void BtnEncriptarFichero_Click(object sender, RoutedEventArgs e)
        {
            string fichero = string.Empty;
            F.OpenFileDialog ventana = new F.OpenFileDialog();
           
            if(ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                fichero = ventana.FileName;

            if (string.IsNullOrWhiteSpace(fichero))
                return;

            EncriptarFichero(fichero);
        }
        
        [STAThread]
        private void BtnDesencriptarFichero_Click(object sender, RoutedEventArgs e)
        {
            string fichero = string.Empty;
            F.OpenFileDialog ventana = new F.OpenFileDialog();

            if (ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                fichero = ventana.FileName;

            if (string.IsNullOrWhiteSpace(fichero))
                return;

            DesencriptarFichero(fichero);
        }

        private void EncriptarFichero(string ruta)
        {
            string tmp = IO.Path.GetFileNameWithoutExtension(ruta) + ".tmp";
            
            using (IO.FileStream fs = new IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.ReadWrite))
            using (IO.StreamReader sr = new IO.StreamReader(fs))
            using (IO.StreamWriter sw = new IO.StreamWriter(tmp))
            {
                while(!sr.EndOfStream)
                {
                    sw.WriteLine(Encriptar(sr.ReadLine()));
                }
            }

            IO.File.Delete(ruta);
            string nueva = IO.Path.GetDirectoryName(ruta) + IO.Path.DirectorySeparatorChar + IO.Path.GetFileNameWithoutExtension(tmp) + IO.Path.GetExtension(ruta);
            IO.File.Move(tmp, nueva);

            MessageBox.Show("Encriptación Completada");
        }

        private void DesencriptarFichero(string ruta)
        {
            string tmp = IO.Path.GetFileNameWithoutExtension(ruta) + ".tmp";

            using (IO.FileStream fs = new IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.ReadWrite))
            using (IO.StreamReader sr = new IO.StreamReader(fs))
            using (IO.StreamWriter sw = new IO.StreamWriter(tmp))
            {
                while (!sr.EndOfStream)
                {
                    sw.WriteLine(Desencriptar(sr.ReadLine()));
                }
            }

            IO.File.Delete(ruta);
            string nueva = IO.Path.GetDirectoryName(ruta) + IO.Path.DirectorySeparatorChar + IO.Path.GetFileNameWithoutExtension(tmp) + IO.Path.GetExtension(ruta);
            IO.File.Move(tmp, nueva);

            MessageBox.Show("Desencriptación Completada");
        }
    }
}
