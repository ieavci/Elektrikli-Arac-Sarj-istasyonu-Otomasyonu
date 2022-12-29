using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAOS.Musteri
{
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_MusterilerTableAdapter ds = new DataSet1TableAdapters.tbl_MusterilerTableAdapter();
        private void frmMusteriKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBaslangic fr = new frmBaslangic();
            fr.Show();
            
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmBaslangic fr = new frmBaslangic();
            fr.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text== txtSifreTekrar.Text)
            {
                ds.MusteriEkle(txtAd.Text, txtSoyad.Text, cmbSehir.Text, mskTC.Text, txtSifre.Text, txtPlaka.Text, txtMail.Text, mskDogum.Text);
            }
            else
            {
                MessageBox.Show("Lütfen şifrenizi doğru girdiğinize emin olun.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            txtSifreTekrar.UseSystemPasswordChar = false;
            btnSifreGoster.Enabled = false;
            btnSifreGoster.Visible = false;
            btnSifreGizle.Enabled = true;
            btnSifreGizle.Visible = true;

        }

        private void btnSifreGizle_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifreTekrar.UseSystemPasswordChar = true;
            btnSifreGoster.Enabled = true;
            btnSifreGoster.Visible = true;
            btnSifreGizle.Enabled = false;
            btnSifreGizle.Visible = false;
        }

        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
