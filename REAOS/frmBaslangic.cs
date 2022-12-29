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
    public partial class frmBaslangic : Form
    {
        
        public frmBaslangic()
        {
            InitializeComponent();
            
        }

        sqlbaglantisi con = new sqlbaglantisi();



        private void txtID_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Focus(); txtID.Clear();
        }

        private void txtPas_Click(object sender, EventArgs e)
        {
            txtPas.Focus(); txtPas.Clear();

        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            lblKontrol.Text ="per";
            
            lblBilgi.Visible = false;
            this.AcceptButton = btnGirisYap;
            btnGirisYap.Visible = true;
            lblHenuz.Visible = false;
            linkLblKayitOl.Visible = false;
            txtID.Visible = true;
            txtPas.Visible = true;
            txtID.Focus();
            txtID.Text = "Personel TC...";
            txtID.SelectAll();
            txtPas.UseSystemPasswordChar = false;
            //textBox2.Focus();
            txtPas.Text = "Şifreniz...";
            
            txtPas.SelectAll();
        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            lblKontrol.Text = "mus";
            
            lblBilgi.Visible = false;
            btnGirisYap.Visible = false;
            btnGirisYap.Visible = true;
            lblHenuz.Visible = true;
            linkLblKayitOl.Visible = true;
            txtID.Visible = true;
            txtPas.Visible = true;
            txtID.Focus();
            txtID.Text = "Müşteri TC...";
            txtID.SelectAll();
            txtPas.UseSystemPasswordChar = false;
            //textBox2.Focus();
            txtPas.Text = "Şifreniz...";
            
            txtPas.SelectAll();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rigor Elektrkli Araç Otomasyonları Sistemi (REAOS) yeni nesil teknolojileri hayata geçirmek amacıyla yaratılmış Rigor Dev markasıdır.", "Biz Kimiz?",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }       
       

        private void linkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Musteri.frmMusteriKayit fr = new Musteri.frmMusteriKayit();
            
            fr.Show();
            this.Hide();
        }

        private void frmBaslangic_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            if (lblKontrol.Text=="per")
            {
                
                SqlCommand cmd = new SqlCommand("select * from tbl_personel where personeltc=@p1 and personelsifre=@p2", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtID.Text);
                cmd.Parameters.AddWithValue("@p2", txtPas.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frmAdminAnaSayfa fr = new frmAdminAnaSayfa();
                    
                    fr.Show();
                    this.Hide();
                    con.connection().Close();
                }
                else
                {
                    MessageBox.Show("Personel TC veya şifre yanlış!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.connection().Close();
                }
            }
            else if (lblKontrol.Text == "mus")
            {
                                
                SqlCommand cmd = new SqlCommand("select * from tbl_musteriler where musteritc=@p1 and musterisifre=@p2", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtID.Text);
                cmd.Parameters.AddWithValue("@p2", txtPas.Text);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    frmMusteriAnaSayfa fr = new frmMusteriAnaSayfa();
                    frmSatis frsatis = new frmSatis();
                    frsatis.mskTC.Text = txtID.Text;
                    fr.Show();
                    this.Hide();
                    con.connection().Close();
                }
                else
                {
                    MessageBox.Show("Müşteri TC veya şifre yanlış!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.connection().Close();
                }
            }
            SqlCommand cmd1 = new SqlCommand("delete from tbl_girisyapanhesap", con.connection());
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("insert into tbl_girisyapanhesap (TC)  values (@p1)", con.connection());
            cmd2.Parameters.AddWithValue("@p1", txtID.Text);
            cmd2.ExecuteNonQuery();
            con.connection().Close();
           

        }

        private void frmBaslangic_Load(object sender, EventArgs e)
        {
            

        }
    }
}
