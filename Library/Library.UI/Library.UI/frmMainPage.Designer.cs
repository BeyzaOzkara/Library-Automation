namespace Library.UI
{
    partial class frmMainPage
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
            this.btnKitapİslemleri = new System.Windows.Forms.Button();
            this.btnUyeIslemleri = new System.Windows.Forms.Button();
            this.btnEmanetİslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitapİslemleri
            // 
            this.btnKitapİslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKitapİslemleri.Location = new System.Drawing.Point(78, 95);
            this.btnKitapİslemleri.Name = "btnKitapİslemleri";
            this.btnKitapİslemleri.Size = new System.Drawing.Size(103, 104);
            this.btnKitapİslemleri.TabIndex = 0;
            this.btnKitapİslemleri.Text = "KİTAP İŞLEMLERİ";
            this.btnKitapİslemleri.UseVisualStyleBackColor = false;
            this.btnKitapİslemleri.Click += new System.EventHandler(this.btnKitapİslemleri_Click);
            // 
            // btnUyeIslemleri
            // 
            this.btnUyeIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUyeIslemleri.Location = new System.Drawing.Point(187, 95);
            this.btnUyeIslemleri.Name = "btnUyeIslemleri";
            this.btnUyeIslemleri.Size = new System.Drawing.Size(103, 104);
            this.btnUyeIslemleri.TabIndex = 1;
            this.btnUyeIslemleri.Text = "ÜYE İŞLEMLERİ";
            this.btnUyeIslemleri.UseVisualStyleBackColor = false;
            this.btnUyeIslemleri.Click += new System.EventHandler(this.btnUyeIslemleri_Click);
            // 
            // btnEmanetİslemleri
            // 
            this.btnEmanetİslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEmanetİslemleri.Location = new System.Drawing.Point(296, 95);
            this.btnEmanetİslemleri.Name = "btnEmanetİslemleri";
            this.btnEmanetİslemleri.Size = new System.Drawing.Size(103, 104);
            this.btnEmanetİslemleri.TabIndex = 2;
            this.btnEmanetİslemleri.Text = "EMANET İŞLEMLERİ";
            this.btnEmanetİslemleri.UseVisualStyleBackColor = false;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(476, 295);
            this.Controls.Add(this.btnEmanetİslemleri);
            this.Controls.Add(this.btnUyeIslemleri);
            this.Controls.Add(this.btnKitapİslemleri);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapİslemleri;
        private System.Windows.Forms.Button btnUyeIslemleri;
        private System.Windows.Forms.Button btnEmanetİslemleri;
    }
}