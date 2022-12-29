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


namespace REAOS
{
    public partial class frmMusteriAyarlar : Form
    {
        public frmMusteriAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi con = new sqlbaglantisi();
        DataSet1TableAdapters.tbl_MusterilerTableAdapter ds = new DataSet1TableAdapters.tbl_MusterilerTableAdapter();
        private void frmMusteriAyarlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMusteriAnaSayfa fr = new frmMusteriAnaSayfa();
            fr.Show();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmMusteriAnaSayfa fr = new frmMusteriAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.MevcutMusteriKaydiGuncelle(txtAd.Text, txtSoyad.Text, cmbSehir.Text, txtSifre.Text, txtPlaka.Text, txtMail.Text, txtDogum.Text, mskTC.Text);

            MessageBox.Show("Müşteri Kaydıniz Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMusteriAyarlar_Load(object sender, EventArgs e)
        {
            //masked texte tc çekme
            SqlCommand cmd = new SqlCommand("select TC from tbl_girisyapanhesap", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                mskTC.Text = dr[0].ToString();
            }
            con.connection().Close();
            /*//diğer veriler
            SqlCommand cmd2 = new SqlCommand("select * from tbl_musteriler where MusteriTc=@p1", con.connection());
            cmd2.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txtAd.Text = dr2[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbSehir.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
                txtPlaka.Text = dr[6].ToString();
                txtMail.Text = dr[7].ToString();
                txtDogum.Text = dr[8].ToString();


            }
            
            con.connection().Close();*/
        }
    }
}
