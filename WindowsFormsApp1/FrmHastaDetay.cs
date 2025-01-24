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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string ePosta;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblEposta.Text = ePosta;
            
            //ad soyad çekme

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaEposta=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblEposta.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaEposta=@ePosta", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@ePosta", ePosta);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekmek
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void Cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            //doktor çekmek branşa göre
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",Cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + Cmbbrans.Text + "'" + " and RandevuDoktor='" + CmbDoktor.Text + "' and RandevuDurum=0" , bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Randevular Set RandevuDurum=1,HastaEposta=@p1 where Randevuid=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",LblEposta.Text);
            cmd.Parameters.AddWithValue("@p2",Txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnRandevuIptal_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Randevular Set RandevuDurum = 0 WHERE Randevuid = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }


    }
}
