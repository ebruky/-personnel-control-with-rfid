namespace rfid_proje1
{
    partial class y_mesaj
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_ara = new System.Windows.Forms.TextBox();
            this.ad_ara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.mesaj_gonder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mail = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.duyuru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tc.No\'ya Göre Arama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "İsme Göre Arama:";
            // 
            // tc_ara
            // 
            this.tc_ara.Location = new System.Drawing.Point(178, 60);
            this.tc_ara.Name = "tc_ara";
            this.tc_ara.Size = new System.Drawing.Size(100, 20);
            this.tc_ara.TabIndex = 10;
            this.tc_ara.TextChanged += new System.EventHandler(this.Tc_ara_TextChanged);
            // 
            // ad_ara
            // 
            this.ad_ara.Location = new System.Drawing.Point(32, 60);
            this.ad_ara.Name = "ad_ara";
            this.ad_ara.Size = new System.Drawing.Size(100, 20);
            this.ad_ara.TabIndex = 9;
            this.ad_ara.TextChanged += new System.EventHandler(this.Ad_ara_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 173);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mesaj:";
            // 
            // mesaj
            // 
            this.mesaj.Location = new System.Drawing.Point(310, 297);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(100, 63);
            this.mesaj.TabIndex = 19;
            // 
            // mesaj_gonder
            // 
            this.mesaj_gonder.Location = new System.Drawing.Point(310, 374);
            this.mesaj_gonder.Name = "mesaj_gonder";
            this.mesaj_gonder.Size = new System.Drawing.Size(100, 33);
            this.mesaj_gonder.TabIndex = 18;
            this.mesaj_gonder.Text = "Mesaj Gönder";
            this.mesaj_gonder.UseVisualStyleBackColor = true;
            this.mesaj_gonder.Click += new System.EventHandler(this.Mesaj_gonder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 22;
            this.button2.Text = "Seçilen Kişinin Mesajlarını Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(437, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(170, 387);
            this.dataGridView2.TabIndex = 23;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(310, 423);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 23);
            this.mail.TabIndex = 24;
            this.mail.Text = "Mail Gönder";
            this.mail.UseVisualStyleBackColor = true;
            this.mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // geri
            // 
            this.geri.BackgroundImage = global::rfid_proje1.Properties.Resources.indir;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Location = new System.Drawing.Point(2, 367);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 54);
            this.geri.TabIndex = 2;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // duyuru
            // 
            this.duyuru.Location = new System.Drawing.Point(447, 423);
            this.duyuru.Name = "duyuru";
            this.duyuru.Size = new System.Drawing.Size(119, 23);
            this.duyuru.TabIndex = 25;
            this.duyuru.Text = "Herkese Duyuru!";
            this.duyuru.UseVisualStyleBackColor = true;
            this.duyuru.Click += new System.EventHandler(this.Duyuru_Click);
            // 
            // y_mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 458);
            this.Controls.Add(this.duyuru);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.mesaj_gonder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tc_ara);
            this.Controls.Add(this.ad_ara);
            this.Controls.Add(this.geri);
            this.Name = "y_mesaj";
            this.Text = "y_mesaj";
            this.Load += new System.EventHandler(this.Y_mesaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc_ara;
        private System.Windows.Forms.TextBox ad_ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Button mesaj_gonder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.Button duyuru;
    }
}