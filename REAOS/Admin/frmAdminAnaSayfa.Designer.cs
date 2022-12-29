namespace REAOS
{
    partial class frmAdminAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAnaSayfa));
            this.btnYakit = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SatisGecmisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYakit
            // 
            this.btnYakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnYakit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYakit.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYakit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btnYakit.Image = ((System.Drawing.Image)(resources.GetObject("btnYakit.Image")));
            this.btnYakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYakit.Location = new System.Drawing.Point(420, 217);
            this.btnYakit.Name = "btnYakit";
            this.btnYakit.Size = new System.Drawing.Size(200, 70);
            this.btnYakit.TabIndex = 3;
            this.btnYakit.Text = "Yakıt Ekle/Çıkar";
            this.btnYakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYakit.UseVisualStyleBackColor = false;
            this.btnYakit.Click += new System.EventHandler(this.btnYakit_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.Location = new System.Drawing.Point(8, 216);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(200, 70);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btnMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btnMusteri.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.Image")));
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(214, 217);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(200, 70);
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "Müşteri İşlemleri";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Coco Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(149, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rigor Elektrikli Araç Otomasyonları Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SatisGecmisi
            // 
            this.btn_SatisGecmisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.btn_SatisGecmisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SatisGecmisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SatisGecmisi.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SatisGecmisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.btn_SatisGecmisi.Image = ((System.Drawing.Image)(resources.GetObject("btn_SatisGecmisi.Image")));
            this.btn_SatisGecmisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SatisGecmisi.Location = new System.Drawing.Point(626, 217);
            this.btn_SatisGecmisi.Name = "btn_SatisGecmisi";
            this.btn_SatisGecmisi.Size = new System.Drawing.Size(200, 70);
            this.btn_SatisGecmisi.TabIndex = 20;
            this.btn_SatisGecmisi.Text = "Satış Geçmişi";
            this.btn_SatisGecmisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SatisGecmisi.UseVisualStyleBackColor = false;
            this.btn_SatisGecmisi.Click += new System.EventHandler(this.btn_SatisGecmisi_Click);
            // 
            // frmAdminAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(833, 301);
            this.Controls.Add(this.btn_SatisGecmisi);
            this.Controls.Add(this.btnYakit);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminAnaSayfa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYakit;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SatisGecmisi;
    }
}