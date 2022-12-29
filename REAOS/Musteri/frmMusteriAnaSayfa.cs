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
    public partial class frmMusteriAnaSayfa : Form
    {
        public frmMusteriAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmSatis fr = new frmSatis();
            fr.Show();
            this.Hide();
        }

        private void frmMusteriAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak istediğine eminmisin?","Uygulama Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            frmHesapla fr = new frmHesapla();
            fr.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmMusteriAyarlar fr = new frmMusteriAyarlar();
            fr.Show();
            this.Hide();
        }
    }
}
