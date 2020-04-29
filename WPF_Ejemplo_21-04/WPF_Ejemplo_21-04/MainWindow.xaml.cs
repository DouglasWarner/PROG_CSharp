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
//-------------
using System.ComponentModel;

namespace WPF_Ejemplo_21_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> andalucia = new List<string>(new string[] {"Málaga", "Jaen", "Cordoba", "Granada", "Sevilla", "Almeria", "Huelva"});
        private bool direccion = false;

        public MainWindow()
        {
            InitializeComponent();
            cmbEjemplo.ItemsSource = andalucia;
            ltbEjemplo.ItemsSource = andalucia;
        }

        private void LtbEjemplo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has cambiado la selección al elemento nº" + ltbEjemplo.SelectedItem);
        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            // Ordenar TextBlock
            ltbEjemplo.Items.SortDescriptions.Clear();

            if (direccion)
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("Text", ListSortDirection.Ascending));
            else
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("Text", ListSortDirection.Descending));

            direccion = !direccion;

            // Ordenar ListBoxItem
            ltbEjemplo.Items.SortDescriptions.Clear();

            if (direccion)
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
            else
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Descending));

            direccion = !direccion;

            // Ordenar ItemsSource
            ltbEjemplo.Items.SortDescriptions.Clear();

            if (direccion)
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
            else
                ltbEjemplo.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Descending));

            direccion = !direccion;
        }

        private void BtnAnadirTabItem_Click(object sender, RoutedEventArgs e)
        {
            TabItem tmp = new TabItem();
            TextBlock texto = new TextBlock();

            tmp.Header = "Cabecera";
            texto.Text = "Un nuevo texto";

            tmp.Content = texto;

            tbcEjemplo.Items.Add(tmp);
        }
    }
}
