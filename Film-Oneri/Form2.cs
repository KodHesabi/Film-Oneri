using System;
using System.Windows.Forms;

namespace Film_Oneri
{
    public partial class Kullanıcı_AnaSayfa : Form
    {
        public Kullanıcı_AnaSayfa()
        {
            InitializeComponent();
        }

        FilmlerContext filmlerContext1 = new FilmlerContext();
        private void button1_Click(object sender, EventArgs e)
        {

            Random a = new Random();
            int sayi = a.Next(0, 10);
            if(Oner_Combobox.SelectedIndex ==0)
            {
                var k = filmlerContext1.Korku.Find(sayi);
                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();
            }

            if (Oner_Combobox.SelectedIndex == 1)
            {
              var  k = filmlerContext1.Gerilim.Find(sayi);

                GetirFilmAdi.Text= k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }

            else if (Oner_Combobox.SelectedIndex == 2)
            {
                var k = filmlerContext1.BilimKurgu.Find(sayi);

                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }

            else if (Oner_Combobox.SelectedIndex == 3)
            {
                var k = filmlerContext1.Fantastik.Find(sayi);

                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }

            else if (Oner_Combobox.SelectedIndex == 4)
            {
                var k = filmlerContext1.Komedi.Find(sayi);

                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }

            else if (Oner_Combobox.SelectedIndex == 5)
            {
                var k = filmlerContext1.Macera.Find(sayi);

                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }

            else if (Oner_Combobox.SelectedIndex == 6)
            {
                var k = filmlerContext1.Savaş.Find(sayi);

                GetirFilmAdi.Text = k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }


        }
    }
}
