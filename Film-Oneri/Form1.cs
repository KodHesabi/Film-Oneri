using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Oneri
{
    public partial class Yetkili_AnaSayfa : Form
    {
        public Yetkili_AnaSayfa()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        FilmlerContext filmlerContext = new FilmlerContext();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                filmlerContext.Gerilim.Add(
                    new Gerilim
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 1)
            {
                filmlerContext.Korku.Add(
                    new Korku
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 2)
            {
                filmlerContext.BilimKurgu.Add(
                    new BilimKurgu
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 3)
            {
                filmlerContext.Fantastik.Add(
                    new Fantastik
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 4)
            {
                filmlerContext.Komedi.Add(
                    new Komedi
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 5)
            {
                filmlerContext.Macera.Add(
                    new Macera
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

            else if (comboBox1.SelectedIndex == 6)
            {
                filmlerContext.Savaş.Add(
                    new Savaş
                    {
                        FilmAdi = textBox1.Text,
                        FilmImbd = Convert.ToDouble(textBox2.Text),
                        FilmYili = Convert.ToInt32(textBox3.Text),

                    }

                    );

                var k = filmlerContext.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }


            }

   

           
        }

    }
}
