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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string eposta; // Doktorun e-posta adresini için değişken
        private void FrmDoktorDetay_Load(object sender, EventArgs e)

        { 
            LblEpostadoktor.Text = eposta;
            // Doktor Ad Soyad:
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorEposta=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblEpostadoktor.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            //randevuları getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor = '" + LblAdSoyad.Text + "' " +
            //manüpülasyon ile varchar -> int yapma ve order by ile sıralama
            "ORDER BY " +
            "CAST(SUBSTRING(RandevuTarih, 7, 4) AS INT), " + // Randevu tarihinin yıl kısmını alır ve INT türüne dönüştürür.
            "CAST(SUBSTRING(RandevuTarih, 4, 2) AS INT), " + 
            "CAST(SUBSTRING(RandevuTarih, 1, 2) AS INT), " + 
            "CAST(REPLACE(RandevuSaat, '.', ':') AS TIME)",
            bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public static string Doktorposta,DoktorIsimSoyisim,DoktorBrans,Doktorid; //bilgileriçin değişkenler

        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuTarih=@r1,RandevuSaat=@r2,RandevuBrans=@r3,RandevuDoktor=@r4,RandevuDurum=@r5,HastaEposta=@r6 where Randevuid=@r7", bgl.baglanti());
            komut.Parameters.AddWithValue("@r7", dataGridView1.Rows[secilen].Cells[0].Value.ToString()); 
            komut.Parameters.AddWithValue("@r1", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@r2", dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            komut.Parameters.AddWithValue("@r3", dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            komut.Parameters.AddWithValue("@r4", dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            komut.Parameters.AddWithValue("@r5", dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            komut.Parameters.AddWithValue("@r6", dataGridView1.Rows[secilen].Cells[6].Value.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçilenin satır indeksi
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Doktorposta = LblEpostadoktor.Text;
            DoktorIsimSoyisim = LblAdSoyad.Text;
            SqlCommand komut = new SqlCommand("Select DoktorBrans From Tbl_Doktorlar where DoktorEposta=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Doktorposta);
            SqlDataReader reader = komut.ExecuteReader(); // Çalıştırılır ve sonuçlar okunur
            reader.Read(); // Eğer sonuç dönerse
            {
                DoktorBrans = reader["DoktorBrans"].ToString(); // Sütun adını kullanarak değeri alıyoruz
            }
            reader.Close();

            SqlCommand komut2 = new SqlCommand("Select Doktorid From Tbl_Doktorlar where DoktorEposta=@z1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@z1", Doktorposta);
            SqlDataReader reader2 = komut2.ExecuteReader();
            if (reader2.Read()); // Eğer sonuç dönerse
            {
                Doktorid = reader2["Doktorid"].ToString(); // Sütun adını kullanarak değeri alıyoruz
            }
            reader2.Close();


            FrmDoktorBilgiDüzenle yeniForm = new FrmDoktorBilgiDüzenle();
            yeniForm.Show();
        }
    }
}
