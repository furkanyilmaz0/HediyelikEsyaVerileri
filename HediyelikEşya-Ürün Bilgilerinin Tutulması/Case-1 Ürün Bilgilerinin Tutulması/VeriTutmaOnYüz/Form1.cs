using ÜrünLib.Class;
using ÜrünLib.Enum;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;




namespace VeriTutmaOnYüz
{

    public partial class Form1 : Form
    {
        UrunServis urunServis = new UrunServis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'ları doldur ve yalnızca listeden seçim yapılmasını sağla

            cmbUrunKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunKategori.DataSource = Enum.GetValues(typeof(UrunKategori));
            cmbParaBirimi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParaBirimi.DataSource = Enum.GetValues(typeof(ParaBirimi));
            dgvUrunBilgileri.DataSource = urunServis.Listele();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            // Giriş kontrolleri

            string urunAdi = txtUrunAdi.Text;
            string urunIDText = txtUrunID.Text;
            string urunFiyatText = txtUrunFiyati.Text;
            string urunAciklamasi = txtUrunAciklamasi.Text;
            var UrunKategori = (UrunKategori)cmbUrunKategori.SelectedItem;
            var urunResmi = pbUrunResmi.Tag?.ToString();
            var paraBirimi = (ParaBirimi)cmbParaBirimi.SelectedItem;

            if (string.IsNullOrEmpty(urunIDText) || !int.TryParse(urunIDText, out int urunID))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Adı giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(urunFiyatText) || !decimal.TryParse(urunFiyatText, out decimal urunFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir Fiyat giriniz.");
                return;
            }

            if (cmbParaBirimi.SelectedIndex == 0) //Para_Birimi seçildiğinde uyarı vermesi.
            {
                MessageBox.Show("Lütfen bir Para Birimi seçiniz.");
                return;
            }

            if (string.IsNullOrEmpty(urunAciklamasi))
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Açıklaması giriniz.");
                return;
            }

            if (pbUrunResmi.Image == null)
            {
                MessageBox.Show("Lütfen bir resim ekleyiniz.");
                return;
            }

