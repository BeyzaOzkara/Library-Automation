namespace Library.UI
{
    partial class frmUyeIslemleri
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
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGrid_TumUye = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblUyeTcNo = new System.Windows.Forms.Label();
            this.lblUyeSoyisim = new System.Windows.Forms.Label();
            this.lblUyeIsim = new System.Windows.Forms.Label();
            this.txtUyeTcNo = new System.Windows.Forms.TextBox();
            this.txtUyeSoyisim = new System.Windows.Forms.TextBox();
            this.txtUyeIsim = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.lblUyeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TumUye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(285, 28);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(517, 23);
            this.btnListele.TabIndex = 26;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGrid_TumUye
            // 
            this.dataGrid_TumUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_TumUye.Location = new System.Drawing.Point(285, 68);
            this.dataGrid_TumUye.Name = "dataGrid_TumUye";
            this.dataGrid_TumUye.ReadOnly = true;
            this.dataGrid_TumUye.Size = new System.Drawing.Size(517, 228);
            this.dataGrid_TumUye.TabIndex = 25;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(46, 144);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 23);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblUyeTcNo
            // 
            this.lblUyeTcNo.AutoSize = true;
            this.lblUyeTcNo.Location = new System.Drawing.Point(43, 108);
            this.lblUyeTcNo.Name = "lblUyeTcNo";
            this.lblUyeTcNo.Size = new System.Drawing.Size(40, 13);
            this.lblUyeTcNo.TabIndex = 21;
            this.lblUyeTcNo.Text = "TC NO";
            // 
            // lblUyeSoyisim
            // 
            this.lblUyeSoyisim.AutoSize = true;
            this.lblUyeSoyisim.Location = new System.Drawing.Point(43, 71);
            this.lblUyeSoyisim.Name = "lblUyeSoyisim";
            this.lblUyeSoyisim.Size = new System.Drawing.Size(51, 13);
            this.lblUyeSoyisim.TabIndex = 20;
            this.lblUyeSoyisim.Text = "SOYİSİM";
            // 
            // lblUyeIsim
            // 
            this.lblUyeIsim.AutoSize = true;
            this.lblUyeIsim.Location = new System.Drawing.Point(43, 33);
            this.lblUyeIsim.Name = "lblUyeIsim";
            this.lblUyeIsim.Size = new System.Drawing.Size(29, 13);
            this.lblUyeIsim.TabIndex = 19;
            this.lblUyeIsim.Text = "İSİM";
            // 
            // txtUyeTcNo
            // 
            this.txtUyeTcNo.Location = new System.Drawing.Point(134, 105);
            this.txtUyeTcNo.Name = "txtUyeTcNo";
            this.txtUyeTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtUyeTcNo.TabIndex = 16;
            // 
            // txtUyeSoyisim
            // 
            this.txtUyeSoyisim.Location = new System.Drawing.Point(134, 68);
            this.txtUyeSoyisim.Name = "txtUyeSoyisim";
            this.txtUyeSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtUyeSoyisim.TabIndex = 15;
            // 
            // txtUyeIsim
            // 
            this.txtUyeIsim.Location = new System.Drawing.Point(134, 30);
            this.txtUyeIsim.Name = "txtUyeIsim";
            this.txtUyeIsim.Size = new System.Drawing.Size(100, 20);
            this.txtUyeIsim.TabIndex = 14;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(134, 222);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "TC NO";
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(46, 248);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(188, 23);
            this.btnArama.TabIndex = 29;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(180, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(134, 280);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(40, 20);
            this.txtUyeID.TabIndex = 34;
            // 
            // lblUyeID
            // 
            this.lblUyeID.AutoSize = true;
            this.lblUyeID.Location = new System.Drawing.Point(43, 283);
            this.lblUyeID.Name = "lblUyeID";
            this.lblUyeID.Size = new System.Drawing.Size(43, 13);
            this.lblUyeID.TabIndex = 35;
            this.lblUyeID.Text = "ÜYE ID";
            // 
            // frmUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 337);
            this.Controls.Add(this.lblUyeID);
            this.Controls.Add(this.txtUyeID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGrid_TumUye);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblUyeTcNo);
            this.Controls.Add(this.lblUyeSoyisim);
            this.Controls.Add(this.lblUyeIsim);
            this.Controls.Add(this.txtUyeTcNo);
            this.Controls.Add(this.txtUyeSoyisim);
            this.Controls.Add(this.txtUyeIsim);
            this.Name = "frmUyeIslemleri";
            this.Text = "Üye Işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TumUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGrid_TumUye;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblUyeTcNo;
        private System.Windows.Forms.Label lblUyeSoyisim;
        private System.Windows.Forms.Label lblUyeIsim;
        private System.Windows.Forms.TextBox txtUyeTcNo;
        private System.Windows.Forms.TextBox txtUyeSoyisim;
        private System.Windows.Forms.TextBox txtUyeIsim;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.Label lblUyeID;
    }
}