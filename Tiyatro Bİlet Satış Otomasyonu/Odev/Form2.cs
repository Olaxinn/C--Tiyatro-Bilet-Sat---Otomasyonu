using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Odev
{
    public partial class Form2 : Form
    {
        // Mysql bağlantısı
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=tiyatro;Uid=root;Pwd=123456;");


        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        
        public Form2()
        {
            InitializeComponent();
        }
        private int sayac = 0;

        void VeriGetir()
           // Listeleme buttonun fonksiyonu
        {
            dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            adapter = new MySqlDataAdapter("Select * From biletler", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        void Temizle() // Temizle buttonunun kodları
        {
            TxtBox_Id.Text = "";
            Lbl_SecilenKoltuk.Text = "";
            Lbl_SecilenOyun.Text = "";
            Lbl_ToplamFiyat.Text = "";
            Lbl_Bilet_Tur.Text = "";

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            VeriGetir();
            //ListBox Öğeleri

            Oyunlar.Items.Add("Lüküs Hayat 13:00");
            Oyunlar.Items.Add("Cibali Karakolu 13:45");
            Oyunlar.Items.Add("Kanlı Nigar 14:20");
            Oyunlar.Items.Add("Yedi Kocalı Hürmüz 14:50");
            Oyunlar.Items.Add("Paydos 15:20");
            Oyunlar.Items.Add("Keşanlı Ali Destanı 16:00");
            Oyunlar.Items.Add("Şair Evlenmesi 16:45");
            Oyunlar.Items.Add("Köşebaşı 18:00");
            Oyunlar.Items.Add("İstanbul Efendisi 18:45");
            Oyunlar.Items.Add("Fehim Paşa Konağı 19:30");
    }
        private int sayacCocuk = 0;
        private int sayacOgrenci = 0;
        private int sayacYetiskin = 0;
        private const decimal biletFiyati = 50.00m; // Genel bilet fiyatı 50 TL olarak tanımlandı
        private const decimal ogrenciBiletFiyati = 25.00m; // Öğrenci bileti fiyatı 25 TL olarak tanımlandı
        private const decimal cocukBiletFiyati = 10.00m; // Çocuk bileti fiyatı 10 TL olarak tanımlandı

        private void Oyunlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Listbox'ta seçili metni label'a yazdır
            if (Oyunlar.SelectedItem != null)
            {
                Lbl_SecilenOyun.Text = Oyunlar.SelectedItem.ToString();
            }

        }

        // Koltuklara tıklandığında labela yazdıran kodlar

        private void Btn_Koltuk1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk24_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk23_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk22_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk21_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk20_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk19_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk18_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk17_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk16_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk15_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk14_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk13_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk12_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk11_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk10_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }

        private void Btn_Koltuk25_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Lbl_SecilenKoltuk.Text = clickedButton.Text;
        }
        
        private void Btn_Cocukarti_Click(object sender, EventArgs e) // Artı Eksi Buttonlarının Kodları
        {

            sayac++; // Sayaç değerini artır
            Lbl_Cocukdeger.Text = sayac.ToString(); // Label'i güncelle

            if (sender == Btn_Cocukarti)
            {
                sayacCocuk++;
                Lbl_Bilet_Tur.Text = "Çocuk Bileti"; // Label'a çocuk bileti yaz
            }
            else if (sender == Btn_Ogrenciarti)
            {
                sayacOgrenci++;
                Lbl_Bilet_Tur.Text = "Öğrenci Bileti"; // Label'a öğrenci bileti yaz
            }
            else if (sender == Btn_YetiskinArti)
            {
                sayacYetiskin++;
                Lbl_Bilet_Tur.Text = "Yetişkin Bileti"; // Label'a yetişkin bileti yaz
            }
            
            Hesapla(); // Hesaplamayı yap

        }

        private void Btn_Cocukeksi_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                Lbl_Bilet_Tur.Text = "..";
            }
            if (sayac > 0) // Sayaç değeri 0'dan büyükse
            {
                sayac--; // Sayaç değerini azalt
                Lbl_Cocukdeger.Text = sayac.ToString(); // Label'i güncelle
                if (sender == Btn_Cocukeksi && sayacCocuk > 0)
                {
                    sayacCocuk--;
                }
                else if (sender == Btn_Ogrencieksi && sayacOgrenci > 0) // 0 dan düşük olmaması için yazılan kodlar
                {
                    sayacOgrenci--;
                }
                else if (sender == Btn_YetiskinEksi && sayacYetiskin > 0)
                {
                    sayacYetiskin--;
                }

                Hesapla(); // Hesaplamayı yap
            }
        }

        private void Btn_Ogrenciarti_Click(object sender, EventArgs e)
        {
            sayacOgrenci++; // Öğrenci sayacını artır
            Lbl_OgrenciDeger.Text = sayacOgrenci.ToString(); // Öğrenci değerini güncelle

            Lbl_Bilet_Tur.Text = "Öğrenci Bileti"; // Label'a öğrenci bileti yaz

            if (sayacOgrenci == 0)
            {
                Lbl_Bilet_Tur.Text = ".."; // Öğrenci sayacı 0 ise label'a .. yaz
            }

            Hesapla(); // Hesaplamayı yap

        }

        private void Btn_Ogrencieksi_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                Lbl_Bilet_Tur.Text = "..";
            }
            if (sayacOgrenci > 0) // Öğrenci sayacı 0'dan büyükse
            {
                sayacOgrenci--; // Öğrenci sayacını azalt
                Lbl_OgrenciDeger.Text = sayacOgrenci.ToString(); // Öğrenci değerini güncelle
                Hesapla(); // Hesaplamayı yap
            }
        }

        private void Btn_YetiskinEksi_Click(object sender, EventArgs e)
        {

            if (sayacYetiskin > 0) // Yetişkin sayacı 0'dan büyükse
            {
                sayacYetiskin--; // Yetişkin sayacını azalt
                Lbl_YetiskinDeger.Text = sayacYetiskin.ToString(); // Yetişkin değerini güncelle
                Hesapla(); // Hesaplamayı yap
            }
            if (sayac == 0)
            {
                Lbl_Bilet_Tur.Text = "..";
            }
        }

        private void Btn_YetiskinArti_Click(object sender, EventArgs e)
        {
            Lbl_Bilet_Tur.Text = "Yetişkin Bileti"; // Label'a öğrenci bileti yaz
            sayacYetiskin++; // Yetişkin sayacını artır
            Lbl_YetiskinDeger.Text = sayacYetiskin.ToString(); // Yetişkin değerini güncelle
            Hesapla(); // Hesaplamayı yap

        }
        private void Hesapla()
        {
            decimal toplamFiyat = (sayacCocuk * cocukBiletFiyati) + (sayacOgrenci * ogrenciBiletFiyati) + (sayacYetiskin * biletFiyati);
            Lbl_ToplamFiyat.Text = toplamFiyat.ToString("C"); // C formatı ile toplam fiyatı TL olarak göster
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand komut = new MySqlCommand("INSERT INTO biletler ( id,oyun, bilet_sayi, fiyat) VALUES (@id,@oyun, @bilet_sayi, @fiyat)", conn);
                komut.Parameters.AddWithValue("@oyun", Lbl_SecilenOyun.Text);
                komut.Parameters.AddWithValue("@bilet_sayi",Lbl_Bilet_Tur.Text); // bilet sayı yerine bilet tür olacaktı
                komut.Parameters.AddWithValue("@fiyat", Lbl_ToplamFiyat.Text);
                komut.Parameters.AddWithValue("@id", TxtBox_Id.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
                MessageBox.Show($"Satılan Koltuklar: {Lbl_SecilenKoltuk.Text}");
                conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // DoubleClick olayı
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                int secim = dataGridView1.SelectedCells[0].RowIndex;
            TxtBox_Id.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            Lbl_SecilenKoltuk.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            Lbl_SecilenOyun.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            Lbl_ToplamFiyat.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();

            }
        }

        private void Lbl_Hesap_Click(object sender, EventArgs e)
        {

        }

        private string secilenKoltuklar = "";
  
        private void Btn_Sil_Click(object sender, EventArgs e) // Sil butonunun kodları
        {
            try
            {
                conn.Open();
                MySqlCommand sil = new MySqlCommand("DELETE FROM biletler WHERE id = @id", conn);
                sil.Parameters.AddWithValue("@id", Convert.ToInt32(TxtBox_Id.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
                conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e) // Güncelle butonu kodları
        {
            try
            {
                conn.Open();
                MySqlCommand guncelle = new MySqlCommand("UPDATE biletler SET oyun = @oyun, bilet_sayi = @bilet_sayi, fiyat = @fiyat WHERE id = @id", conn);
                guncelle.Parameters.AddWithValue("@oyun", Lbl_SecilenOyun.Text);
                guncelle.Parameters.AddWithValue("@bilet_sayi", Lbl_Bilet_Tur.Text);
                guncelle.Parameters.AddWithValue("@fiyat", Lbl_ToplamFiyat.Text);
                guncelle.Parameters.AddWithValue("@id", TxtBox_Id.Text);  
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Güncellendi");
                conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Temizle_Click(object sender, EventArgs e) // Temizle fonksiyonunu buttona eklenmesi
        {
            Temizle();
        }

        private void Lbl_SecilenKoltuk_Click(object sender, EventArgs e)
        {

        }
    }
}