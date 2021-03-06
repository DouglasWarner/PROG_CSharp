﻿using System;
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

namespace WPF_Ejemplo_28_04_Menus
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evento click del MenuItem Salir");
        }

        private void MitemAyuda_Click(object sender, RoutedEventArgs e)
        {
            Ayuda miAyuda = new Ayuda();

            miAyuda.ShowDialog();
        }

        private void MniEspañol_Click(object sender, RoutedEventArgs e)
        {
            mniEspañol.IsChecked = true;
            mniIngles.IsChecked = false;
            Title = "ESPAÑOL";
        }

        private void MniIngles_Click(object sender, RoutedEventArgs e)
        {
            mniEspañol.IsChecked = false;
            mniIngles.IsChecked = true;
            Title = "INGLES";
        }
    }
}