            if (cmbUrunKategori.SelectedIndex == 0) //Kategori seçildiğinde uyarı vermesi.
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Kategorisi seçiniz.");
                return;
            }

            //Yeni ürün oluştur ardından listeye ekle.

            Urun yeniUrun = new Urun()
            {
                UrunAdi = urunAdi,
                UrunID = urunID,
                UrunFiyati = urunFiyat,
                ParaBirimi = paraBirimi,
                UrunAciklamasi = urunAciklamasi,
                UrunKategori = UrunKategori,
                UrunResmi = urunResmi

            };

            urunServis.Ekle(yeniUrun);

            //textboxları, comboboxların, pictureboxun sıfırlanması
            txtUrunID.Clear();
            txtUrunFiyati.Clear();
            txtUrunAciklamasi.Clear();
            txtUrunAdi.Clear();
            cmbParaBirimi.SelectedIndex = 0;
            cmbUrunKategori.SelectedIndex = 0;
            pbUrunResmi.Image = null;
            pbUrunResmi.Tag = null;

        }


        //Kullanıcıdan bir resim dosyası seçmesini ister.
        //Eğer dosya seçilmişse seçilen dosyanın dosya yolunu PictureBox kontrolüne yükler.
        //Tag özelliğine dosya yolunu atar.

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            if (ofdResimSec.ShowDialog() == DialogResult.OK)
            {
                pbUrunResmi.ImageLocation = ofdResimSec.FileName;
                pbUrunResmi.Tag = ofdResimSec.FileName;
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            //Giriş Kontrolleri

            string SilinecekUrunIDText = txtSilinecekUrunID.Text;
            if (string.IsNullOrWhiteSpace(SilinecekUrunIDText) || !int.TryParse(SilinecekUrunIDText, out int urunID))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz...");
                return;
            }

            var urun = urunServis.Ara(urunID);

            if (urun == null) //Yazmış olunan ID'ye sahip bir ürününü olup olmadığının kontrolü...
            {
                MessageBox.Show("Bu ID'ye sahip bir ürün bulunamadı.");
                return;
            }

            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Silme işlemi için  onay sorusu içeren bir MessageBox gösterilir.Evet Hayır seçenekleri sunulur.
            //Eğer Evet seçenği silinmişse Ürün silinir.
            if (result == DialogResult.Yes)
            {
                urunServis.Sil(urunID);
                dgvUrunBilgileri.DataSource = null;
                dgvUrunBilgileri.DataSource = urunServis.Listele();
                txtSilinecekUrunID.Clear();

            }
        }

        private void btnUrunleriListele_Click(object sender, EventArgs e)
        {
            dgvUrunBilgileri.DataSource = null;
            //dataGridView kaynağını ürünler listemizden alır.
            dgvUrunBilgileri.DataSource = urunServis.Listele();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            string urunIDText = txtAranacakUrunID.Text;

            //Kontroller ve Yazılan ID'ye sahip bir ürünün var olup olmadığı

            if (string.IsNullOrWhiteSpace(urunIDText) || !int.TryParse(urunIDText, out int urunID))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID giriniz.");
                return;
            }

            var arananUrun = urunServis.Ara(int.Parse(txtAranacakUrunID.Text));
            if (arananUrun == null)
            {
                MessageBox.Show("Bu ID'ye sahip bir ürün bulunamadı.");
                return;
            }

            //DataGridView'in veri kaynağı , yalnızca aranan ürün bilgilerini içeren  bir liste olarak ayarlanır.
            dgvUrunBilgileri.DataSource = new List<Urun> { arananUrun };
            txtAranacakUrunID.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Giriş Kontrolleri

            string guncellenecekUrunIDText = txtGuncellenecekUrunID.Text;


            if (string.IsNullOrWhiteSpace(guncellenecekUrunIDText) || !int.TryParse(guncellenecekUrunIDText, out int guncellenecekUrunID))
            {
                MessageBox.Show("Lütfen Güncellenecek Ürün içi geçerli bir ID giriniz...");
                return;

            }

            Urun mevcutUrun = urunServis.Ara(int.Parse(guncellenecekUrunIDText));
            if (mevcutUrun == null)
            {
                MessageBox.Show("Bu ID ile ürün bulunamadı.");
                return;
            }

            string urunAdi = txtUrunAdi.Text;
            string urunIDText = txtUrunID.Text;
            string urunFiyatText = txtUrunFiyati.Text;
            var paraBirimi = (ParaBirimi)cmbParaBirimi.SelectedItem;
            string urunAciklamasi = txtUrunAciklamasi.Text;
            var urunKategori = (UrunKategori)cmbUrunKategori.SelectedItem;
            string urunResmi = pbUrunResmi.Tag?.ToString();



            if (string.IsNullOrEmpty(urunIDText) || !int.TryParse(urunIDText, out int urunID))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz...");
                return;
            }

            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Adı giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(urunFiyatText) || !decimal.TryParse(urunFiyatText, out decimal urunFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir Fiyat giriniz...");
                return;
            }

            if (string.IsNullOrEmpty(urunAciklamasi))
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Açıklaması giriniz.");
                return;
            }

            if (cmbUrunKategori.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen geçerli bir Ürün Kategorisi seçiniz.");
                return;
            }

            if (cmbParaBirimi.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir Para Birimi seçiniz.");
                return;
            }

            //Ürün verilerinin güncellenmesi

            urunServis.Guncelle(guncellenecekUrunID, urunID, urunAdi, urunFiyat, paraBirimi, urunAciklamasi, urunResmi, urunKategori);

            //textboxları, comboboxların, pictureboxun sıfırlanması 
            txtGuncellenecekUrunID.Clear();
            txtUrunID.Clear();
            txtUrunFiyati.Clear();
            txtUrunAciklamasi.Clear();
            txtUrunAdi.Clear();
            cmbParaBirimi.SelectedIndex = 0;
            cmbUrunKategori.SelectedIndex = 0;
            pbUrunResmi.Image = null;
            pbUrunResmi.Tag = null;



            dgvUrunBilgileri.DataSource = null;
            dgvUrunBilgileri.DataSource = urunServis.Listele();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            //Verileri JSON dosyasına yaz.
            urunServis.DosyayaYaz(@"urunler.json");
        }



        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {
            //JSON dosyasından verileri oku ve tabloyu güncelle.
            urunServis.DosyadanOku(@"urunler.json");
            dgvUrunBilgileri.DataSource = null;
            dgvUrunBilgileri.DataSource = urunServis.Listele();
        }

        private void btnTabloyuTemizle_Click(object sender, EventArgs e)
        {
            //Tabloyu temizle
            dgvUrunBilgileri.DataSource = null;
        }

    }
}

