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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            string DoktorBrans = FrmDoktorDetay.DoktorBrans;
            string doktorposta = FrmDoktorDetay.Doktorposta;
            string DoktorIsimSoyisim = FrmDoktorDetay.DoktorIsimSoyisim;
            string Doktorid = FrmDoktorDetay.Doktorid;
            textBox1.Text = Doktorid;
            TxtAdSoyad.Text = DoktorIsimSoyisim.ToString();
            TxtEposta.Text = doktorposta.ToString();
            CmbBrans.Text = DoktorBrans.ToString();
            SqlCommand komut = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                // ComboBox'a her bir branşı ekle
                CmbBrans.Items.Add(reader["BransAd"].ToString());
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorBrans=@d1, DoktorEposta=@d2, DoktorSifre=@d3 WHERE Doktorid=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",CmbBrans.Text);
            komut.Parameters.AddWithValue("d2", TxtEposta.Text);
            komut.Parameters.AddWithValue("d3", TxtSifre.Text);
            komut.Parameters.AddWithValue("d4", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
