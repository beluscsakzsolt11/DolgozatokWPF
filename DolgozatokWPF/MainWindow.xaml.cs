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
        }

    }
}