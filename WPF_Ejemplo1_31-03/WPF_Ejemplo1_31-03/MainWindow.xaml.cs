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
//-------------------
using System.IO;

namespace WPF_Ejemplo1_31_03
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

        // Controlador de todos los botones de la calculadora
        private void ControlBotones(object sender, RoutedEventArgs e)
        {
            Button botonPulsado = sender as Button;
            if (botonPulsado == null)
                return;

            if(botonPulsado.Name == "btn1")
            {
                CrearContenidoEnEjecucion ventana = new CrearContenidoEnEjecucion();
                this.Hide();
                ventana.ShowDialog();
                this.Visibility = Visibility.Visible;
            }
        }
    }
}

/* Ejemplo de pasar las imagenes
    List<string> fotos = new List<string>();
    int indice = 0;

    public MainWindow()
    {
        InitializeComponent();
        GetFotos();
        imgFoto.Source = new BitmapImage(new Uri(fotos[indice], UriKind.Relative));
    }

    private void GetFotos()
    {
        fotos = new List<string>(Directory.GetFiles(@".\..\..\Imagenes\"));
    }

    private void BtnAtras_Click(object sender, RoutedEventArgs e)
    {
        imgFoto.Source = new BitmapImage(new Uri(fotos[--indice % fotos.Count], UriKind.Relative));
    }

    private void BtnSiguiente_Click(object sender, RoutedEventArgs e)
    {
        imgFoto.Source = new BitmapImage(new Uri(fotos[++indice % fotos.Count], UriKind.Relative));
    }
    */
    
