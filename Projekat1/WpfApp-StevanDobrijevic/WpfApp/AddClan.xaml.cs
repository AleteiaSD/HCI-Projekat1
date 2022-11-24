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
using Microsoft.Win32;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for AddClan.xaml
    /// </summary>
    public partial class AddClan : Window
    {
        int indeksClana;
        DateTime dan = DateTime.Today;
        static OpenFileDialog openFile1 = new OpenFileDialog();
        static BitmapImage bitmapImg1 = new BitmapImage();


        public AddClan(int i)
        {
            InitializeComponent();
            comboBoxCinovi.ItemsSource = Classes.Constants.cinovi;
            openFile1.FileName = "SlikaClana";
            
                if (i == -1)
                {
                    indeksClana = -1;
                }
                else
                {
                    indeksClana = i;
                    buttonDodaj.Content = "IZMENI"; //button DODAJ iz tabele AddClan postaje button IZMENI u tabeli DetaljiClana
                    
                    slika1.Source = new BitmapImage(new Uri(MainWindow.Clanovi[indeksClana].SlikaClana));
                    textBoxIme.Text = MainWindow.Clanovi[indeksClana].Ime;
                    textBoxPrezime.Text = MainWindow.Clanovi[indeksClana].Prezime;
                    textBoxStarost.Text = MainWindow.Clanovi[indeksClana].Starost.ToString();
                    comboBoxCinovi.SelectedValue = MainWindow.Clanovi[indeksClana].Cin;
                    dan.ToString();
                    textBoxDetalji.Text = MainWindow.Clanovi[indeksClana].Detalji;

                }
        }
       
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e) 
        {
            Classes.Clan novi;

            if (validate())
            {
                if (indeksClana == -1)
                {//ne postoji clan u listi dodajem novog
                    novi = new Classes.Clan(slika1.Source.ToString(), textBoxIme.Text, textBoxPrezime.Text, int.Parse(textBoxStarost.Text), comboBoxCinovi.SelectedValue.ToString(), dan.ToString(), textBoxDetalji.Text);
                    MainWindow.Clanovi.Add(novi);
                    this.Close();
                }
                else
                { //menjam postojeci
                    novi = new Classes.Clan(slika1.Source.ToString(), textBoxIme.Text, textBoxPrezime.Text, int.Parse(textBoxStarost.Text), comboBoxCinovi.SelectedValue.ToString(), dan.ToString(), textBoxDetalji.Text);
                    MainWindow.Clanovi[indeksClana]=novi;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu dobro popunjeni.", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonBrowse_Click(object sender, RoutedEventArgs e)
        {
            openFile1.FileName = "SlikaClana";
            openFile1.Title = "Select a picture";
            openFile1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +  "Portable Network Graphic (*.png)|*.png";
            if (openFile1.ShowDialog() == true)
            {
                slika1.Source = new BitmapImage(new Uri(openFile1.FileName));
                bitmapImg1 = new BitmapImage(new Uri(openFile1.FileName));
            }
        }




        private bool validate()
        {
            bool result = true;
            //slika
            if (openFile1.FileName == "SlikaClana" && indeksClana == -1)
            {
                labelGreskaBrowse.Content = "Odaberite sliku.";
                labelGreskaBrowse.BorderBrush = Brushes.Red;
                buttonBrowse.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                labelGreskaBrowse.Content = "";
                buttonBrowse.BorderBrush = Brushes.Green;
            }
            //ime
            if (textBoxIme.Text.Trim().Equals(""))
            {
                result = false;
                textBoxIme.BorderBrush = Brushes.Red;

                labelGreskaIme.Content = "Unesite ime!";
            }
            else
            {
                textBoxIme.BorderBrush = Brushes.Green;
                labelGreskaIme.Content = string.Empty;
            }
            //prezime
            if (textBoxPrezime.Text.Trim().Equals(""))
            {
                result = false;
                textBoxPrezime.BorderBrush = Brushes.Red;

                labelGreskaPrezime.Content = "Unesite prezime!";
            }
            else
            {
                textBoxPrezime.BorderBrush = Brushes.Green;
                labelGreskaPrezime.Content = string.Empty;
            }
            //godina
            if (textBoxIme.Text.Trim().Equals(""))
            {
                labelGreskaStarost.Content = "Unesite starost clana!";
                textBoxStarost.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                labelGreskaStarost.Content =string.Empty;
                textBoxStarost.BorderBrush = Brushes.Green;
                try
                {
                    int pom = int.Parse(textBoxStarost.Text.Trim());

                    if (pom >= 18 && pom <= 50)
                    {
                        textBoxStarost.BorderBrush = Brushes.Green;
                        labelGreskaStarost.Content = string.Empty;
                    }
                    else
                    {
                        textBoxStarost.BorderBrush = Brushes.Red;
                        labelGreskaStarost.Content = "Nije ispunjen uslov starosti!";
                        result = false;
                    }
                }
                catch
                {
                    textBoxStarost.BorderBrush = Brushes.Red;
                    labelGreskaStarost.Content = "Unesite ceo broj!"; //treba proveriti da li je unesen ceo broj
                    result = false;
                }
            }
            //cin
            if (comboBoxCinovi.SelectedItem == null)
            {
                result = false;
                comboBoxCinovi.BorderBrush = Brushes.Red;
                comboBoxCinovi.BorderThickness = new Thickness(1);
                labelGreskaCin.Content = "Odaberite cin!";
            }
            else
            {
                comboBoxCinovi.BorderBrush = Brushes.Green;
                labelGreskaCin.Content = string.Empty;
            }
            //Detalji o clanu
            if (textBoxDetalji.Text.Trim().Equals(""))
            {
                labelGreskaDetalji.Content = "Unesite detalje o clanu!";
                textBoxDetalji.BorderBrush = Brushes.Red;
                
            }
            else
            {
                labelGreskaDetalji.Content = string.Empty; ;
                textBoxDetalji.BorderBrush = Brushes.Green;
            }
            return result;
        }

        
    }
}
