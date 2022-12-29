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
    public partial class frmYakıt : Form
    {
        public frmYakıt()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_YakitTableAdapter ds = new DataSet1TableAdapters.tbl_YakitTableAdapter();
        private void frmYakıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
            fr.Show();
            this.Hide();
        }

        

        
        private void cmbGuc_Click_1(object sender, EventArgs e)
        {
            if (cmbSoket.Text == "AC Tip 2")
            {
               
                cmbGuc.Items.Clear();
                cmbGuc.Items.Add("7.4 kW’a kadar");
                cmbGuc.Items.Add("7.4 kW-11 kW arası");
                cmbGuc.Items.Add("11 kW ve üzeri");
               

            }
            else if(cmbSoket.Text == "DC" || cmbSoket.Text == "CCS"|| cmbSoket.Text == "CHAdeMO")
            {
        
                cmbGuc.Items.Clear();
                cmbGuc.Items.Add("50 kW’a kadar");
                cmbGuc.Items.Add("50 kW-90 kW arası");
                cmbGuc.Items.Add("90 kW ve üzeri");
               
            }
            
        }
        private void fiyatYazdir()
        {
            if (cmbGuc.Text == "7.4 kW’a kadar")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "0,55";
            }
            else if (cmbGuc.Text == "7.4 kW-11 kW arası")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "0,85";
            }
            else if (cmbGuc.Text == "11 kW ve üzeri")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "1,15";
            }
            else if (cmbGuc.Text == "50 kW’a kadar")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "3,9";
            }
            else if (cmbGuc.Text == "50 kW-90 kW arası")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "5,3";
            }
            else if (cmbGuc.Text == "90 kW ve üzeri")
            {
                txtFiyat.Clear();
                txtFiyat.Text = "7,9";
            }
            

        }

        private void cmbGuc_TextChanged(object sender, EventArgs e)
        {
            fiyatYazdir();
        }

        private void cmbSoket_TextChanged(object sender, EventArgs e)
        {
            txtFiyat.Clear();
            cmbGuc.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.YakitEkle(cmbSoket.Text,Convert.ToDecimal(txtFiyat.Text), cmbGuc.Text);
            Listele();
            Temizle();
            MessageBox.Show("Yeni Yakıt Türü Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Mevcut Yakıt Kaydı Silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                ds.YakitSil(Convert.ToByte(txtID.Text));
            }

            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            ds.YakitGuncelle(cmbSoket.Text, Convert.ToDecimal(txtFiyat.Text), cmbGuc.Text, Convert.ToByte(txtID.Text));
            Listele();
            Temizle();
            MessageBox.Show("Müşteri Kaydı Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmYakıt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.YakitListele();
        }
        public void Listele()
        {
            dataGridView1.DataSource = ds.YakitListele();
        }
        public void Temizle()
        {
            txtID.Clear();
            cmbSoket.Text = "";
            cmbGuc.Text = "";
            txtFiyat.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.SoketAra(txtSoketAra.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           cmbSoket.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           cmbGuc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
