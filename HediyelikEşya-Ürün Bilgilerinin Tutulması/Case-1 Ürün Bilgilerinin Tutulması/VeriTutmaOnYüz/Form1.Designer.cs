namespace VeriTutmaOnYüz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUrunID = new Label();
            lblUrunAdi = new Label();
            lblUrunFiyati = new Label();
            lblUrunAciklamasi = new Label();
            label5 = new Label();
            lblUrunKategori = new Label();
            label7 = new Label();
            lblGuncellenenID = new Label();
            label9 = new Label();
            txtUrunID = new TextBox();
            txtUrunAdi = new TextBox();
            txtUrunFiyati = new TextBox();
            txtUrunAciklamasi = new TextBox();
            txtGuncellenecekUrunID = new TextBox();
            txtSilinecekUrunID = new TextBox();
            pbUrunResmi = new PictureBox();
            cmbParaBirimi = new ComboBox();
            cmbUrunKategori = new ComboBox();
            label1 = new Label();
            txtAranacakUrunID = new TextBox();
            dgvUrunBilgileri = new DataGridView();
            btnGuncelle = new Button();
            btnUrunEkle = new Button();
            btnResimEkle = new Button();
            btnUrunSil = new Button();
            btnUrunAra = new Button();
            btnDosyayaYaz = new Button();
            btnDosyadanOku = new Button();
            btnTabloyuTemizle = new Button();
            btnUrunleriListele = new Button();
            ofdResimSec = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUrunResmi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunBilgileri).BeginInit();
            SuspendLayout();
            // 
            // lblUrunID
            // 
            lblUrunID.AutoSize = true;
            lblUrunID.Location = new Point(40, 44);
            lblUrunID.Name = "lblUrunID";
            lblUrunID.Size = new Size(62, 20);
            lblUrunID.TabIndex = 0;
            lblUrunID.Text = "Ürün ID:";
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(40, 104);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(70, 20);
            lblUrunAdi.TabIndex = 1;
            lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblUrunFiyati
            // 
            lblUrunFiyati.AutoSize = true;
            lblUrunFiyati.Location = new Point(40, 172);
            lblUrunFiyati.Name = "lblUrunFiyati";
            lblUrunFiyati.Size = new Size(82, 20);
            lblUrunFiyati.TabIndex = 2;
            lblUrunFiyati.Text = "Ürün Fiyatı:";
            // 
            // lblUrunAciklamasi
            // 
            lblUrunAciklamasi.AutoSize = true;
            lblUrunAciklamasi.Location = new Point(40, 228);
            lblUrunAciklamasi.Name = "lblUrunAciklamasi";
            lblUrunAciklamasi.Size = new Size(118, 20);
            lblUrunAciklamasi.TabIndex = 3;
            lblUrunAciklamasi.Text = "Ürün Açıklaması:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 281);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Ürün Resmi:";
            // 
            // lblUrunKategori
            // 
            lblUrunKategori.AutoSize = true;
            lblUrunKategori.Location = new Point(23, 514);
            lblUrunKategori.Name = "lblUrunKategori";
            lblUrunKategori.Size = new Size(114, 20);
            lblUrunKategori.TabIndex = 5;
            lblUrunKategori.Text = "Ürün Kategorisi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1355, 93);
            label7.Name = "label7";
            label7.Size = new Size(211, 20);
            label7.TabIndex = 6;
            label7.Text = "Silmek İstediğiniz Ürünün ID'si:";
            // 
            // lblGuncellenenID
            // 
            lblGuncellenenID.AutoSize = true;
            lblGuncellenenID.Location = new Point(23, 582);
            lblGuncellenenID.Name = "lblGuncellenenID";
            lblGuncellenenID.Size = new Size(0, 20);
            lblGuncellenenID.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1348, 216);
            label9.Name = "label9";
            label9.Size = new Size(218, 20);
            label9.TabIndex = 8;
            label9.Text = "Aramak İstediğiniz Ürünün ID'si:";
            // 
            // txtUrunID
            // 
            txtUrunID.Location = new Point(164, 41);
            txtUrunID.Name = "txtUrunID";
            txtUrunID.Size = new Size(256, 27);
            txtUrunID.TabIndex = 9;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(164, 101);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(256, 27);
            txtUrunAdi.TabIndex = 10;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(164, 165);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(137, 27);
            txtUrunFiyati.TabIndex = 11;
            // 
            // txtUrunAciklamasi
            // 
            txtUrunAciklamasi.Location = new Point(164, 225);
            txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            txtUrunAciklamasi.Size = new Size(256, 27);
            txtUrunAciklamasi.TabIndex = 12;
            // 
            // txtGuncellenecekUrunID
            // 
            txtGuncellenecekUrunID.Location = new Point(1597, 329);
            txtGuncellenecekUrunID.Name = "txtGuncellenecekUrunID";
            txtGuncellenecekUrunID.Size = new Size(156, 27);
            txtGuncellenecekUrunID.TabIndex = 14;
            // 
            // txtSilinecekUrunID
            // 
            txtSilinecekUrunID.Location = new Point(1572, 86);
            txtSilinecekUrunID.Name = "txtSilinecekUrunID";
            txtSilinecekUrunID.Size = new Size(181, 27);
            txtSilinecekUrunID.TabIndex = 15;
            // 
            // pbUrunResmi
            // 
            pbUrunResmi.Location = new Point(164, 259);
            pbUrunResmi.Name = "pbUrunResmi";
            pbUrunResmi.Size = new Size(256, 218);
            pbUrunResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUrunResmi.TabIndex = 16;
            pbUrunResmi.TabStop = false;
            // 
            // cmbParaBirimi
            // 
            cmbParaBirimi.FormattingEnabled = true;
            cmbParaBirimi.Location = new Point(307, 164);
            cmbParaBirimi.Name = "cmbParaBirimi";
            cmbParaBirimi.Size = new Size(113, 28);
            cmbParaBirimi.TabIndex = 17;
            // 
            // cmbUrunKategori
            // 
            cmbUrunKategori.FormattingEnabled = true;
            cmbUrunKategori.Location = new Point(164, 511);
            cmbUrunKategori.Name = "cmbUrunKategori";
            cmbUrunKategori.Size = new Size(256, 28);
            cmbUrunKategori.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1339, 332);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 19;
            label1.Text = "Güncellemek İstediğiniz Ürünün ID'si:";
            // 
            // txtAranacakUrunID
            // 
            txtAranacakUrunID.Location = new Point(1572, 209);
            txtAranacakUrunID.Name = "txtAranacakUrunID";
            txtAranacakUrunID.Size = new Size(181, 27);
            txtAranacakUrunID.TabIndex = 20;
            // 
            // dgvUrunBilgileri
            // 
            dgvUrunBilgileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunBilgileri.Location = new Point(451, 70);
            dgvUrunBilgileri.Name = "dgvUrunBilgileri";
            dgvUrunBilgileri.RowHeadersWidth = 51;
            dgvUrunBilgileri.Size = new Size(882, 545);
            dgvUrunBilgileri.TabIndex = 21;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(1670, 373);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(83, 55);
            btnGuncelle.TabIndex = 22;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(281, 545);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(139, 64);
            btnUrunEkle.TabIndex = 23;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(23, 343);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(121, 64);
            btnResimEkle.TabIndex = 24;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(1670, 136);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(83, 41);
            btnUrunSil.TabIndex = 25;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunAra
            // 
            btnUrunAra.Location = new Point(1670, 259);
            btnUrunAra.Name = "btnUrunAra";
            btnUrunAra.Size = new Size(83, 51);
            btnUrunAra.TabIndex = 26;
            btnUrunAra.Text = "Ürün Ara";
            btnUrunAra.UseVisualStyleBackColor = true;
            btnUrunAra.Click += btnUrunAra_Click;
            // 
            // btnDosyayaYaz
            // 
            btnDosyayaYaz.Location = new Point(1421, 551);
            btnDosyayaYaz.Name = "btnDosyayaYaz";
            btnDosyayaYaz.Size = new Size(121, 64);
            btnDosyayaYaz.TabIndex = 27;
            btnDosyayaYaz.Text = "Dosyaya Yaz";
            btnDosyayaYaz.UseVisualStyleBackColor = true;
            btnDosyayaYaz.Click += btnDosyayaYaz_Click;
            // 
            // btnDosyadanOku
            // 
            btnDosyadanOku.Location = new Point(1572, 551);
            btnDosyadanOku.Name = "btnDosyadanOku";
            btnDosyadanOku.Size = new Size(121, 64);
            btnDosyadanOku.TabIndex = 28;
            btnDosyadanOku.Text = "Dosyadan Oku";
            btnDosyadanOku.UseVisualStyleBackColor = true;
            btnDosyadanOku.Click += btnDosyadanOku_Click;
            // 
            // btnTabloyuTemizle
            // 
            btnTabloyuTemizle.Location = new Point(1572, 470);
            btnTabloyuTemizle.Name = "btnTabloyuTemizle";
            btnTabloyuTemizle.Size = new Size(121, 64);
            btnTabloyuTemizle.TabIndex = 29;
            btnTabloyuTemizle.Text = "Tabloyu Temizle";
            btnTabloyuTemizle.UseVisualStyleBackColor = true;
            btnTabloyuTemizle.Click += btnTabloyuTemizle_Click;
            // 
            // btnUrunleriListele
            // 
            btnUrunleriListele.Location = new Point(1421, 470);
            btnUrunleriListele.Name = "btnUrunleriListele";
            btnUrunleriListele.Size = new Size(121, 64);
            btnUrunleriListele.TabIndex = 30;
            btnUrunleriListele.Text = "Ürünleri Listele";
            btnUrunleriListele.UseVisualStyleBackColor = true;
            btnUrunleriListele.Click += btnUrunleriListele_Click;
            // 
            // ofdResimSec
            // 
            ofdResimSec.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 1069);
            Controls.Add(btnUrunleriListele);
            Controls.Add(btnTabloyuTemizle);
            Controls.Add(btnDosyadanOku);
            Controls.Add(btnDosyayaYaz);
            Controls.Add(btnUrunAra);
            Controls.Add(btnUrunSil);
            Controls.Add(btnResimEkle);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(dgvUrunBilgileri);
            Controls.Add(txtAranacakUrunID);
            Controls.Add(label1);
            Controls.Add(cmbUrunKategori);
            Controls.Add(cmbParaBirimi);
            Controls.Add(pbUrunResmi);
            Controls.Add(txtSilinecekUrunID);
            Controls.Add(txtGuncellenecekUrunID);
            Controls.Add(txtUrunAciklamasi);
            Controls.Add(txtUrunFiyati);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtUrunID);
            Controls.Add(label9);
            Controls.Add(lblGuncellenenID);
            Controls.Add(label7);
            Controls.Add(lblUrunKategori);
            Controls.Add(label5);
            Controls.Add(lblUrunAciklamasi);
            Controls.Add(lblUrunFiyati);
            Controls.Add(lblUrunAdi);
            Controls.Add(lblUrunID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbUrunResmi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunBilgileri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunID;
        private Label lblUrunAdi;
        private Label lblUrunFiyati;
        private Label lblUrunAciklamasi;
        private Label label5;
        private Label lblUrunKategori;
        private Label label7;
        private Label lblGuncellenenID;
        private Label label9;
        private TextBox txtUrunID;
        private TextBox txtUrunAdi;
        private TextBox txtUrunFiyati;
        private TextBox txtUrunAciklamasi;
        private TextBox txtGuncellenecekUrunID;
        private TextBox txtSilinecekUrunID;
        private PictureBox pbUrunResmi;
        private ComboBox cmbParaBirimi;
        private ComboBox cmbUrunKategori;
        private Label label1;
        private TextBox txtAranacakUrunID;
        private DataGridView dgvUrunBilgileri;
        private Button btnGuncelle;
        private Button btnUrunEkle;
        private Button btnResimEkle;
        private Button btnUrunSil;
        private Button btnUrunAra;
        private Button btnDosyayaYaz;
        private Button btnDosyadanOku;
        private Button btnTabloyuTemizle;
        private Button btnUrunleriListele;
        private OpenFileDialog ofdResimSec;
    }
}
