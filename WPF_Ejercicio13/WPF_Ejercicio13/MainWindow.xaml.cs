using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace WPF_Ejercicio13
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double anchoTexto;
        double altoTexto;
        bool nuevo;
        OpenFileDialog abrirFichero;
        SaveFileDialog guardarFicheroComo;
        string ficheroActual;
        Fuentes ventanaFuentes;
        int indiceX;
        int indiceY;

        public MainWindow()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            anchoTexto = 0;
            altoTexto = 0;
            nuevo = false;
            abrirFichero = new OpenFileDialog();
            guardarFicheroComo = new SaveFileDialog();
            ficheroActual = string.Empty;
            indiceX = 0;
            indiceY = 0;
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcerdaDe ventana = new AcerdaDe();

            ventana.ShowDialog();
        }

        private void WinPrincipal_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            anchoTexto = e.NewSize.Width - 15;
            altoTexto = e.NewSize.Height - 70;

            rtbxTexto.Width = anchoTexto;
            rtbxTexto.Height = (mtiBarraEstado.IsChecked) ? altoTexto - stbEstado.Height : altoTexto;
        }

        // Ver la barra de estado o no.
        private void MtiBarraEstado_Click(object sender, RoutedEventArgs e)
        {
            stbEstado.Visibility = (mtiBarraEstado.IsChecked) ? Visibility.Visible : Visibility.Hidden;
            rtbxTexto.Height = (mtiBarraEstado.IsChecked) ? altoTexto - stbEstado.Height : altoTexto;
        }

        private void MtiSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WinPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!nuevo)
            {
                if (MessageBox.Show("¿Seguro que quieres salir?", "Saliendo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    e.Cancel = true;
            }
        }

        private void MtiNuevo_Click(object sender, RoutedEventArgs e)
        {
            nuevo = true;

            MainWindow ventanaPrincipal = new MainWindow();

            ventanaPrincipal.Show();

            this.Close();

            nuevo = false;
        }

        private void MtiVentanaNuevo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipal = new MainWindow();

            ventanaPrincipal.Show();
        }

        private void MtiAbrir_Click(object sender, RoutedEventArgs e)
        {
            abrirFichero.Filter = "Documentos de textos (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            abrirFichero.InitialDirectory = Environment.CurrentDirectory;

            if (abrirFichero.ShowDialog() == true)
            {
                CargarDocumentoAbrir(abrirFichero.FileName);
                ficheroActual = abrirFichero.FileName;
            }

            Title = ficheroActual;
        }

        private void CargarDocumentoAbrir(string fichero)
        {
            rtbxTexto.Document.Blocks.Clear();
            
            using (StreamReader sr = new StreamReader(fichero))
            {
                while(!sr.EndOfStream)
                {
                    rtbxTexto.AppendText(sr.ReadLine());
                }

                stbItemFormato.Content = sr.CurrentEncoding.WebName.ToUpper();
            }
        }

        private void MtiGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ficheroActual))
                MtiGuardarComo_Click(this, null);
            else
                GuardarDocumento(ficheroActual);
        }

        private void MtiGuardarComo_Click(object sender, RoutedEventArgs e)
        {
            guardarFicheroComo.Filter = "Documento de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            guardarFicheroComo.InitialDirectory = Environment.CurrentDirectory;
            guardarFicheroComo.DefaultExt = ".txt";
            guardarFicheroComo.OverwritePrompt = true;

            if (guardarFicheroComo.ShowDialog() == true)
            {
                GuardarDocumento(guardarFicheroComo.FileName);
                ficheroActual = guardarFicheroComo.FileName;
            }

            Title = ficheroActual;
        }

        private void GuardarDocumento(string fichero)
        {
            TextRange textoDocumento = new TextRange(rtbxTexto.Document.ContentStart, rtbxTexto.Document.ContentEnd);

            using (FileStream flujo = new FileStream(fichero, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(flujo, Encoding.GetEncoding(stbItemFormato.Content.ToString())))
            {
                sw.Write(textoDocumento.Text);
                //textoDocumento.Save(flujo, DataFormats.Text);

                stbItemFormato.Content = sw.Encoding.WebName.ToUpper();
            }
        }

        private void MtiFecha_Click(object sender, RoutedEventArgs e)
        {
            rtbxTexto.AppendText(DateTime.Now.ToString("HH:mm dd/MM/yyyy"));
        }

        private void MtiFuente_Click(object sender, RoutedEventArgs e)
        {
            ventanaFuentes = new Fuentes();
            ventanaFuentes.PropertyChanged += VentanaFuentes_PropertyChanged;

            ventanaFuentes.ShowDialog();
        }

        private void VentanaFuentes_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is FontFamily)
               rtbxTexto.FontFamily = ((FontFamily)sender);

            if (sender is FamilyTypeface)
            {
                rtbxTexto.FontStyle = ((FamilyTypeface)sender).Style;
                rtbxTexto.FontStretch = ((FamilyTypeface)sender).Stretch;
                rtbxTexto.FontWeight = ((FamilyTypeface)sender).Weight;
            }

            if (sender is int)
                rtbxTexto.FontSize = ((int)sender);
        }

        private void RtbxTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextPointer posCursor = rtbxTexto.CaretPosition;

            TextPointer linea = posCursor.GetLineStartPosition(0);

            TextRange rangoColumna = new TextRange(linea, posCursor);

            int indiceColumna = rangoColumna.Text.Length;
            int indiceLinea = rtbxTexto.Document.Blocks.Count;

            stbItemColumna.Content = "Col " + indiceColumna;
            stbItemLinea.Content = "Lin " + indiceLinea;
        }
    }
}
