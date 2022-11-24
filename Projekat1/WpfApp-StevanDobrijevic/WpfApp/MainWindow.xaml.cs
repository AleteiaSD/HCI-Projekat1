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
using Classes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BindingList<Classes.Clan> Clanovi { get; set; }
        private Classes.DataIO serializer = new DataIO();

        public MainWindow()
        { 
            Clanovi = serializer.DeSerializeObject<BindingList<Classes.Clan>>("clanovi.xml");
            if (Clanovi == null)
            {
                Clanovi = new BindingList<Classes.Clan>();
            }

            InitializeComponent();
            DataContext = this; 
        }

        private void ButtonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            serializer.SerializeObject<BindingList<Classes.Clan>>(Clanovi, "clanovi.xml");
        }

        private void ButtonDodajNovogClana_Click(object sender, RoutedEventArgs e)
        {
            AddClan newClan = new AddClan(-1);
            newClan.ShowDialog();
        }

        private void Obrisi_Click(object sender, RoutedEventArgs e)
        {
            Classes.Clan knjiga = (Classes.Clan)dataGridAirsoftTim.CurrentItem;
            Clanovi.Remove(knjiga);
        }

        private void Izmeni_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGridAirsoftTim.SelectedIndex;
            AddClan izmeni = new AddClan(i);
            izmeni.ShowDialog();
        }

        private void Detalji_Click(object sender, RoutedEventArgs e)
        {
            int i = dataGridAirsoftTim.SelectedIndex;
            DetaljiClana detaljiClana = new DetaljiClana(i);
            detaljiClana.ShowDialog();
        }
    }
}
