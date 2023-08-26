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
    public partial class Giriş_ekranı : Form
    {
       

        public Giriş_ekranı()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Film_Oneri.Kullanıcı_AnaSayfa göster = new Film_Oneri.Kullanıcı_AnaSayfa();
            göster.Show();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film_Oneri.Yetkili_AnaSayfa yetkili = new Film_Oneri.Yetkili_AnaSayfa();
            yetkili.Show();
            
            
        }
    }
}
