using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Ejercicio18
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Jarra _jarraA;
        private Jarra _jarraB;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Finalizar()
        {
            _jarraA = null;
            _jarraB = null;

            lbxMensajes.Items.Clear();
            tbkJarrasInicializado.Text = "";
            tbxCantidadJarraA.Text = "";
            tbxCantidadJarraB.Text = "";

            ActivarDeshabilitarCrearJarras(true);
        }

        private void ActivarDeshabilitarCrearJarras(bool activar)
        {
            tbxJarraA.IsEnabled = activar;
            tbxJarraB.IsEnabled = activar;
            btnCrearJarras.IsEnabled = activar;

            if (!activar)
                tbkJarrasInicializado.Text = "Las Jarras se han inicializado";
            else
                tbkJarrasInicializado.Text = "Las Jarras se han eliminado";
        }

        private void BtnCrearJarras_Click(object sender, RoutedEventArgs e)
        {
            _jarraA = new Jarra(int.Parse(tbxJarraA.Text));
            _jarraB = new Jarra(int.Parse(tbxJarraB.Text));

            prbrCantidadJarraA.Maximum = _jarraA.Capacidad;
            prbrCantidadJarraB.Maximum = _jarraB.Capacidad;

            ActualizarBarraJarras();

            ActivarDeshabilitarCrearJarras(false);
        }

        private void ActualizarBarraJarras()
        {
            prbrCantidadJarraA.Value = _jarraA.Contenido;
            prbrCantidadJarraB.Value = _jarraB.Contenido;

            tbxCantidadJarraA.Text = _jarraA.ToString();
            tbxCantidadJarraB.Text = _jarraB.ToString();
        }

        private void BtnLlenar_Click(object sender, RoutedEventArgs e)
        {
            if (_jarraA == null || _jarraB == null)
                return;

            if (((Button)sender).Tag.ToString() == "A")
                _jarraA.Llenar();
            if (((Button)sender).Tag.ToString() == "B")
                _jarraB.Llenar();

            ActualizarBarraJarras();
        }

        private void BtnVaciar_Click(object sender, RoutedEventArgs e)
        {
            if (_jarraA == null || _jarraB == null)
                return;

            if (((Button)sender).Tag.ToString() == "A")
                _jarraA.Vaciar();
            if (((Button)sender).Tag.ToString() == "B")
                _jarraB.Vaciar();

            ActualizarBarraJarras();
        }
        
        private void LbxMensajes_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            lbxMensajes.ScrollIntoView(lbxMensajes.Items.Count);
        }

        private void BtnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            Finalizar();
        }

        private void BtnVolcarJarraB_Click(object sender, RoutedEventArgs e)
        {
            if (_jarraA == null || _jarraB == null)
                return;

            _jarraA.LlenarDesdeJarra(_jarraB);

            ActualizarBarraJarras();
        }

        private void BtnVolcarJarraA_Click(object sender, RoutedEventArgs e)
        {
            if (_jarraA == null || _jarraB == null)
                return;

            _jarraB.LlenarDesdeJarra(_jarraA);

            ActualizarBarraJarras();
        }

        private void BtnDemo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
