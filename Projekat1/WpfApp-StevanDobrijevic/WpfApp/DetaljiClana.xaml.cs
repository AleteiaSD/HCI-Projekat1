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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for DetaljiClana.xaml
    /// </summary>
    public partial class DetaljiClana : Window
    {
        public static List<Classes.Clan> listaClanova = new List<Classes.Clan>();
        public int s;
        public DetaljiClana(int i)
        {
            InitializeComponent();
            if(i==-1)
            {// visibility = vidljivost
                  s = -1;
                textBlockIme.Visibility = Visibility.Hidden;
                textBlockPrezime.Visibility = Visibility.Hidden;
                textBlockStarost.Visibility = Visibility.Hidden;
                textBlockCin.Visibility = Visibility.Hidden;
                textBlockDetalji.Visibility = Visibility.Hidden;
                buttonIzadji.Visibility = Visibility.Hidden;
            }
            else
            {
                s = i;
                InformacijeOClanu();
            }

        }

        private void ButtonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //============================
        private void InformacijeOClanu()
        {
            if(MainWindow.Clanovi[s].SlikaClana != "")
            {
                slika1.Source = new BitmapImage(new Uri(MainWindow.Clanovi[s].SlikaClana));
            }
            textBlockIme.Text = MainWindow.Clanovi[s].Ime;
            textBlockPrezime.Text = MainWindow.Clanovi[s].Prezime;
            textBlockStarost.Text = MainWindow.Clanovi[s].Starost.ToString();
            textBlockCin.Text = MainWindow.Clanovi[s].Cin;
            textBlockDetalji.Text = MainWindow.Clanovi[s].Detalji;
        }
    }
}
