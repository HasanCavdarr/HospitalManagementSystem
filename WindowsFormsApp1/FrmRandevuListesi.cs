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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label6.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString() + " | " + dataGridView1.Rows[secilen].Cells[2].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; //id değerini seçer
            SqlCommand komut = new SqlCommand("delete From Tbl_Randevular where Randevuid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Randevu Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
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
            bgl.baglanti();
            MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
    }

