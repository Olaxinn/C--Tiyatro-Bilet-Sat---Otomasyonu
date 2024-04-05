using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
             // Login Ekranı

            string kullaniciadi = TxtBox_KullaniciAdi.Text;
            string sifre = TxtBox_Sifre.Text;
            if (kullaniciadi == "admin" && sifre == "admin")
            {
                MessageBox.Show("Giriş Başarılı!");

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!");
        }
    }
}
