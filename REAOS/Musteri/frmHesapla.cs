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
    public partial class frmHesapla : Form
    {
        public frmHesapla()
        {
            InitializeComponent();
        }
        sqlbaglantisi con = new sqlbaglantisi();

        private void frmHesapla_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmHesapla_Load(object sender, EventArgs e)
        {

            
            //tooltip
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(trackSicaklik, "Dış sıcaklığın elektrik menzili üzerinde belirleyici bir etkisi vardır." +
                "Sıcaklık ayarını sürükleyip değiştirerek, farklı dış sıcaklıkları simüle edebilir ve menzil üzerindeki" +
                "etkisini gözlemleyebilirsiniz.");


        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lblC.Text = trackSicaklik.Value.ToString();
        }

        private void btnMenzilBilgisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WLTP, tip onayı süreci kapsamında yasal olarak tanımlanmış bir ölçüm prosedürüdür." +
                "Konfigüratörde, bireysel otomobil konfigürasyonunuz için WLTP menzilini bulabilirsiniz." +
                "WLTP'ye göre menzil, standart ekipman ve tanımlanmış test koşulları altında farklı kısmi döngülerden" +
                "(şehir içi, kırsal, otoyol) bir değer olduğu için (örn. ilave tüketiciler kapalıyken), burada gösterilen" +
                "simüle edilmiş pratik menzil, WLTP aralığından farklı olabilir. WLTP ile karşılaştırıldığında, simüle edilmiş" +
                "pratik menzil, diğer şeylerin yanı sıra, örnek kabul edilen opsiyonel donanımları, ilave tüketicilerin" +
                "kullanımını ve yükü içerir.","Menzil Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        decimal menzil;
        double SurusProfiliGucu;
        double jantEtkisi;
        double sicaklikEtkisi;
        double klimaEtkisi;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            {  //  Comfort=80 Normal=85 Eco=100 Sport=70
                if (cmbProfil.Text == "Comfort")
                {
                    SurusProfiliGucu = 0.8;

                }
                else if (cmbProfil.Text == "Normal")
                {
                    SurusProfiliGucu = 0.85;
                }
                else if (cmbProfil.Text == "Eco")
                {
                    SurusProfiliGucu = 1;
                }
                else if (cmbProfil.Text == "Sport")
                {
                    SurusProfiliGucu = 0.7;
                }
            }
            {// 15=0.8 16=0.9 17=1 18=0.9 19=0.8
                if (cmbJant.Text == "15")
                {
                    jantEtkisi = 0.8;

                }
                else if (cmbJant.Text == "16")
                {
                    jantEtkisi = 0.9;
                }
                else if (cmbJant.Text == "17")
                {
                    jantEtkisi = 1;
                }
                else if (cmbJant.Text == "18")
                {
                    jantEtkisi = 0.9;
                }
                else if (cmbJant.Text == "19")
                {
                    jantEtkisi = 0.8;
                }
            }
            {
                // 1=0.389 2=0.493 3=0.677 4=1 5=0.722
                if (trackSicaklik.Value>=-10 && trackSicaklik.Value<0)
                {
                    sicaklikEtkisi = 0.389;
                }
                else if (trackSicaklik.Value >=0 && trackSicaklik.Value < 10)
                {
                    sicaklikEtkisi=0.493;
                }
                else if (trackSicaklik.Value >= 10 && trackSicaklik.Value < 20)
                {
                    sicaklikEtkisi = 0.677;
                }
                else if (trackSicaklik.Value >= 20 && trackSicaklik.Value < 30)
                {
                    sicaklikEtkisi = 1;
                }
                else if (trackSicaklik.Value >= 30 && trackSicaklik.Value < 40)
                {
                    sicaklikEtkisi = 0.722;
                }
            }

            if (klimaEtkisi==1)
            {
                menzil= ((450 * (numericSarj.Value) / 100) * Convert.ToDecimal(jantEtkisi) * Convert.ToDecimal(sicaklikEtkisi) * Convert.ToDecimal(SurusProfiliGucu));
                lblKM.Text = menzil.ToString();
                progressBar1.Value = Convert.ToInt16(menzil);
            }
            else if (klimaEtkisi== 0.698)
            {
                menzil = ((450 * (numericSarj.Value) / 100) * Convert.ToDecimal(jantEtkisi) * Convert.ToDecimal(sicaklikEtkisi) * Convert.ToDecimal(0.698) * Convert.ToDecimal(SurusProfiliGucu));
                menzil = Decimal.Round(menzil,2);
                lblKM.Text = menzil.ToString();
                progressBar1.Value = Convert.ToInt16(menzil);
            }
        
            
        }

        private void rdKlimaAcik_Click(object sender, EventArgs e)
        {
            klimaEtkisi = 0.698;
        }

        private void rdKlimaKapali_Click(object sender, EventArgs e)
        {
            klimaEtkisi = 1;
        }

        
    }
}
