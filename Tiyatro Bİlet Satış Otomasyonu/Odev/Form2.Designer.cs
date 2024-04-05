namespace Odev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Oyunlar = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Biletler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Cocukdeger = new System.Windows.Forms.Label();
            this.Btn_Cocukarti = new System.Windows.Forms.Button();
            this.Btn_Cocukeksi = new System.Windows.Forms.Button();
            this.Btn_Ogrencieksi = new System.Windows.Forms.Button();
            this.Lbl_OgrenciDeger = new System.Windows.Forms.Label();
            this.Btn_Ogrenciarti = new System.Windows.Forms.Button();
            this.Btn_YetiskinEksi = new System.Windows.Forms.Button();
            this.Lbl_YetiskinDeger = new System.Windows.Forms.Label();
            this.Btn_YetiskinArti = new System.Windows.Forms.Button();
            this.Lbl_ToplamFiyat = new System.Windows.Forms.Label();
            this.Lbl_Hesap = new System.Windows.Forms.Label();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Koltuklar = new System.Windows.Forms.GroupBox();
            this.Btn_Koltuk25 = new System.Windows.Forms.Button();
            this.Btn_Koltuk24 = new System.Windows.Forms.Button();
            this.Btn_Koltuk23 = new System.Windows.Forms.Button();
            this.Btn_Koltuk22 = new System.Windows.Forms.Button();
            this.Btn_Koltuk21 = new System.Windows.Forms.Button();
            this.Btn_Koltuk20 = new System.Windows.Forms.Button();
            this.Btn_Koltuk19 = new System.Windows.Forms.Button();
            this.Btn_Koltuk18 = new System.Windows.Forms.Button();
            this.Btn_Koltuk17 = new System.Windows.Forms.Button();
            this.Btn_Koltuk16 = new System.Windows.Forms.Button();
            this.Btn_Koltuk15 = new System.Windows.Forms.Button();
            this.Btn_Koltuk14 = new System.Windows.Forms.Button();
            this.Btn_Koltuk13 = new System.Windows.Forms.Button();
            this.Btn_Koltuk12 = new System.Windows.Forms.Button();
            this.Btn_Koltuk11 = new System.Windows.Forms.Button();
            this.Btn_Koltuk10 = new System.Windows.Forms.Button();
            this.Btn_Koltuk9 = new System.Windows.Forms.Button();
            this.Btn_Koltuk8 = new System.Windows.Forms.Button();
            this.Btn_Koltuk7 = new System.Windows.Forms.Button();
            this.Btn_Koltuk6 = new System.Windows.Forms.Button();
            this.Btn_Koltuk5 = new System.Windows.Forms.Button();
            this.Btn_Koltuk4 = new System.Windows.Forms.Button();
            this.Btn_Koltuk3 = new System.Windows.Forms.Button();
            this.Btn_Koltuk2 = new System.Windows.Forms.Button();
            this.Btn_Koltuk1 = new System.Windows.Forms.Button();
            this.Lbl_KoltukNo = new System.Windows.Forms.Label();
            this.Lbl_SecilenKoltuk = new System.Windows.Forms.Label();
            this.Lbl_Oyun = new System.Windows.Forms.Label();
            this.Lbl_SecilenOyun = new System.Windows.Forms.Label();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.Btn_Temizle = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.Lbl_Bilet = new System.Windows.Forms.Label();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.Lbl_Bilet_Tur = new System.Windows.Forms.Label();
            this.Fiyatlar = new System.Windows.Forms.ListBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.TxtBox_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Koltuklar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Oyunlar
            // 
            this.Oyunlar.BackColor = System.Drawing.Color.Yellow;
            this.Oyunlar.FormattingEnabled = true;
            this.Oyunlar.ItemHeight = 16;
            this.Oyunlar.Items.AddRange(new object[] {
            "Lüküs Hayat 13:00",
            "Cibali Karakolu 13:45",
            "Kanlı Nigar 14:20",
            "Yedi Kocalı Hürmüz 14:50",
            "Paydos 15:20",
            "Keşanlı Ali Destanı 16:00",
            "Şair Evlenmesi 16:45",
            "Toros Canavarı 17:15",
            "Köşebaşı 18:00",
            "İstanbul Efendisi 18:45",
            "Fehim Paşa Konağı 19:30"});
            this.Oyunlar.Location = new System.Drawing.Point(0, 1);
            this.Oyunlar.Name = "Oyunlar";
            this.Oyunlar.Size = new System.Drawing.Size(291, 388);
            this.Oyunlar.TabIndex = 0;
            this.Oyunlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Oyunlar_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1112, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Biletler
            // 
            this.Biletler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Biletler.FormattingEnabled = true;
            this.Biletler.ItemHeight = 16;
            this.Biletler.Location = new System.Drawing.Point(276, -3);
            this.Biletler.Name = "Biletler";
            this.Biletler.Size = new System.Drawing.Size(297, 388);
            this.Biletler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(299, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Bilet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(299, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "0-7 Yaş Bilet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(299, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yetişkin Bİlet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Cocukdeger
            // 
            this.Lbl_Cocukdeger.AutoSize = true;
            this.Lbl_Cocukdeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Cocukdeger.Location = new System.Drawing.Point(505, 38);
            this.Lbl_Cocukdeger.Name = "Lbl_Cocukdeger";
            this.Lbl_Cocukdeger.Size = new System.Drawing.Size(16, 16);
            this.Lbl_Cocukdeger.TabIndex = 6;
            this.Lbl_Cocukdeger.Text = "0";
            this.Lbl_Cocukdeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Cocukarti
            // 
            this.Btn_Cocukarti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Cocukarti.Location = new System.Drawing.Point(527, 35);
            this.Btn_Cocukarti.Name = "Btn_Cocukarti";
            this.Btn_Cocukarti.Size = new System.Drawing.Size(34, 23);
            this.Btn_Cocukarti.TabIndex = 7;
            this.Btn_Cocukarti.Text = "+";
            this.Btn_Cocukarti.UseVisualStyleBackColor = false;
            this.Btn_Cocukarti.Click += new System.EventHandler(this.Btn_Cocukarti_Click);
            // 
            // Btn_Cocukeksi
            // 
            this.Btn_Cocukeksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Cocukeksi.Location = new System.Drawing.Point(465, 35);
            this.Btn_Cocukeksi.Name = "Btn_Cocukeksi";
            this.Btn_Cocukeksi.Size = new System.Drawing.Size(34, 23);
            this.Btn_Cocukeksi.TabIndex = 8;
            this.Btn_Cocukeksi.Text = "-";
            this.Btn_Cocukeksi.UseVisualStyleBackColor = false;
            this.Btn_Cocukeksi.Click += new System.EventHandler(this.Btn_Cocukeksi_Click);
            // 
            // Btn_Ogrencieksi
            // 
            this.Btn_Ogrencieksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Ogrencieksi.Location = new System.Drawing.Point(465, 69);
            this.Btn_Ogrencieksi.Name = "Btn_Ogrencieksi";
            this.Btn_Ogrencieksi.Size = new System.Drawing.Size(34, 23);
            this.Btn_Ogrencieksi.TabIndex = 9;
            this.Btn_Ogrencieksi.Text = "-";
            this.Btn_Ogrencieksi.UseVisualStyleBackColor = false;
            this.Btn_Ogrencieksi.Click += new System.EventHandler(this.Btn_Ogrencieksi_Click);
            // 
            // Lbl_OgrenciDeger
            // 
            this.Lbl_OgrenciDeger.AutoSize = true;
            this.Lbl_OgrenciDeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_OgrenciDeger.Location = new System.Drawing.Point(505, 72);
            this.Lbl_OgrenciDeger.Name = "Lbl_OgrenciDeger";
            this.Lbl_OgrenciDeger.Size = new System.Drawing.Size(16, 16);
            this.Lbl_OgrenciDeger.TabIndex = 10;
            this.Lbl_OgrenciDeger.Text = "0";
            this.Lbl_OgrenciDeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Ogrenciarti
            // 
            this.Btn_Ogrenciarti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Ogrenciarti.Location = new System.Drawing.Point(527, 69);
            this.Btn_Ogrenciarti.Name = "Btn_Ogrenciarti";
            this.Btn_Ogrenciarti.Size = new System.Drawing.Size(34, 23);
            this.Btn_Ogrenciarti.TabIndex = 11;
            this.Btn_Ogrenciarti.Text = "+";
            this.Btn_Ogrenciarti.UseVisualStyleBackColor = false;
            this.Btn_Ogrenciarti.Click += new System.EventHandler(this.Btn_Ogrenciarti_Click);
            // 
            // Btn_YetiskinEksi
            // 
            this.Btn_YetiskinEksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_YetiskinEksi.Location = new System.Drawing.Point(465, 103);
            this.Btn_YetiskinEksi.Name = "Btn_YetiskinEksi";
            this.Btn_YetiskinEksi.Size = new System.Drawing.Size(34, 23);
            this.Btn_YetiskinEksi.TabIndex = 12;
            this.Btn_YetiskinEksi.Text = "-";
            this.Btn_YetiskinEksi.UseVisualStyleBackColor = false;
            this.Btn_YetiskinEksi.Click += new System.EventHandler(this.Btn_YetiskinEksi_Click);
            // 
            // Lbl_YetiskinDeger
            // 
            this.Lbl_YetiskinDeger.AutoSize = true;
            this.Lbl_YetiskinDeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_YetiskinDeger.Location = new System.Drawing.Point(505, 106);
            this.Lbl_YetiskinDeger.Name = "Lbl_YetiskinDeger";
            this.Lbl_YetiskinDeger.Size = new System.Drawing.Size(16, 16);
            this.Lbl_YetiskinDeger.TabIndex = 13;
            this.Lbl_YetiskinDeger.Text = "0";
            this.Lbl_YetiskinDeger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_YetiskinArti
            // 
            this.Btn_YetiskinArti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_YetiskinArti.Location = new System.Drawing.Point(527, 103);
            this.Btn_YetiskinArti.Name = "Btn_YetiskinArti";
            this.Btn_YetiskinArti.Size = new System.Drawing.Size(34, 23);
            this.Btn_YetiskinArti.TabIndex = 14;
            this.Btn_YetiskinArti.Text = "+";
            this.Btn_YetiskinArti.UseVisualStyleBackColor = false;
            this.Btn_YetiskinArti.Click += new System.EventHandler(this.Btn_YetiskinArti_Click);
            // 
            // Lbl_ToplamFiyat
            // 
            this.Lbl_ToplamFiyat.AutoSize = true;
            this.Lbl_ToplamFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_ToplamFiyat.Location = new System.Drawing.Point(366, 192);
            this.Lbl_ToplamFiyat.Name = "Lbl_ToplamFiyat";
            this.Lbl_ToplamFiyat.Size = new System.Drawing.Size(16, 16);
            this.Lbl_ToplamFiyat.TabIndex = 15;
            this.Lbl_ToplamFiyat.Text = "0";
            this.Lbl_ToplamFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Hesap
            // 
            this.Lbl_Hesap.AutoSize = true;
            this.Lbl_Hesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Hesap.Location = new System.Drawing.Point(297, 192);
            this.Lbl_Hesap.Name = "Lbl_Hesap";
            this.Lbl_Hesap.Size = new System.Drawing.Size(63, 16);
            this.Lbl_Hesap.TabIndex = 16;
            this.Lbl_Hesap.Text = "Hesap :";
            this.Lbl_Hesap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Hesap.Click += new System.EventHandler(this.Lbl_Hesap_Click);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Ekle.Location = new System.Drawing.Point(286, 261);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(78, 34);
            this.Btn_Ekle.TabIndex = 17;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = false;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Guncelle.Location = new System.Drawing.Point(370, 261);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(90, 34);
            this.Btn_Guncelle.TabIndex = 18;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Sil.Location = new System.Drawing.Point(471, 261);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(90, 34);
            this.Btn_Sil.TabIndex = 19;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Koltuklar
            // 
            this.Koltuklar.BackColor = System.Drawing.Color.Gray;
            this.Koltuklar.Controls.Add(this.Btn_Koltuk25);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk24);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk23);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk22);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk21);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk20);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk19);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk18);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk17);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk16);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk15);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk14);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk13);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk12);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk11);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk10);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk9);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk8);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk7);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk6);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk5);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk4);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk3);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk2);
            this.Koltuklar.Controls.Add(this.Btn_Koltuk1);
            this.Koltuklar.Location = new System.Drawing.Point(573, 1);
            this.Koltuklar.Name = "Koltuklar";
            this.Koltuklar.Size = new System.Drawing.Size(530, 388);
            this.Koltuklar.TabIndex = 20;
            this.Koltuklar.TabStop = false;
            this.Koltuklar.Text = "Koltuk";
            // 
            // Btn_Koltuk25
            // 
            this.Btn_Koltuk25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk25.Location = new System.Drawing.Point(374, 300);
            this.Btn_Koltuk25.Name = "Btn_Koltuk25";
            this.Btn_Koltuk25.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk25.TabIndex = 24;
            this.Btn_Koltuk25.Text = "Koltuk 25";
            this.Btn_Koltuk25.UseVisualStyleBackColor = false;
            this.Btn_Koltuk25.Click += new System.EventHandler(this.Btn_Koltuk25_Click);
            // 
            // Btn_Koltuk24
            // 
            this.Btn_Koltuk24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk24.Location = new System.Drawing.Point(282, 300);
            this.Btn_Koltuk24.Name = "Btn_Koltuk24";
            this.Btn_Koltuk24.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk24.TabIndex = 23;
            this.Btn_Koltuk24.Text = "Koltuk 24";
            this.Btn_Koltuk24.UseVisualStyleBackColor = false;
            this.Btn_Koltuk24.Click += new System.EventHandler(this.Btn_Koltuk24_Click);
            // 
            // Btn_Koltuk23
            // 
            this.Btn_Koltuk23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk23.Location = new System.Drawing.Point(190, 300);
            this.Btn_Koltuk23.Name = "Btn_Koltuk23";
            this.Btn_Koltuk23.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk23.TabIndex = 22;
            this.Btn_Koltuk23.Text = "Koltuk 23";
            this.Btn_Koltuk23.UseVisualStyleBackColor = false;
            this.Btn_Koltuk23.Click += new System.EventHandler(this.Btn_Koltuk23_Click);
            // 
            // Btn_Koltuk22
            // 
            this.Btn_Koltuk22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk22.Location = new System.Drawing.Point(98, 300);
            this.Btn_Koltuk22.Name = "Btn_Koltuk22";
            this.Btn_Koltuk22.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk22.TabIndex = 21;
            this.Btn_Koltuk22.Text = "Koltuk 22";
            this.Btn_Koltuk22.UseVisualStyleBackColor = false;
            this.Btn_Koltuk22.Click += new System.EventHandler(this.Btn_Koltuk22_Click);
            // 
            // Btn_Koltuk21
            // 
            this.Btn_Koltuk21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk21.Location = new System.Drawing.Point(6, 300);
            this.Btn_Koltuk21.Name = "Btn_Koltuk21";
            this.Btn_Koltuk21.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk21.TabIndex = 20;
            this.Btn_Koltuk21.Text = "Koltuk 21";
            this.Btn_Koltuk21.UseVisualStyleBackColor = false;
            this.Btn_Koltuk21.Click += new System.EventHandler(this.Btn_Koltuk21_Click);
            // 
            // Btn_Koltuk20
            // 
            this.Btn_Koltuk20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk20.Location = new System.Drawing.Point(374, 235);
            this.Btn_Koltuk20.Name = "Btn_Koltuk20";
            this.Btn_Koltuk20.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk20.TabIndex = 19;
            this.Btn_Koltuk20.Text = "Koltuk 20";
            this.Btn_Koltuk20.UseVisualStyleBackColor = false;
            this.Btn_Koltuk20.Click += new System.EventHandler(this.Btn_Koltuk20_Click);
            // 
            // Btn_Koltuk19
            // 
            this.Btn_Koltuk19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk19.Location = new System.Drawing.Point(282, 235);
            this.Btn_Koltuk19.Name = "Btn_Koltuk19";
            this.Btn_Koltuk19.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk19.TabIndex = 18;
            this.Btn_Koltuk19.Text = "Koltuk 19";
            this.Btn_Koltuk19.UseVisualStyleBackColor = false;
            this.Btn_Koltuk19.Click += new System.EventHandler(this.Btn_Koltuk19_Click);
            // 
            // Btn_Koltuk18
            // 
            this.Btn_Koltuk18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk18.Location = new System.Drawing.Point(190, 235);
            this.Btn_Koltuk18.Name = "Btn_Koltuk18";
            this.Btn_Koltuk18.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk18.TabIndex = 17;
            this.Btn_Koltuk18.Text = "Koltuk 18";
            this.Btn_Koltuk18.UseVisualStyleBackColor = false;
            this.Btn_Koltuk18.Click += new System.EventHandler(this.Btn_Koltuk18_Click);
            // 
            // Btn_Koltuk17
            // 
            this.Btn_Koltuk17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk17.Location = new System.Drawing.Point(98, 235);
            this.Btn_Koltuk17.Name = "Btn_Koltuk17";
            this.Btn_Koltuk17.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk17.TabIndex = 16;
            this.Btn_Koltuk17.Text = "Koltuk 17";
            this.Btn_Koltuk17.UseVisualStyleBackColor = false;
            this.Btn_Koltuk17.Click += new System.EventHandler(this.Btn_Koltuk17_Click);
            // 
            // Btn_Koltuk16
            // 
            this.Btn_Koltuk16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk16.Location = new System.Drawing.Point(6, 235);
            this.Btn_Koltuk16.Name = "Btn_Koltuk16";
            this.Btn_Koltuk16.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk16.TabIndex = 15;
            this.Btn_Koltuk16.Text = "Koltuk 16";
            this.Btn_Koltuk16.UseVisualStyleBackColor = false;
            this.Btn_Koltuk16.Click += new System.EventHandler(this.Btn_Koltuk16_Click);
            // 
            // Btn_Koltuk15
            // 
            this.Btn_Koltuk15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk15.Location = new System.Drawing.Point(374, 170);
            this.Btn_Koltuk15.Name = "Btn_Koltuk15";
            this.Btn_Koltuk15.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk15.TabIndex = 14;
            this.Btn_Koltuk15.Text = "Koltuk 15";
            this.Btn_Koltuk15.UseVisualStyleBackColor = false;
            this.Btn_Koltuk15.Click += new System.EventHandler(this.Btn_Koltuk15_Click);
            // 
            // Btn_Koltuk14
            // 
            this.Btn_Koltuk14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk14.Location = new System.Drawing.Point(282, 170);
            this.Btn_Koltuk14.Name = "Btn_Koltuk14";
            this.Btn_Koltuk14.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk14.TabIndex = 13;
            this.Btn_Koltuk14.Text = "Koltuk 14";
            this.Btn_Koltuk14.UseVisualStyleBackColor = false;
            this.Btn_Koltuk14.Click += new System.EventHandler(this.Btn_Koltuk14_Click);
            // 
            // Btn_Koltuk13
            // 
            this.Btn_Koltuk13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk13.Location = new System.Drawing.Point(190, 170);
            this.Btn_Koltuk13.Name = "Btn_Koltuk13";
            this.Btn_Koltuk13.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk13.TabIndex = 12;
            this.Btn_Koltuk13.Text = "Koltuk 13";
            this.Btn_Koltuk13.UseVisualStyleBackColor = false;
            this.Btn_Koltuk13.Click += new System.EventHandler(this.Btn_Koltuk13_Click);
            // 
            // Btn_Koltuk12
            // 
            this.Btn_Koltuk12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk12.Location = new System.Drawing.Point(98, 170);
            this.Btn_Koltuk12.Name = "Btn_Koltuk12";
            this.Btn_Koltuk12.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk12.TabIndex = 11;
            this.Btn_Koltuk12.Text = "Koltuk 12";
            this.Btn_Koltuk12.UseVisualStyleBackColor = false;
            this.Btn_Koltuk12.Click += new System.EventHandler(this.Btn_Koltuk12_Click);
            // 
            // Btn_Koltuk11
            // 
            this.Btn_Koltuk11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk11.Location = new System.Drawing.Point(6, 170);
            this.Btn_Koltuk11.Name = "Btn_Koltuk11";
            this.Btn_Koltuk11.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk11.TabIndex = 10;
            this.Btn_Koltuk11.Text = "Koltuk 11";
            this.Btn_Koltuk11.UseVisualStyleBackColor = false;
            this.Btn_Koltuk11.Click += new System.EventHandler(this.Btn_Koltuk11_Click);
            // 
            // Btn_Koltuk10
            // 
            this.Btn_Koltuk10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk10.Location = new System.Drawing.Point(374, 105);
            this.Btn_Koltuk10.Name = "Btn_Koltuk10";
            this.Btn_Koltuk10.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk10.TabIndex = 9;
            this.Btn_Koltuk10.Text = "Koltuk 10";
            this.Btn_Koltuk10.UseVisualStyleBackColor = false;
            this.Btn_Koltuk10.Click += new System.EventHandler(this.Btn_Koltuk10_Click);
            // 
            // Btn_Koltuk9
            // 
            this.Btn_Koltuk9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk9.Location = new System.Drawing.Point(282, 105);
            this.Btn_Koltuk9.Name = "Btn_Koltuk9";
            this.Btn_Koltuk9.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk9.TabIndex = 8;
            this.Btn_Koltuk9.Text = "Koltuk 9";
            this.Btn_Koltuk9.UseVisualStyleBackColor = false;
            this.Btn_Koltuk9.Click += new System.EventHandler(this.Btn_Koltuk9_Click);
            // 
            // Btn_Koltuk8
            // 
            this.Btn_Koltuk8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk8.Location = new System.Drawing.Point(190, 105);
            this.Btn_Koltuk8.Name = "Btn_Koltuk8";
            this.Btn_Koltuk8.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk8.TabIndex = 7;
            this.Btn_Koltuk8.Text = "Koltuk 8";
            this.Btn_Koltuk8.UseVisualStyleBackColor = false;
            this.Btn_Koltuk8.Click += new System.EventHandler(this.Btn_Koltuk8_Click);
            // 
            // Btn_Koltuk7
            // 
            this.Btn_Koltuk7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk7.Location = new System.Drawing.Point(98, 105);
            this.Btn_Koltuk7.Name = "Btn_Koltuk7";
            this.Btn_Koltuk7.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk7.TabIndex = 6;
            this.Btn_Koltuk7.Text = "Koltuk 7";
            this.Btn_Koltuk7.UseVisualStyleBackColor = false;
            this.Btn_Koltuk7.Click += new System.EventHandler(this.Btn_Koltuk7_Click);
            // 
            // Btn_Koltuk6
            // 
            this.Btn_Koltuk6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk6.Location = new System.Drawing.Point(6, 105);
            this.Btn_Koltuk6.Name = "Btn_Koltuk6";
            this.Btn_Koltuk6.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk6.TabIndex = 5;
            this.Btn_Koltuk6.Text = "Koltuk 6";
            this.Btn_Koltuk6.UseVisualStyleBackColor = false;
            this.Btn_Koltuk6.Click += new System.EventHandler(this.Btn_Koltuk6_Click);
            // 
            // Btn_Koltuk5
            // 
            this.Btn_Koltuk5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk5.Location = new System.Drawing.Point(374, 34);
            this.Btn_Koltuk5.Name = "Btn_Koltuk5";
            this.Btn_Koltuk5.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk5.TabIndex = 4;
            this.Btn_Koltuk5.Text = "Koltuk 5";
            this.Btn_Koltuk5.UseVisualStyleBackColor = false;
            this.Btn_Koltuk5.Click += new System.EventHandler(this.Btn_Koltuk5_Click);
            // 
            // Btn_Koltuk4
            // 
            this.Btn_Koltuk4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk4.Location = new System.Drawing.Point(282, 32);
            this.Btn_Koltuk4.Name = "Btn_Koltuk4";
            this.Btn_Koltuk4.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk4.TabIndex = 3;
            this.Btn_Koltuk4.Text = "Koltuk 4";
            this.Btn_Koltuk4.UseVisualStyleBackColor = false;
            this.Btn_Koltuk4.Click += new System.EventHandler(this.Btn_Koltuk4_Click);
            // 
            // Btn_Koltuk3
            // 
            this.Btn_Koltuk3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk3.Location = new System.Drawing.Point(190, 32);
            this.Btn_Koltuk3.Name = "Btn_Koltuk3";
            this.Btn_Koltuk3.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk3.TabIndex = 2;
            this.Btn_Koltuk3.Text = "Koltuk 3";
            this.Btn_Koltuk3.UseVisualStyleBackColor = false;
            this.Btn_Koltuk3.Click += new System.EventHandler(this.Btn_Koltuk3_Click);
            // 
            // Btn_Koltuk2
            // 
            this.Btn_Koltuk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk2.Location = new System.Drawing.Point(98, 32);
            this.Btn_Koltuk2.Name = "Btn_Koltuk2";
            this.Btn_Koltuk2.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk2.TabIndex = 1;
            this.Btn_Koltuk2.Text = "Koltuk 2";
            this.Btn_Koltuk2.UseVisualStyleBackColor = false;
            this.Btn_Koltuk2.Click += new System.EventHandler(this.Btn_Koltuk2_Click);
            // 
            // Btn_Koltuk1
            // 
            this.Btn_Koltuk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Koltuk1.Location = new System.Drawing.Point(6, 32);
            this.Btn_Koltuk1.Name = "Btn_Koltuk1";
            this.Btn_Koltuk1.Size = new System.Drawing.Size(86, 59);
            this.Btn_Koltuk1.TabIndex = 0;
            this.Btn_Koltuk1.Text = "Koltuk 1";
            this.Btn_Koltuk1.UseVisualStyleBackColor = false;
            this.Btn_Koltuk1.Click += new System.EventHandler(this.Btn_Koltuk1_Click);
            // 
            // Lbl_KoltukNo
            // 
            this.Lbl_KoltukNo.AutoSize = true;
            this.Lbl_KoltukNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_KoltukNo.Location = new System.Drawing.Point(299, 136);
            this.Lbl_KoltukNo.Name = "Lbl_KoltukNo";
            this.Lbl_KoltukNo.Size = new System.Drawing.Size(85, 16);
            this.Lbl_KoltukNo.TabIndex = 21;
            this.Lbl_KoltukNo.Text = "Koltuk No:";
            this.Lbl_KoltukNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SecilenKoltuk
            // 
            this.Lbl_SecilenKoltuk.AutoSize = true;
            this.Lbl_SecilenKoltuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_SecilenKoltuk.Location = new System.Drawing.Point(388, 136);
            this.Lbl_SecilenKoltuk.Name = "Lbl_SecilenKoltuk";
            this.Lbl_SecilenKoltuk.Size = new System.Drawing.Size(133, 16);
            this.Lbl_SecilenKoltuk.TabIndex = 22;
            this.Lbl_SecilenKoltuk.Text = "Koltuk Seçilmedi";
            this.Lbl_SecilenKoltuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_SecilenKoltuk.Click += new System.EventHandler(this.Lbl_SecilenKoltuk_Click);
            // 
            // Lbl_Oyun
            // 
            this.Lbl_Oyun.AutoSize = true;
            this.Lbl_Oyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Oyun.Location = new System.Drawing.Point(297, 162);
            this.Lbl_Oyun.Name = "Lbl_Oyun";
            this.Lbl_Oyun.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Oyun.TabIndex = 23;
            this.Lbl_Oyun.Text = "Oyun :";
            this.Lbl_Oyun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SecilenOyun
            // 
            this.Lbl_SecilenOyun.AutoSize = true;
            this.Lbl_SecilenOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_SecilenOyun.Location = new System.Drawing.Point(358, 162);
            this.Lbl_SecilenOyun.Name = "Lbl_SecilenOyun";
            this.Lbl_SecilenOyun.Size = new System.Drawing.Size(124, 16);
            this.Lbl_SecilenOyun.TabIndex = 24;
            this.Lbl_SecilenOyun.Text = "Oyun Seçilmedi";
            this.Lbl_SecilenOyun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Listele.Location = new System.Drawing.Point(286, 313);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(78, 34);
            this.Btn_Listele.TabIndex = 28;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = false;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Temizle.Location = new System.Drawing.Point(370, 313);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(78, 34);
            this.Btn_Temizle.TabIndex = 29;
            this.Btn_Temizle.Text = "Temizle";
            this.Btn_Temizle.UseVisualStyleBackColor = false;
            this.Btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Lbl_Bilet
            // 
            this.Lbl_Bilet.AutoSize = true;
            this.Lbl_Bilet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Bilet.Location = new System.Drawing.Point(297, 214);
            this.Lbl_Bilet.Name = "Lbl_Bilet";
            this.Lbl_Bilet.Size = new System.Drawing.Size(90, 16);
            this.Lbl_Bilet.TabIndex = 30;
            this.Lbl_Bilet.Text = "Bilet Tür : ";
            this.Lbl_Bilet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // Lbl_Bilet_Tur
            // 
            this.Lbl_Bilet_Tur.AutoSize = true;
            this.Lbl_Bilet_Tur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Bilet_Tur.Location = new System.Drawing.Point(388, 214);
            this.Lbl_Bilet_Tur.Name = "Lbl_Bilet_Tur";
            this.Lbl_Bilet_Tur.Size = new System.Drawing.Size(15, 16);
            this.Lbl_Bilet_Tur.TabIndex = 31;
            this.Lbl_Bilet_Tur.Text = "..";
            this.Lbl_Bilet_Tur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fiyatlar
            // 
            this.Fiyatlar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Fiyatlar.FormattingEnabled = true;
            this.Fiyatlar.ItemHeight = 16;
            this.Fiyatlar.Items.AddRange(new object[] {
            "0-7 Yaş Bileti: 10TL",
            "",
            "Öğrenci Bileti : 25TL",
            "",
            "Yetişkin Bileti : 50TL"});
            this.Fiyatlar.Location = new System.Drawing.Point(0, 214);
            this.Fiyatlar.Name = "Fiyatlar";
            this.Fiyatlar.Size = new System.Drawing.Size(280, 180);
            this.Fiyatlar.TabIndex = 32;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Id.Location = new System.Drawing.Point(299, 236);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(39, 16);
            this.Lbl_Id.TabIndex = 33;
            this.Lbl_Id.Text = "ID : ";
            this.Lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBox_Id
            // 
            this.TxtBox_Id.Location = new System.Drawing.Point(331, 233);
            this.TxtBox_Id.Name = "TxtBox_Id";
            this.TxtBox_Id.Size = new System.Drawing.Size(22, 23);
            this.TxtBox_Id.TabIndex = 34;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 587);
            this.Controls.Add(this.TxtBox_Id);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Fiyatlar);
            this.Controls.Add(this.Lbl_Bilet_Tur);
            this.Controls.Add(this.Lbl_Bilet);
            this.Controls.Add(this.Btn_Temizle);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.Lbl_SecilenOyun);
            this.Controls.Add(this.Lbl_Oyun);
            this.Controls.Add(this.Lbl_SecilenKoltuk);
            this.Controls.Add(this.Lbl_KoltukNo);
            this.Controls.Add(this.Koltuklar);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Lbl_Hesap);
            this.Controls.Add(this.Lbl_ToplamFiyat);
            this.Controls.Add(this.Btn_YetiskinArti);
            this.Controls.Add(this.Lbl_YetiskinDeger);
            this.Controls.Add(this.Btn_YetiskinEksi);
            this.Controls.Add(this.Btn_Ogrenciarti);
            this.Controls.Add(this.Lbl_OgrenciDeger);
            this.Controls.Add(this.Btn_Ogrencieksi);
            this.Controls.Add(this.Btn_Cocukeksi);
            this.Controls.Add(this.Btn_Cocukarti);
            this.Controls.Add(this.Lbl_Cocukdeger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Biletler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Oyunlar);
            this.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Koltuklar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Oyunlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox Biletler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Cocukdeger;
        private System.Windows.Forms.Button Btn_Cocukarti;
        private System.Windows.Forms.Button Btn_Cocukeksi;
        private System.Windows.Forms.Button Btn_Ogrencieksi;
        private System.Windows.Forms.Label Lbl_OgrenciDeger;
        private System.Windows.Forms.Button Btn_Ogrenciarti;
        private System.Windows.Forms.Button Btn_YetiskinEksi;
        private System.Windows.Forms.Label Lbl_YetiskinDeger;
        private System.Windows.Forms.Button Btn_YetiskinArti;
        private System.Windows.Forms.Label Lbl_ToplamFiyat;
        private System.Windows.Forms.Label Lbl_Hesap;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.GroupBox Koltuklar;
        private System.Windows.Forms.Button Btn_Koltuk25;
        private System.Windows.Forms.Button Btn_Koltuk24;
        private System.Windows.Forms.Button Btn_Koltuk23;
        private System.Windows.Forms.Button Btn_Koltuk22;
        private System.Windows.Forms.Button Btn_Koltuk21;
        private System.Windows.Forms.Button Btn_Koltuk20;
        private System.Windows.Forms.Button Btn_Koltuk19;
        private System.Windows.Forms.Button Btn_Koltuk18;
        private System.Windows.Forms.Button Btn_Koltuk17;
        private System.Windows.Forms.Button Btn_Koltuk16;
        private System.Windows.Forms.Button Btn_Koltuk15;
        private System.Windows.Forms.Button Btn_Koltuk14;
        private System.Windows.Forms.Button Btn_Koltuk13;
        private System.Windows.Forms.Button Btn_Koltuk12;
        private System.Windows.Forms.Button Btn_Koltuk11;
        private System.Windows.Forms.Button Btn_Koltuk10;
        private System.Windows.Forms.Button Btn_Koltuk9;
        private System.Windows.Forms.Button Btn_Koltuk8;
        private System.Windows.Forms.Button Btn_Koltuk7;
        private System.Windows.Forms.Button Btn_Koltuk6;
        private System.Windows.Forms.Button Btn_Koltuk5;
        private System.Windows.Forms.Button Btn_Koltuk4;
        private System.Windows.Forms.Button Btn_Koltuk3;
        private System.Windows.Forms.Button Btn_Koltuk2;
        private System.Windows.Forms.Button Btn_Koltuk1;
        private System.Windows.Forms.Label Lbl_KoltukNo;
        private System.Windows.Forms.Label Lbl_SecilenKoltuk;
        private System.Windows.Forms.Label Lbl_Oyun;
        private System.Windows.Forms.Label Lbl_SecilenOyun;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Button Btn_Temizle;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label Lbl_Bilet;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.Label Lbl_Bilet_Tur;
        private System.Windows.Forms.ListBox Fiyatlar;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.TextBox TxtBox_Id;
    }
}