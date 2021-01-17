namespace rfid_proje1
{
    partial class y_sorgulama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad_ara = new System.Windows.Forms.TextBox();
            this.tc_ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 164);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // ad_ara
            // 
            this.ad_ara.Location = new System.Drawing.Point(39, 71);
            this.ad_ara.Name = "ad_ara";
            this.ad_ara.Size = new System.Drawing.Size(100, 20);
            this.ad_ara.TabIndex = 3;
            this.ad_ara.TextChanged += new System.EventHandler(this.Ad_ara_TextChanged);
            // 
            // tc_ara
            // 
            this.tc_ara.Location = new System.Drawing.Point(185, 71);
            this.tc_ara.Name = "tc_ara";
            this.tc_ara.Size = new System.Drawing.Size(100, 20);
            this.tc_ara.TabIndex = 4;
            this.tc_ara.TextChanged += new System.EventHandler(this.Tc_ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsme Göre Arama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tc.No\'ya Göre Arama:";
            // 
            // geri
            // 
            this.geri.BackgroundImage = global::rfid_proje1.Properties.Resources.indir;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Location = new System.Drawing.Point(3, 349);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 54);
            this.geri.TabIndex = 1;
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // y_sorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tc_ara);
            this.Controls.Add(this.ad_ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geri);
            this.Name = "y_sorgulama";
            this.Text = "y_sorgulama";
            this.Load += new System.EventHandler(this.Y_sorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ad_ara;
        private System.Windows.Forms.TextBox tc_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}