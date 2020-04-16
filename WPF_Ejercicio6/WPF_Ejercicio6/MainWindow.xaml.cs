using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;
using System.Threading;

namespace WPF_Ejercicio6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private DateTime fecha;
        private bool _activado = true;
        private int hora = -1;
        private int minuto = -1;
        private bool sonidoAlarma = true;

        public MainWindow()
        {
            InitializeComponent();
            lbReloj.Content = string.Format("{0} : {1} : {2}", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"));
            LlenarComboBoxHoraYMinuto();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            SystemSounds.Hand.Play();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ActivarReloj();
        }

        private void ActivarReloj()
        {
            DateTime tmpDate = DateTime.Now.Date;
            int tmpHora = DateTime.Now.Hour;
            int tmpMin = DateTime.Now.Minute;

            if (_activado)
                lbReloj.Content = string.Format("{0} : {1} : {2}", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"));

            if (tmpHora == hora && tmpMin == minuto && tmpDate == fecha.Date)
            {
                if (sonidoAlarma)
                {
                    SystemSounds.Hand.Play();
                    sonidoAlarma = false;
                }
            }
            else
                sonidoAlarma = true;

            sbitemFecha.Content = char.ToUpperInvariant(DateTime.Now.ToLongDateString()[0]) + DateTime.Now.ToLongDateString().Substring(1);

            Thread.Sleep(2);
        }

        private void LlenarComboBoxHoraYMinuto()
        {
            // Hora
            for (int i = 1; i <= 24; i++)
            {
                cbxHora.Items.Add(i.ToString("00"));
            }

            // Minuto
            for (int i = 0; i <= 60; i++)
            {
                cbxMinuto.Items.Add(i.ToString("00"));
            }
        }

        private void BtnMarchar_Click(object sender, RoutedEventArgs e)
        {
            _activado = !_activado;
            btnParar.IsEnabled = btnMarchar.IsEnabled;
            btnMarchar.IsEnabled = !btnParar.IsEnabled;
        }

        private void BtnParar_Click(object sender, RoutedEventArgs e)
        {
            _activado = !_activado;
            btnMarchar.IsEnabled = btnParar.IsEnabled;
            btnParar.IsEnabled = !btnMarchar.IsEnabled;
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Saliendo", MessageBoxButton.YesNo);

            if (resultado == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void CbxHora_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            hora = int.Parse(((ComboBox)sender).SelectedValue.ToString());
            fecha = new DateTime(fecha.Year, fecha.Month, fecha.Day, hora, fecha.Minute, fecha.Second);
        }

        private void CbxMinuto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            minuto = int.Parse(((ComboBox)sender).SelectedValue.ToString());
            fecha = new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour, minuto, fecha.Second);
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            fecha = new DateTime(((DatePicker)sender).SelectedDate.Value.Year, ((DatePicker)sender).SelectedDate.Value.Month, ((DatePicker)sender).SelectedDate.Value.Day,
                fecha.Hour, fecha.Minute, fecha.Second);
        }
    }
}
