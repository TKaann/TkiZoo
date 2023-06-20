namespace TkiZoo.UI
{
    partial class Hayvanlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnHayvanEkle = new System.Windows.Forms.ToolStripButton();
            this.btnHayvanDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnHayvanSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHayvanBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnOK);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HAYVANLAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(785, 326);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHayvanEkle,
            this.btnHayvanDuzenle,
            this.btnHayvanSil,
            this.toolStripSeparator2,
            this.btnHayvanBul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnHayvanEkle
            // 
            this.btnHayvanEkle.Image = global::TkiZoo.Properties.Resources.book_add;
            this.btnHayvanEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanEkle.Name = "btnHayvanEkle";
            this.btnHayvanEkle.Size = new System.Drawing.Size(48, 22);
            this.btnHayvanEkle.Text = "Ekle";
            this.btnHayvanEkle.Click += new System.EventHandler(this.btnHayvanEkle_Click);
            // 
            // btnHayvanDuzenle
            // 
            this.btnHayvanDuzenle.Image = global::TkiZoo.Properties.Resources.book_edit;
            this.btnHayvanDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanDuzenle.Name = "btnHayvanDuzenle";
            this.btnHayvanDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnHayvanDuzenle.Text = "Duzenle";
            this.btnHayvanDuzenle.Click += new System.EventHandler(this.btnHayvanDuzenle_Click);
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.Image = global::TkiZoo.Properties.Resources.book_remove;
            this.btnHayvanSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(39, 22);
            this.btnHayvanSil.Text = "Sil";
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHayvanBul
            // 
            this.btnHayvanBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHayvanBul.Image = global::TkiZoo.Properties.Resources.book_search;
            this.btnHayvanBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanBul.Name = "btnHayvanBul";
            this.btnHayvanBul.Size = new System.Drawing.Size(44, 22);
            this.btnHayvanBul.Text = "Bul";
            this.btnHayvanBul.Click += new System.EventHandler(this.btnHayvanBul_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel2.Text = "Ara";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(708, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Iptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(616, 363);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Hayvanlar
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(798, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "Hayvanlar";
            this.Text = "Hayvanlar";
            this.Load += new System.EventHandler(this.Hayvanlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnHayvanEkle;
        private System.Windows.Forms.ToolStripButton btnHayvanDuzenle;
        private System.Windows.Forms.ToolStripButton btnHayvanSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHayvanBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}