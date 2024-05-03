
namespace hastaneyonetimsistemi
{
    partial class FrmBilgiDuzenle
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.maskedtlf = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(61, 55);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 23);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Ad:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(61, 105);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(68, 23);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(61, 157);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(73, 23);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "TC No:";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.Location = new System.Drawing.Point(61, 207);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(80, 23);
            this.lbltelefon.TabIndex = 3;
            this.lbltelefon.Text = "Telefon:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(61, 256);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(58, 23);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre:";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(61, 310);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(86, 23);
            this.lblcinsiyet.TabIndex = 5;
            this.lblcinsiyet.Text = "Cinsiyet:";
            // 
            // maskedtc
            // 
            this.maskedtc.Location = new System.Drawing.Point(165, 157);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(121, 22);
            this.maskedtc.TabIndex = 6;
            // 
            // maskedtlf
            // 
            this.maskedtlf.Location = new System.Drawing.Point(165, 209);
            this.maskedtlf.Mask = "(999) 000-0000";
            this.maskedtlf.Name = "maskedtlf";
            this.maskedtlf.Size = new System.Drawing.Size(121, 22);
            this.maskedtlf.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(165, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 22);
            this.txtAd.TabIndex = 8;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(165, 107);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 22);
            this.txtsoyad.TabIndex = 9;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(165, 258);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(121, 22);
            this.txtsifre.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(165, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(132, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(507, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.maskedtlf);
            this.Controls.Add(this.maskedtc);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblname);
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.MaskedTextBox maskedtlf;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}