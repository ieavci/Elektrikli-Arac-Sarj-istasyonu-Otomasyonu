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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_PersonelTableAdapter ds = new DataSet1TableAdapters.tbl_PersonelTableAdapter();
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void frmPersonel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
        }
        public void Listele()
        {
            dataGridView1.DataSource = ds.PersonelListele();
        }
        public void Temizle()
        {
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            mskTC.Clear();
            txtGorev.Clear();
            txtMaas.Clear();
            txtMail.Clear();
            cmbSehir.Text = "";
            txtSifre.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.PersonelEkle(txtAd.Text,txtSoyad.Text, mskTC.Text, txtGorev.Text, Convert.ToInt16(txtMaas.Text), txtMail.Text, cmbSehir.Text,txtSifre.Text);
            Listele();
            Temizle();
            MessageBox.Show("Yeni Personel Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.PersonelListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Mevcut Personel Kaydı Silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                ds.PersonelSil(Convert.ToByte(txtID.Text));
            }

            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.PersonelGuncelle(txtAd.Text, txtSoyad.Text, mskTC.Text, txtGorev.Text, Convert.ToInt16(txtMaas.Text), txtMail.Text, cmbSehir.Text,txtSifre.Text,Convert.ToByte(txtID.Text));
            Listele();
            Temizle();
            MessageBox.Show("Personel Kaydı Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.PersonelAra((mskTcAra.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskTC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();                 
            txtGorev.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }
    }
}
