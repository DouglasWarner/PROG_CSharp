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

namespace WPF_Ejemplo_05_05
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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.V)
                MessageBox.Show("Ctrl + V");
            if (Keyboard.Modifiers == ModifierKeys.Shift && e.Key == Key.F1)
                MessageBox.Show("Has entrado en modo supervisor");
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            string info = "[X] " + e.GetPosition(this).X + ", [Y] " + e.GetPosition(this).Y;
            info += " Control -> " + e.Source.GetType().Name;
            Title = info;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
