namespace TkiZoo.UI
{
    partial class FrmHayvan
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtHayvanCinsiyet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHayvanYas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHayvanAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Iptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(184, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtHayvanCinsiyet
            // 
            this.txtHayvanCinsiyet.Location = new System.Drawing.Point(104, 179);
            this.txtHayvanCinsiyet.Name = "txtHayvanCinsiyet";
            this.txtHayvanCinsiyet.Size = new System.Drawing.Size(247, 20);
            this.txtHayvanCinsiyet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cinsiyet";
            // 
            // txtHayvanYas
            // 
            this.txtHayvanYas.Location = new System.Drawing.Point(104, 143);
            this.txtHayvanYas.Name = "txtHayvanYas";
            this.txtHayvanYas.Size = new System.Drawing.Size(247, 20);
            this.txtHayvanYas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tur";
            // 
            // txtHayvanAd
            // 
            this.txtHayvanAd.Location = new System.Drawing.Point(104, 71);
            this.txtHayvanAd.Name = "txtHayvanAd";
            this.txtHayvanAd.Size = new System.Drawing.Size(247, 20);
            this.txtHayvanAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(104, 34);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(247, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Otobur",
            "Etobur",
            "Hepcil"});
            this.cbTur.Location = new System.Drawing.Point(104, 107);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(247, 21);
            this.cbTur.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmHayvan
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 282);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtHayvanCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHayvanYas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHayvanAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHayvan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHayvan";
            this.Load += new System.EventHandler(this.FrmHayvan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtHayvanCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHayvanYas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHayvanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}