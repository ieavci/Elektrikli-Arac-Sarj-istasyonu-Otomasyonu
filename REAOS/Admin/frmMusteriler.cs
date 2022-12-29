using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAOS
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.tbl_MusterilerTableAdapter ds = new DataSet1TableAdapters.tbl_MusterilerTableAdapter();

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void frmMusteriler_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.MusteriListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.MusteriEkle(txtAd.Text,txtSoyad.Text,cmbSehir.Text,mskTC.Text,txtSifre.Text,txtPlaka.Text,txtMail.Text,mskDogum.Text);
            Listele();
            Temizle();
            MessageBox.Show("Yeni Müşteri Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Mevcut Müşteri Kaydı Silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                ds.MusteriSil(Convert.ToInt16(txtID.Text));
            }
          
            Listele();
            Temizle();
           
        }
               
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.MusteriGuncelle(txtAd.Text, txtSoyad.Text, cmbSehir.Text, mskTC.Text, txtSifre.Text, txtPlaka.Text, txtMail.Text, mskDogum.Text,Convert.ToInt16(txtID.Text));
            Listele();
            Temizle();
            MessageBox.Show("Müşteri Kaydı Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPlaka.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            mskDogum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        public void Listele()
        {
            dataGridView1.DataSource = ds.MusteriListesi();
        }
        public void Temizle()
        {
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cmbSehir.Text = "";
            mskTC.Clear();
            txtSifre.Clear();
            txtPlaka.Clear();
            txtMail.Clear();
            mskDogum.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.MusteriAra(mskTC.Text);
        }
    }
}
