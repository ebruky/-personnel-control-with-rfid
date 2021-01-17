namespace rfid_proje1
{
    partial class yonetici_sf
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
            this.label1 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.guncelleme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(101, 65);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(75, 23);
            this.arama.TabIndex = 1;
            this.arama.Text = "Arama";
            this.arama.UseVisualStyleBackColor = true;
            this.arama.Click += new System.EventHandler(this.Button1_Click);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(101, 113);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(75, 23);
            this.kayit.TabIndex = 2;
            this.kayit.Text = "Yeni Kayıt";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // guncelleme
            // 
            this.guncelleme.Location = new System.Drawing.Point(101, 165);
            this.guncelleme.Name = "guncelleme";
            this.guncelleme.Size = new System.Drawing.Size(75, 23);
            this.guncelleme.TabIndex = 3;
            this.guncelleme.Text = "Güncelleme";
            this.guncelleme.UseVisualStyleBackColor = true;
            this.guncelleme.Click += new System.EventHandler(this.Guncelleme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mesaj Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // geri
            // 
            this.geri.BackgroundImage = global::rfid_proje1.Properties.Resources.indir;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Location = new System.Drawing.Point(1, 361);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 54);
            this.geri.TabIndex = 4;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // sorgula
            // 
            this.sorgula.Location = new System.Drawing.Point(101, 223);
            this.sorgula.Name = "sorgula";
            this.sorgula.Size = new System.Drawing.Size(75, 23);
            this.sorgula.TabIndex = 7;
            this.sorgula.Text = "Sorgulama";
            this.sorgula.UseVisualStyleBackColor = true;
            this.sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // yonetici_sf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 418);
            this.Controls.Add(this.sorgula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.guncelleme);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.label1);
            this.Name = "yonetici_sf";
            this.Text = "yonetici_sf";
            this.Load += new System.EventHandler(this.Yonetici_sf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button guncelleme;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sorgula;
    }
}