namespace Library.UI
{
    partial class frmKitapIslemleri
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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.blSayfaSayisi = new System.Windows.Forms.Label();
            this.lblBasimYili = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridKitap = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.lblKitap = new System.Windows.Forms.Label();
            this.txtKitap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(122, 17);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(122, 43);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 1;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(122, 69);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinevi.TabIndex = 2;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(122, 95);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaSayisi.TabIndex = 3;
            this.txtSayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayfaSayisi_KeyPress);
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(122, 121);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(100, 20);
            this.txtBasimYili.TabIndex = 4;
            this.txtBasimYili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasimYili_KeyPress);
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(31, 20);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(59, 13);
            this.lblKitapAdi.TabIndex = 6;
            this.lblKitapAdi.Text = "KİTAP ADI";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(31, 46);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(43, 13);
            this.lblYazar.TabIndex = 7;
            this.lblYazar.Text = "YAZAR";
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.Location = new System.Drawing.Point(31, 72);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(56, 13);
            this.lblYayinevi.TabIndex = 8;
            this.lblYayinevi.Text = "YAYINEVİ";
            // 
            // blSayfaSayisi
            // 
            this.blSayfaSayisi.AutoSize = true;
            this.blSayfaSayisi.Location = new System.Drawing.Point(31, 98);
            this.blSayfaSayisi.Name = "blSayfaSayisi";
            this.blSayfaSayisi.Size = new System.Drawing.Size(78, 13);
            this.blSayfaSayisi.TabIndex = 9;
            this.blSayfaSayisi.Text = "SAYFA SAYISI";
            // 
            // lblBasimYili
            // 
            this.lblBasimYili.AutoSize = true;
            this.lblBasimYili.Location = new System.Drawing.Point(31, 124);
            this.lblBasimYili.Name = "lblBasimYili";
            this.lblBasimYili.Size = new System.Drawing.Size(62, 13);
            this.lblBasimYili.TabIndex = 10;
            this.lblBasimYili.Text = "BASIM YILI";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(34, 148);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridKitap
            // 
            this.dataGridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitap.Location = new System.Drawing.Point(277, 60);
            this.dataGridKitap.Name = "dataGridKitap";
            this.dataGridKitap.ReadOnly = true;
            this.dataGridKitap.Size = new System.Drawing.Size(513, 213);
            this.dataGridKitap.TabIndex = 12;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(277, 17);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(513, 23);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(33, 260);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(71, 13);
            this.lblBarkodNo.TabIndex = 42;
            this.lblBarkodNo.Text = "BARKOD NO";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(124, 257);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(40, 20);
            this.txtBarkodNo.TabIndex = 41;
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(170, 254);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 23);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(36, 225);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(188, 23);
            this.btnArama.TabIndex = 38;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(33, 199);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(59, 13);
            this.lblKitap.TabIndex = 37;
            this.lblKitap.Text = "KİTAP ADI";
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(124, 199);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(100, 20);
            this.txtKitap.TabIndex = 36;
            // 
            // frmKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 306);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridKitap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblBasimYili);
            this.Controls.Add(this.blSayfaSayisi);
            this.Controls.Add(this.lblYayinevi);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Name = "frmKitapIslemleri";
            this.Text = "Kitap Işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label blSayfaSayisi;
        private System.Windows.Forms.Label lblBasimYili;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridKitap;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.TextBox txtKitap;
    }
}