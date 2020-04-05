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
using System.Windows.Shapes;

namespace WPF_Ejemplo1_31_03
{
    /// <summary>
    /// Lógica de interacción para CrearContenidoEnEjecucion.xaml
    /// </summary>
    public partial class CrearContenidoEnEjecucion : Window
    {
        public CrearContenidoEnEjecucion()
        {
            InitializeComponent();
        }

        private void BtnMostrarDatos_Click(object sender, RoutedEventArgs e)
        {
            LlenarGridAlea();
        }

        private void LlenarGridAlea()
        {
            const int MAXNUMERO = 9;
            List<int> listaNumeros = new List<int>();
            Random rnd = new Random();
            int pos = 0;
            StringBuilder tmp = new StringBuilder();

            for (int i = 0; i < grdDatos.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < grdDatos.ColumnDefinitions.Count; j++)
                {
                    pos = rnd.Next(MAXNUMERO);

                    // Creamos un TextBlock en tiempo de ejecución
                    TextBlock tbxTexto = new TextBlock();
                    tbxTexto.Text = pos.ToString();
                    tbxTexto.FontFamily = new FontFamily("Arial");
                    tbxTexto.FontSize = 60;
                    tbxTexto.VerticalAlignment = VerticalAlignment.Center;
                    tbxTexto.HorizontalAlignment = HorizontalAlignment.Center;
                    tbxTexto.Background = Brushes.Red;
                    tbxTexto.Foreground = Brushes.White;
                    tbxTexto.Height = 70;
                    tbxTexto.Width = 70;
                    tbxTexto.TextAlignment = TextAlignment.Center;
                    // Etc.
                    
                    // Aplicamos el elemento TextBlock creado
                    Grid.SetRow(tbxTexto, i);
                    Grid.SetColumn(tbxTexto, j);
                    
                    grdDatos.Children.Add(tbxTexto);

                    listaNumeros.Add(pos);
                }
            }

            // Mostrar Ordenados
            listaNumeros.Sort();
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                tmp.AppendFormat("{0}", listaNumeros[i].ToString().PadLeft(8));
                if ((i+1) % 3 == 0)
                    tmp.AppendLine();
            }


            MessageBox.Show(tmp.ToString(), "Números", MessageBoxButton.OK);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.Title = "Ancho: " + e.NewSize.Width + " , Alto: " + e.NewSize.Height;
        }
    }
}
