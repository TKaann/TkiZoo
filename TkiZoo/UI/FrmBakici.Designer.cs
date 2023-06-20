namespace TkiZoo.UI
{
    partial class FrmBakici
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBakiciCinsiyet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBakiciYas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBakiciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHayvan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBakiciHayvan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBakiciSoyad = new System.Windows.Forms.TextBox();
            this.txtBakiciTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHayvanSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Iptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(201, 335);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBakiciCinsiyet
            // 
            this.txtBakiciCinsiyet.Location = new System.Drawing.Point(120, 214);
            this.txtBakiciCinsiyet.Name = "txtBakiciCinsiyet";
            this.txtBakiciCinsiyet.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciCinsiyet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Bakici Cinsiyet";
            // 
            // txtBakiciYas
            // 
            this.txtBakiciYas.Location = new System.Drawing.Point(120, 178);
            this.txtBakiciYas.Name = "txtBakiciYas";
            this.txtBakiciYas.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciYas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bakici Yas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bakici Soyad";
            // 
            // txtBakiciAd
            // 
            this.txtBakiciAd.Location = new System.Drawing.Point(120, 106);
            this.txtBakiciAd.Name = "txtBakiciAd";
            this.txtBakiciAd.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Bakici Ad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(247, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // txtHayvan
            // 
            this.txtHayvan.Location = new System.Drawing.Point(120, 64);
            this.txtHayvan.Name = "txtHayvan";
            this.txtHayvan.ReadOnly = true;
            this.txtHayvan.Size = new System.Drawing.Size(247, 20);
            this.txtHayvan.TabIndex = 1;
            this.txtHayvan.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hayvan";
            // 
            // txtBakiciHayvan
            // 
            this.txtBakiciHayvan.Location = new System.Drawing.Point(120, 288);
            this.txtBakiciHayvan.Name = "txtBakiciHayvan";
            this.txtBakiciHayvan.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciHayvan.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Baktigi Hayvan";
            // 
            // txtBakiciSoyad
            // 
            this.txtBakiciSoyad.Location = new System.Drawing.Point(120, 143);
            this.txtBakiciSoyad.Name = "txtBakiciSoyad";
            this.txtBakiciSoyad.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciSoyad.TabIndex = 3;
            // 
            // txtBakiciTel
            // 
            this.txtBakiciTel.Location = new System.Drawing.Point(120, 251);
            this.txtBakiciTel.Name = "txtBakiciTel";
            this.txtBakiciTel.Size = new System.Drawing.Size(247, 20);
            this.txtBakiciTel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Bakici Telefon";
            // 
            // btnHayvanSec
            // 
            this.btnHayvanSec.Location = new System.Drawing.Point(383, 66);
            this.btnHayvanSec.Name = "btnHayvanSec";
            this.btnHayvanSec.Size = new System.Drawing.Size(83, 23);
            this.btnHayvanSec.TabIndex = 34;
            this.btnHayvanSec.Text = "Hayvan Sec";
            this.btnHayvanSec.UseVisualStyleBackColor = true;
            this.btnHayvanSec.Click += new System.EventHandler(this.btnHayvanSec_Click);
            // 
            // FrmBakici
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 380);
            this.Controls.Add(this.btnHayvanSec);
            this.Controls.Add(this.txtBakiciTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBakiciSoyad);
            this.Controls.Add(this.txtBakiciHayvan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHayvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBakiciCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBakiciYas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBakiciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBakici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBakici";
            this.Load += new System.EventHandler(this.FrmBakici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBakiciCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBakiciYas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBakiciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHayvan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBakiciHayvan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBakiciSoyad;
        private System.Windows.Forms.TextBox txtBakiciTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHayvanSec;
    }
}