using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAOS
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        sqlbaglantisi con = new sqlbaglantisi();
        frmBaslangic frm1 = new frmBaslangic();


        private void frmSatis_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmSatis_Load(object sender, EventArgs e)
        {
           
            //masked texte tc çekme
            SqlCommand cmd = new SqlCommand("select * from tbl_girisyapanhesap", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                mskTC.Text = dr[0].ToString();
            }
            con.connection().Close();
            SqlCommand cmd1 = new SqlCommand("select * from tbl_satislar where MusteriTC=@MusteriTC ", con.connection());
            cmd1.Parameters.AddWithValue("MusteriTC",mskTC.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                dataGridView1.DataSource = dr1;
            }



            //datagride veri çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_satislar where MusteriTc=" + mskTC.Text, con.connection());

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //plaka çekme
            SqlCommand cmd2 = new SqlCommand("select musteriplaka from tbl_musteriler where musteritc=@musteritc", con.connection());
            cmd2.Parameters.AddWithValue("@musteritc",mskTC.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txtPlaka.Text = dr2[0].ToString();
            }

            //Tarih bilgisini yazdırma
            DateTime bugun = DateTime.Today;
            txtTarih.Text =bugun.ToShortDateString();


            con.connection().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int sayac;
        private void btnSatis_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_satislar (AracPlaka,SoketTuru,SatilanMiktar,Fiyat,Tarih,MusteriTC) values (@AracPlaka,@SoketTuru,@SatilanMiktar,@Fiyat,@Tarih,@MusteriTC)", con.connection());
            cmd.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
            cmd.Parameters.AddWithValue("@SoketTuru", cmbSoket.Text);
            cmd.Parameters.AddWithValue("@SatilanMiktar", lblAktarılan.Text);           
            cmd.Parameters.AddWithValue("@Fiyat", lblTutar.Text);
            cmd.Parameters.AddWithValue("@Tarih", txtTarih.Text);
            cmd.Parameters.AddWithValue("@MusteriTC", mskTC.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();

            Musteri.frmSatisYukleme fr = new Musteri.frmSatisYukleme();
            fr.ShowDialog();
           
            
        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
            //yakıtla ilgili bilgiler
            #region "Ac Tip 2"                

            if (cmbSoket.Text== "AC Tip 2")
            {                
                if (Convert.ToInt16(txtSure.Text)<=59 && Convert.ToInt16(txtSure.Text)>0)
                {
                    
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='7.4 kW’a kadar'",con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (7.4 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (0.55 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if(Convert.ToInt16(txtSure.Text) >59 && Convert.ToInt16(txtSure.Text) < 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='7.4 kW-11 kW arası'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (9.2 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (0.85 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToDouble(txtSure.Text) >= 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='11 kW ve üzeri'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (11 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (1.15 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                
                
            }
            #endregion
            #region "DC"
            else if (cmbSoket.Text == "DC")
            {
                if (Convert.ToInt16(txtSure.Text) <= 59)
                {

                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW’a kadar'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (50 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (3.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToInt16(txtSure.Text) > 59 && Convert.ToInt16(txtSure.Text) < 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW-90 kW arası'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (70 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (5.30 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if(Convert.ToDouble(txtSure.Text) >= 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='90 kW ve üzeri'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (90 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (7.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }

            }
            #endregion
            #region "CCS"
            else if (cmbSoket.Text == "CCS")
            {
                if (Convert.ToInt16(txtSure.Text) <= 59)
                {

                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW’a kadar'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (50 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (3.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToInt16(txtSure.Text) > 59 && Convert.ToInt16(txtSure.Text) < 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW-90 kW arası'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (70 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (5.30 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToDouble(txtSure.Text) >= 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='90 kW ve üzeri'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (90 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (7.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }

            }
            #endregion
            #region "CHAdeMO"
            else if (cmbSoket.Text == "CHAdeMO")
            {
                if (Convert.ToInt16(txtSure.Text) <= 59)
                {

                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW’a kadar'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (50 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (3.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToInt16(txtSure.Text) > 59 && Convert.ToInt16(txtSure.Text) < 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='50 kW-90 kW arası'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan= (70 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (5.30 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }
                else if (Convert.ToDouble(txtSure.Text) >= 90)
                {
                    SqlCommand cmd3 = new SqlCommand("select * from tbl_yakit where SoketGucAraligi='90 kW ve üzeri'", con.connection());
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        lblFiyat.Text = dr3[2].ToString();
                        double Aktarılan = (90 * Convert.ToDouble(txtSure.Text) / 60);
                        Aktarılan = Math.Round(Aktarılan, 2);

                        lblAktarılan.Text = Aktarılan.ToString();
                        lblTutar.Text = (7.90 * Convert.ToDouble(txtSure.Text)).ToString();
                    }
                }


            }
            #endregion



        }

       
    }
}
