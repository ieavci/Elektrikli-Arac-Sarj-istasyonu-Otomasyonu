using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAOS.Admin
{
    public partial class frmSatisGoruntule : Form
    {
        public frmSatisGoruntule()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_SatislarTableAdapter ds = new DataSet1TableAdapters.tbl_SatislarTableAdapter();
        sqlbaglantisi con = new sqlbaglantisi();

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void frmSatisGoruntule_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
        }

        private void frmSatisGoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.SatisListesi();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Cast(Fiyat As decimal(15,4))) as toplam FROM tbl_Satislar", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTopFiyat.Text = dr[0].ToString();
            }
            
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(Fiyat) FROM tbl_satislar", con.connection());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtTopMus.Text = dr1[0].ToString();
            }
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(DISTINCT MusteriTc) FROM tbl_Satislar;", con.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txtFarMus.Text = dr2[0].ToString();
            }
            con.connection().Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.SatisAra(mskTcAra.Text);
        }
    }
}
