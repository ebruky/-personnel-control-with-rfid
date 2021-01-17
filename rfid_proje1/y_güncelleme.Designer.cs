namespace rfid_proje1
{
    partial class y_güncelleme
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
            this.geri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kart_id = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.BackgroundImage = global::rfid_proje1.Properties.Resources.indir;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Location = new System.Drawing.Point(3, 373);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 54);
            this.geri.TabIndex = 0;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 257);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(500, 356);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 42);
            this.sil.TabIndex = 2;
            this.sil.Text = "Kaydı Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.Button1_Click);
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(598, 356);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(75, 42);
            this.duzenle.TabIndex = 3;
            this.duzenle.Text = "Kaydı Güncelle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.Duzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kart-Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC. No:";
            // 
            // kart_id
            // 
            this.kart_id.Enabled = false;
            this.kart_id.Location = new System.Drawing.Point(573, 190);
            this.kart_id.Name = "kart_id";
            this.kart_id.Size = new System.Drawing.Size(100, 20);
            this.kart_id.TabIndex = 17;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(573, 146);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 16;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(573, 108);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(100, 20);
            this.tel.TabIndex = 15;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(573, 68);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 20);
            this.ad.TabIndex = 14;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(573, 31);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 20);
            this.tc.TabIndex = 13;
            // 
            // y_güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kart_id);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geri);
            this.Name = "y_güncelleme";
            this.Text = "y_güncelleme";
            this.Load += new System.EventHandler(this.Y_güncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kart_id;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox tc;
    }
}