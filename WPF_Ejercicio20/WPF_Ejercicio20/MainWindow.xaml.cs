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

namespace WPF_Ejercicio20
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        struct Jugador
        {
            string marcador;
            bool turno;

            public Jugador(string marcador)
            {
                this.marcador = marcador;
                turno = false;
            }

            public bool Turno
            {
                get { return turno; }
                set { turno = value; }
            }

            public string Marcador
            {
                get { return marcador; }
            }
        }

        Jugador j1;
        Jugador j2;
        int[,] tablero;

        public MainWindow()
        {
            InitializeComponent();

            EmpezarJuego();
        }

        private void Selecionado_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label tmp = ((Label)sender);

            if (j1.Turno)
            {
                tmp.Content = j1.Marcador;
            }
            if (j2.Turno)
            {
                tmp.Content = j2.Marcador;
            }

            tablero[Grid.GetRow(tmp), Grid.GetColumn(tmp)] = (j1.Turno) ? 1 : 2;

            j1.Turno = !j1.Turno;
            j2.Turno = !j2.Turno;

            tmp.MouseDown -= Selecionado_MouseDown;

            ComprobarGanador();
        }

        private void EmpezarJuego()
        {
            foreach (var item in grdTresEnRaya.Children)
            {
                ((Label)item).MouseDown -= Selecionado_MouseDown;
            }

            j1 = new Jugador("X");
            j2 = new Jugador("O");

            j1.Turno = true;
            j2.Turno = false;

            grdTresEnRaya.IsEnabled = true;
            tablero = new int[grdTresEnRaya.RowDefinitions.Count, grdTresEnRaya.ColumnDefinitions.Count];

            foreach (var item in grdTresEnRaya.Children)
            {
                ((Label)item).Content = "";
                ((Label)item).MouseDown += Selecionado_MouseDown;
            }
        }
        
        private void ComprobarGanador()
        {
            if ((tablero[0, 0] == 1 && tablero[0, 1] == 1 && tablero[0, 2] == 1)
            || (tablero[1, 0] == 1 && tablero[1, 1] == 1 && tablero[1, 2] == 1)
            || (tablero[2, 0] == 1 && tablero[2, 1] == 1 && tablero[2, 2] == 1)
            || (tablero[0, 0] == 1 && tablero[1, 0] == 1 && tablero[2, 0] == 1)
            || (tablero[0, 1] == 1 && tablero[1, 1] == 1 && tablero[2, 1] == 1)
            || (tablero[0, 2] == 1 && tablero[1, 2] == 1 && tablero[2, 2] == 1)
            || (tablero[0, 0] == 1 && tablero[1, 1] == 1 && tablero[2, 2] == 1)
            || (tablero[0, 2] == 1 && tablero[1, 1] == 1 && tablero[2, 0] == 1))
            {
                tbkMensaje.Text = "Jugador 1 ha ganado";
                grdTresEnRaya.IsEnabled = false;
            }

            if ((tablero[0, 0] == 2 && tablero[0, 1] == 2 && tablero[0, 2] == 2)
            || (tablero[1, 0] == 2 && tablero[1, 1] == 2 && tablero[1, 2] == 2)
            || (tablero[2, 0] == 2 && tablero[2, 1] == 2 && tablero[2, 2] == 2)
            || (tablero[0, 0] == 2 && tablero[1, 0] == 2 && tablero[2, 0] == 2)
            || (tablero[0, 1] == 2 && tablero[1, 1] == 2 && tablero[2, 1] == 2)
            || (tablero[0, 2] == 2 && tablero[1, 2] == 2 && tablero[2, 2] == 2)
            || (tablero[0, 0] == 2 && tablero[1, 1] == 2 && tablero[2, 2] == 2)
            || (tablero[0, 2] == 2 && tablero[1, 1] == 2 && tablero[2, 0] == 2))
            {
                tbkMensaje.Text = "Jugador 2 ha ganado";
                grdTresEnRaya.IsEnabled = false;
            }
        }

        private void BtnEmpezarJuego_Click(object sender, RoutedEventArgs e)
        {
            EmpezarJuego();
        }
    }
}
