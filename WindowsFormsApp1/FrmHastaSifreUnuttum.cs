using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmHastaSifreUnuttum : Form
    {
        public FrmHastaSifreUnuttum()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnSifreDegistir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaAd=@p1 and HastaSoyad=@p2 and HastaEposta=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdKayıt.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadKayıt.Text);
            komut.Parameters.AddWithValue("@p3", TxtEpostaKayıt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                // Kullanıcı doğrulandı, şifre değiştir
                string mevcutSifre = dr["HastaSifre"].ToString();
                dr.Close();
                string yeniSifre = TxtSifreDegistir.Text;
                if (yeniSifre == mevcutSifre)
                {
                    MessageBox.Show("Yeni şifre eski şifre ile aynı olamaz. Lütfen farklı bir şifre giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi sonlandır
                }
                SqlCommand sifreDegistirKomut = new SqlCommand("Update Tbl_Hastalar Set HastaSifre=@p4 Where HastaEposta=@p3", bgl.baglanti());
                sifreDegistirKomut.Parameters.AddWithValue("@p4", yeniSifre);
                sifreDegistirKomut.Parameters.AddWithValue("@p3", TxtEpostaKayıt.Text);
                sifreDegistirKomut.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Kullanıcı doğrulanamadı
            {
                MessageBox.Show("Ad, soyad veya e-posta bilgileriniz hatalı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();

        }
        

        public string Eposta;
        public string Sifre;


        private void FrmHastaSifreUnuttum_Load(object sender, EventArgs e)
        {
            TxtEpostaKayıt.Text = Eposta;
            TxtSifreDegistir.Text = Sifre;     
        }
    }
}