﻿namespace Library.UI
{
    partial class frmEmanetIslemleri
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
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblUyeID = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateVerilis = new System.Windows.Forms.DateTimePicker();
            this.dateTeslim = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_Emanet = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtUyeIDAra = new System.Windows.Forms.TextBox();
            this.btnUyeIDAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBarkodAra = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.lblTeslimDurumu = new System.Windows.Forms.Label();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblEmanetID = new System.Windows.Forms.Label();
            this.txtEmanetID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Emanet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(131, 40);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(100, 20);
            this.txtUyeID.TabIndex = 0;
            this.txtUyeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUyeID_KeyPress);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(131, 69);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // lblUyeID
            // 
            this.lblUyeID.AutoSize = true;
            this.lblUyeID.Location = new System.Drawing.Point(29, 47);
            this.lblUyeID.Name = "lblUyeID";
            this.lblUyeID.Size = new System.Drawing.Size(43, 13);
            this.lblUyeID.TabIndex = 3;
            this.lblUyeID.Text = "ÜYE ID";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(29, 72);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(71, 13);
            this.lblBarkodNo.TabIndex = 4;
            this.lblBarkodNo.Text = "BARKOD NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VERİLİŞ TARİHİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TESLİM TARİHİ";
            // 
            // dateVerilis
            // 
            this.dateVerilis.Location = new System.Drawing.Point(131, 95);
            this.dateVerilis.Name = "dateVerilis";
            this.dateVerilis.Size = new System.Drawing.Size(200, 20);
            this.dateVerilis.TabIndex = 8;
            // 
            // dateTeslim
            // 
            this.dateTeslim.Location = new System.Drawing.Point(131, 121);
            this.dateTeslim.Name = "dateTeslim";
            this.dateTeslim.Size = new System.Drawing.Size(200, 20);
            this.dateTeslim.TabIndex = 9;
            // 
            // dataGrid_Emanet
            // 
            this.dataGrid_Emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Emanet.Location = new System.Drawing.Point(34, 225);
            this.dataGrid_Emanet.Name = "dataGrid_Emanet";
            this.dataGrid_Emanet.Size = new System.Drawing.Size(463, 86);
            this.dataGrid_Emanet.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(34, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(74, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(367, 174);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUyeIDAra
            // 
            this.txtUyeIDAra.Location = new System.Drawing.Point(441, 42);
            this.txtUyeIDAra.Name = "txtUyeIDAra";
            this.txtUyeIDAra.Size = new System.Drawing.Size(56, 20);
            this.txtUyeIDAra.TabIndex = 15;
            this.txtUyeIDAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUyeIDAra_KeyPress);
            // 
            // btnUyeIDAra
            // 
            this.btnUyeIDAra.Location = new System.Drawing.Point(367, 64);
            this.btnUyeIDAra.Name = "btnUyeIDAra";
            this.btnUyeIDAra.Size = new System.Drawing.Size(130, 23);
            this.btnUyeIDAra.TabIndex = 16;
            this.btnUyeIDAra.Text = "ARA";
            this.btnUyeIDAra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ÜYE ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "BARKOD NO";
            // 
            // btnBarkodAra
            // 
            this.btnBarkodAra.Location = new System.Drawing.Point(367, 119);
            this.btnBarkodAra.Name = "btnBarkodAra";
            this.btnBarkodAra.Size = new System.Drawing.Size(130, 23);
            this.btnBarkodAra.TabIndex = 19;
            this.btnBarkodAra.Text = "ARA";
            this.btnBarkodAra.UseVisualStyleBackColor = true;
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(441, 93);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(56, 20);
            this.txtBarkodNoAra.TabIndex = 18;
            this.txtBarkodNoAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNoAra_KeyPress);
            // 
            // lblTeslimDurumu
            // 
            this.lblTeslimDurumu.AutoSize = true;
            this.lblTeslimDurumu.Location = new System.Drawing.Point(31, 154);
            this.lblTeslimDurumu.Name = "lblTeslimDurumu";
            this.lblTeslimDurumu.Size = new System.Drawing.Size(56, 13);
            this.lblTeslimDurumu.TabIndex = 21;
            this.lblTeslimDurumu.Text = "DURUMU";
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(131, 154);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(103, 17);
            this.checkBoxDurum.TabIndex = 22;
            this.checkBoxDurum.Text = "TESLİM EDİLDİ";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(194, 187);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(74, 23);
            this.btnListele.TabIndex = 24;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblEmanetID
            // 
            this.lblEmanetID.AutoSize = true;
            this.lblEmanetID.Location = new System.Drawing.Point(364, 151);
            this.lblEmanetID.Name = "lblEmanetID";
            this.lblEmanetID.Size = new System.Drawing.Size(66, 13);
            this.lblEmanetID.TabIndex = 27;
            this.lblEmanetID.Text = "EMANET ID";
            // 
            // txtEmanetID
            // 
            this.txtEmanetID.Location = new System.Drawing.Point(441, 148);
            this.txtEmanetID.Name = "txtEmanetID";
            this.txtEmanetID.Size = new System.Drawing.Size(56, 20);
            this.txtEmanetID.TabIndex = 25;
            // 
            // frmEmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.lblEmanetID);
            this.Controls.Add(this.txtEmanetID);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.checkBoxDurum);
            this.Controls.Add(this.lblTeslimDurumu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBarkodAra);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUyeIDAra);
            this.Controls.Add(this.txtUyeIDAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGrid_Emanet);
            this.Controls.Add(this.dateTeslim);
            this.Controls.Add(this.dateVerilis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblUyeID);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtUyeID);
            this.Name = "frmEmanetIslemleri";
            this.Text = "frmEmanetIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Emanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblUyeID;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateVerilis;
        private System.Windows.Forms.DateTimePicker dateTeslim;
        private System.Windows.Forms.DataGridView dataGrid_Emanet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtUyeIDAra;
        private System.Windows.Forms.Button btnUyeIDAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBarkodAra;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label lblTeslimDurumu;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblEmanetID;
        private System.Windows.Forms.TextBox txtEmanetID;
    }
}