using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Windows Forms uygulamaları için kütüphane
using System.Data.SqlClient;  // SQL Server ile bağlantı ve işlemler için kütüphane.

namespace WindowsFormsApp1
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();  // SQL bağlantısı için sınıf
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde branşları görüntülemek
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);  // Veriler DataTable'a aktarmak için
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",TxtBrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme Yapıldı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // DataGridView'de herhangi bir hücreye tıklandığında
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçilen hücrenin satır indeksini alıyor.
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransid=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBrans.Text);
            komut.Parameters.AddWithValue("@p2", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
