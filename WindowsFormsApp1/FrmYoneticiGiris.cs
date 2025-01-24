using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where YoneticiEposta=@p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtEposta.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmYoneticiDetay frs = new FrmYoneticiDetay();
                frs.ePosta = TxtEposta.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı E-Posta adresi veya şifre!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FrmYoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
