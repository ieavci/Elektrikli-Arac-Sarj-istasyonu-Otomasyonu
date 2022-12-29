namespace REAOS
{
    partial class frmHesapla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapla));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.trackSicaklik = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.rdKlimaAcik = new System.Windows.Forms.RadioButton();
            this.rdKlimaKapali = new System.Windows.Forms.RadioButton();
            this.btnMenzilBilgisi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericSarj = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnasayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSicaklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSarj)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(82, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şarj (%) :";
            // 
            // cmbProfil
            // 
            this.cmbProfil.FormattingEnabled = true;
            this.cmbProfil.Items.AddRange(new object[] {
            "Comfort",
            "Normal",
            "Eco",
            "Sport"});
            this.cmbProfil.Location = new System.Drawing.Point(152, 156);
            this.cmbProfil.Name = "cmbProfil";
            this.cmbProfil.Size = new System.Drawing.Size(130, 21);
            this.cmbProfil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sürüş Profili :";
            // 
            // cmbJant
            // 
            this.cmbJant.FormattingEnabled = true;
            this.cmbJant.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cmbJant.Location = new System.Drawing.Point(152, 196);
            this.cmbJant.Name = "cmbJant";
            this.cmbJant.Size = new System.Drawing.Size(130, 21);
            this.cmbJant.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Jant Boyutu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKM.Location = new System.Drawing.Point(686, 168);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(145, 55);
            this.lblKM.TabIndex = 27;
            this.lblKM.Text = "00,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(811, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 33);
            this.label7.TabIndex = 28;
            this.label7.Text = "KM";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.Location = new System.Drawing.Point(319, 361);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Maximum = 450;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(598, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(452, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "TEK ŞARJ İLE KATEDİLEBİLECEK MESAFE";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.Location = new System.Drawing.Point(817, 12);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(100, 90);
            this.btnAnasayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAnasayfa.TabIndex = 31;
            this.btnAnasayfa.TabStop = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(348, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btnHesapla.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapla.Image")));
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.Location = new System.Drawing.Point(82, 326);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 70);
            this.btnHesapla.TabIndex = 33;
            this.btnHesapla.Text = "Menzil Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // trackSicaklik
            // 
            this.trackSicaklik.AutoSize = false;
            this.trackSicaklik.BackColor = System.Drawing.Color.White;
            this.trackSicaklik.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackSicaklik.LargeChange = 10;
            this.trackSicaklik.Location = new System.Drawing.Point(152, 225);
            this.trackSicaklik.Maximum = 30;
            this.trackSicaklik.Minimum = -10;
            this.trackSicaklik.Name = "trackSicaklik";
            this.trackSicaklik.Size = new System.Drawing.Size(130, 41);
            this.trackSicaklik.SmallChange = 10;
            this.trackSicaklik.TabIndex = 34;
            this.trackSicaklik.TickFrequency = 10;
            this.trackSicaklik.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dış Sıcaklık :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(304, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "C°";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC.Location = new System.Drawing.Point(282, 236);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 16);
            this.lblC.TabIndex = 37;
            this.lblC.Text = "C°";
            // 
            // rdKlimaAcik
            // 
            this.rdKlimaAcik.AutoSize = true;
            this.rdKlimaAcik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKlimaAcik.Location = new System.Drawing.Point(90, 280);
            this.rdKlimaAcik.Name = "rdKlimaAcik";
            this.rdKlimaAcik.Size = new System.Drawing.Size(88, 20);
            this.rdKlimaAcik.TabIndex = 38;
            this.rdKlimaAcik.TabStop = true;
            this.rdKlimaAcik.Text = "Klima Açık";
            this.rdKlimaAcik.UseVisualStyleBackColor = true;
            this.rdKlimaAcik.Click += new System.EventHandler(this.rdKlimaAcik_Click);
            // 
            // rdKlimaKapali
            // 
            this.rdKlimaKapali.AutoSize = true;
            this.rdKlimaKapali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKlimaKapali.Location = new System.Drawing.Point(181, 280);
            this.rdKlimaKapali.Name = "rdKlimaKapali";
            this.rdKlimaKapali.Size = new System.Drawing.Size(100, 20);
            this.rdKlimaKapali.TabIndex = 39;
            this.rdKlimaKapali.TabStop = true;
            this.rdKlimaKapali.Text = "Klima Kapalı";
            this.rdKlimaKapali.UseVisualStyleBackColor = true;
            this.rdKlimaKapali.Click += new System.EventHandler(this.rdKlimaKapali_Click);
            // 
            // btnMenzilBilgisi
            // 
            this.btnMenzilBilgisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenzilBilgisi.BackgroundImage")));
            this.btnMenzilBilgisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenzilBilgisi.Location = new System.Drawing.Point(703, 257);
            this.btnMenzilBilgisi.Name = "btnMenzilBilgisi";
            this.btnMenzilBilgisi.Size = new System.Drawing.Size(36, 35);
            this.btnMenzilBilgisi.TabIndex = 40;
            this.btnMenzilBilgisi.UseVisualStyleBackColor = true;
            this.btnMenzilBilgisi.Click += new System.EventHandler(this.btnMenzilBilgisi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(742, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Menzil Bilgisi";
            // 
            // numericSarj
            // 
            this.numericSarj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericSarj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericSarj.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSarj.Location = new System.Drawing.Point(152, 120);
            this.numericSarj.Name = "numericSarj";
            this.numericSarj.Size = new System.Drawing.Size(130, 22);
            this.numericSarj.TabIndex = 42;
            this.numericSarj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(253, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 43);
            this.label5.TabIndex = 43;
            this.label5.Text = "Menzil Hesaplaması IEC 62196 standartları kapsamında ortalama 150kW/h Güç ve 450 " +
    "km Maksimum Parametre Alınarak Hesaplanmaktadır";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericSarj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMenzilBilgisi);
            this.Controls.Add(this.rdKlimaKapali);
            this.Controls.Add(this.rdKlimaAcik);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackSicaklik);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbJant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHesapla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REAOS Menzil Hesaplama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHesapla_FormClosed);
            this.Load += new System.EventHandler(this.frmHesapla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnasayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSicaklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSarj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TrackBar trackSicaklik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton rdKlimaAcik;
        private System.Windows.Forms.RadioButton rdKlimaKapali;
        private System.Windows.Forms.Button btnMenzilBilgisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericSarj;
        private System.Windows.Forms.Label label5;
    }
}