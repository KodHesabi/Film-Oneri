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
            int sayi = a.Next(0, 9);
            

            if (Oner_Combobox.SelectedIndex == 1)
            {
              var  k = filmlerContext1.Gerilim.Find(sayi);

                GetirFilmAdi.Text= k.FilmAdi;
                textBox3.Text = k.FilmYili.ToString();
                textBox2.Text = k.FilmImbd.ToString();

            }
            
           
        }
    }
}
