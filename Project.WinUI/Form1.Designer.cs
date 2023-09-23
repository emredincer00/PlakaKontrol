namespace Project.WinUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnAmblem = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIletisim = new System.Windows.Forms.Button();
            this.btnDetayliIncele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 270);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(37, 411);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(162, 20);
            this.txtEkle.TabIndex = 19;
            this.txtEkle.Click += new System.EventHandler(this.txtEkle_Click_1);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(239, 411);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(162, 20);
            this.txtBilgi.TabIndex = 19;
            this.txtBilgi.Click += new System.EventHandler(this.txtEkle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bilgilendirme:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(100, 81);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(238, 20);
            this.txtArama.TabIndex = 23;
            this.txtArama.Text = "Bulmak istediğiniz plakayı girin.";
            this.txtArama.Click += new System.EventHandler(this.txtArama_Click);
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtArama_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Plaka Gir:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(425, 387);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(469, 171);
            this.lblAciklama.TabIndex = 25;
            // 
            // btnAmblem
            // 
            this.btnAmblem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAmblem.BackgroundImage = global::Project.WinUI.Properties.Resources.sdfdsfbd4e8f076e3cff0;
            this.btnAmblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmblem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAmblem.FlatAppearance.BorderSize = 0;
            this.btnAmblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmblem.ForeColor = System.Drawing.Color.Transparent;
            this.btnAmblem.Location = new System.Drawing.Point(795, 11);
            this.btnAmblem.Name = "btnAmblem";
            this.btnAmblem.Size = new System.Drawing.Size(99, 90);
            this.btnAmblem.TabIndex = 27;
            this.btnAmblem.UseVisualStyleBackColor = false;
            this.btnAmblem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAmblem_MouseMove);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Salmon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(239, 449);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 36);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSil_MouseMove);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSalmon;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(37, 449);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 36);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnKaydet_MouseMove);
            // 
            // btnIletisim
            // 
            this.btnIletisim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIletisim.Font = new System.Drawing.Font("Arial", 9F);
            this.btnIletisim.Location = new System.Drawing.Point(16, 534);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(75, 23);
            this.btnIletisim.TabIndex = 29;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.UseVisualStyleBackColor = true;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // btnDetayliIncele
            // 
            this.btnDetayliIncele.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDetayliIncele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayliIncele.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetayliIncele.Location = new System.Drawing.Point(368, 74);
            this.btnDetayliIncele.Name = "btnDetayliIncele";
            this.btnDetayliIncele.Size = new System.Drawing.Size(159, 28);
            this.btnDetayliIncele.TabIndex = 30;
            this.btnDetayliIncele.Text = "Detaylı İncele";
            this.btnDetayliIncele.UseVisualStyleBackColor = false;
            this.btnDetayliIncele.Click += new System.EventHandler(this.btnDetayliIncele_Click);
            this.btnDetayliIncele.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDetayliIncele_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(917, 569);
            this.Controls.Add(this.btnDetayliIncele);
            this.Controls.Add(this.btnIletisim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAmblem);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koksoy Plaka Sorgulama";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnAmblem;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIletisim;
        private System.Windows.Forms.Button btnDetayliIncele;
    }
}

