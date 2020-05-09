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

//-----
using System.ComponentModel;
//--------
using System.Globalization;
using System.Windows.Markup;

namespace WPF_Ejercicio13
{
    /// <summary>
    /// Lógica de interacción para Fuentes.xaml
    /// </summary>
    public partial class Fuentes : Window, INotifyPropertyChanged
    {
        private FontFamily fuente;
        private FamilyTypeface estilo;
        private int tamanoElegido;
        private int[] tamano = { 8, 9, 10, 12, 14, 16, 20, 25, 30, 45 };

        public FontFamily Fuente
        {
            get { return fuente; }
            set
            {
                fuente = value;
                PropertyChanged(fuente, null);
            }
        }
        public FamilyTypeface Estilo
        {
            get { return estilo; }
            set
            {
                estilo = value;
                PropertyChanged(estilo, null);
            }
        }

        public int TamanoElegido
        {
            get { return tamanoElegido; }
            set
            {
                tamanoElegido = value;
                PropertyChanged(tamanoElegido, null);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Fuentes()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            lbxListaFuentes.SelectedIndex = 0;
            lbxListaEstilos.SelectedIndex = 0;
            lbxListaTamano.ItemsSource = tamano;
            lbxListaTamano.SelectedIndex = 8;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Fuente = new FontFamily(lbxListaFuentes.SelectedValue.ToString());
            Estilo = (FamilyTypeface)lbxListaEstilos.SelectedValue;
            TamanoElegido = int.Parse(lbxListaTamano.SelectedValue.ToString());

            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LbxListaEstilos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                tbxEstiloSeleccionado.Text = ((FamilyTypeface)((ListBox)sender).SelectedValue).AdjustedFaceNames[XmlLanguage.GetLanguage("en-US")];
            }
            catch
            { }
        }

        private void LbxListaTamano_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           tbkMuestra.FontSize = (int)lbxListaTamano.SelectedValue;
        }
    }
}
