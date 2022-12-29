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
    public partial class frmSatisYukleme : Form
    {
        public frmSatisYukleme()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void frmSatisYukleme_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==5)
            {             

                this.Close();               
            }
            
        }

        
    }
}
