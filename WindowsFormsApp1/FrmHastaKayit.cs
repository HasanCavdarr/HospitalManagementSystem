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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaEposta,HastaSifre) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdKayıt.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadKayıt.Text);
            komut.Parameters.AddWithValue("@p3", TxtEpostaKayıt.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifreKayıt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Oluşturulmuştur, Şifreniz: " + TxtSifreKayıt.Text, "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
