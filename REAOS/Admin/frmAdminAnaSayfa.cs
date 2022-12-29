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
    public partial class frmAdminAnaSayfa : Form
    {
        public frmAdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAdminAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak istediğine eminmisin?", "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel fr = new frmPersonel();
            fr.Show();
            this.Hide();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriler fr = new frmMusteriler();
            fr.Show();
            this.Hide();
        }

        private void btnYakit_Click(object sender, EventArgs e)
        {
            frmYakıt fr = new frmYakıt();
            fr.Show();
            this.Hide();
        }

        private void btn_SatisGecmisi_Click(object sender, EventArgs e)
        {
            Admin.frmSatisGoruntule fr = new Admin.frmSatisGoruntule();
            fr.Show();
            this.Hide();
        }
    }
}
