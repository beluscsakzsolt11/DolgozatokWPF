using System.Collections.Generic;
using System.Windows;

namespace DolgozatokWPF
{
    public class Dolgozat
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public int Pontszam { get; set; }

        public Dolgozat(string nev, int eletkor, int pontszam)
        {
            Nev = nev;
            Eletkor = eletkor;
            Pontszam = pontszam;
        }
    }

    public partial class MainWindow : Window
    {
        List<Dolgozat> dolgozatok = new List<Dolgozat>();
        public MainWindow()
        {
            InitializeComponent();
            dolgozatok.Add(new Dolgozat("Kiss Péter", 16, 87));
            dolgozatok.Add(new Dolgozat("Nagy Anna", 17, 92));
            dolgozatok.Add(new Dolgozat("Szabó Tamás", 16, 78));
            dolgozatok.Add(new Dolgozat("Tóth Éva", 18, 95));
            dolgozatok.Add(new Dolgozat("Varga Bence", 17, 81));
            dolgozatok.Add(new Dolgozat("Horváth Zsolt", 16, 65));
            dolgozatok.Add(new Dolgozat("Molnár Réka", 18, 89));
            dolgozatok.Add(new Dolgozat("Lakatos Dániel", 17, 72));

            dgDolgozatok.ItemsSource = dolgozatok;
        }

        private void btnHozzaadas_Click(object sender, RoutedEventArgs e)
        {
            string nev = txtNev.Text;
            int eletkor = int.Parse(txtEletkor.Text);
            int pontszam = int.Parse(txtPontszam.Text);

            dolgozatok.Add(new Dolgozat(nev, eletkor, pontszam));
            dgDolgozatok.Items.Refresh();

            MessageBox.Show("Sikeres hozzáadás!");

            txtNev.Clear();
            txtEletkor.Clear();
            txtPontszam.Clear();
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sikeres mentés");
        }
    }
}