namespace TkiZoo
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHayvanlar = new System.Windows.Forms.ToolStripButton();
            this.btnBakicilar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdemeYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnBakiciDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnBakiciSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBakiciBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnOdemeDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdemeBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnMusteriler,
            this.toolStripSeparator2,
            this.btnHayvanlar,
            this.btnBakicilar,
            this.toolStripSeparator3,
            this.btnOdemeYap,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = global::TkiZoo.Properties.Resources.database_user_add;
            this.btnMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(80, 22);
            this.btnMusteriler.Text = "Musteriler";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHayvanlar
            // 
            this.btnHayvanlar.Image = global::TkiZoo.Properties.Resources.book_add;
            this.btnHayvanlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanlar.Name = "btnHayvanlar";
            this.btnHayvanlar.Size = new System.Drawing.Size(80, 22);
            this.btnHayvanlar.Text = "Hayvanlar";
            this.btnHayvanlar.Click += new System.EventHandler(this.btnHayvanlar_Click);
            // 
            // btnBakicilar
            // 
            this.btnBakicilar.Image = global::TkiZoo.Properties.Resources.button_user_add;
            this.btnBakicilar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBakicilar.Name = "btnBakicilar";
            this.btnBakicilar.Size = new System.Drawing.Size(71, 22);
            this.btnBakicilar.Text = "Bakicilar";
            this.btnBakicilar.Click += new System.EventHandler(this.btnBakicilar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Image = global::TkiZoo.Properties.Resources.money_bitcoin_money_coins;
            this.btnOdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(79, 22);
            this.btnOdemeYap.Text = "Odemeler";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBakiciDuzenle,
            this.btnBakiciSil,
            this.toolStripSeparator5,
            this.btnBakiciBul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(779, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnBakiciDuzenle
            // 
            this.btnBakiciDuzenle.Image = global::TkiZoo.Properties.Resources.button_user_edit;
            this.btnBakiciDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBakiciDuzenle.Name = "btnBakiciDuzenle";
            this.btnBakiciDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnBakiciDuzenle.Text = "Duzenle";
            this.btnBakiciDuzenle.Click += new System.EventHandler(this.btnBakiciDuzenle_Click);
            // 
            // btnBakiciSil
            // 
            this.btnBakiciSil.Image = global::TkiZoo.Properties.Resources.button_user_remove;
            this.btnBakiciSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBakiciSil.Name = "btnBakiciSil";
            this.btnBakiciSil.Size = new System.Drawing.Size(39, 22);
            this.btnBakiciSil.Text = "Sil";
            this.btnBakiciSil.Click += new System.EventHandler(this.btnBakiciSil_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBakiciBul
            // 
            this.btnBakiciBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBakiciBul.Image = global::TkiZoo.Properties.Resources.button_user_search;
            this.btnBakiciBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBakiciBul.Name = "btnBakiciBul";
            this.btnBakiciBul.Size = new System.Drawing.Size(44, 22);
            this.btnBakiciBul.Text = "Bul";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 390);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bakicilar";
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
            this.dataGridView2.Size = new System.Drawing.Size(780, 328);
            this.dataGridView2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 364);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Odemeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(2, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 328);
            this.dataGridView1.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdemeDuzenle,
            this.btnOdemeSil,
            this.toolStripSeparator6,
            this.btnOdemeBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(779, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.Image = global::TkiZoo.Properties.Resources.money_bitcoin_edit;
            this.btnOdemeDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnOdemeDuzenle.Text = "Duzenle";
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Image = global::TkiZoo.Properties.Resources.money_bitcoin_remove;
            this.btnOdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(39, 22);
            this.btnOdemeSil.Text = "Sil";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOdemeBul
            // 
            this.btnOdemeBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOdemeBul.Image = global::TkiZoo.Properties.Resources.money_bitcoin_search;
            this.btnOdemeBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeBul.Name = "btnOdemeBul";
            this.btnOdemeBul.Size = new System.Drawing.Size(44, 22);
            this.btnOdemeBul.Text = "Bul";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "Ara";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AnaForm";
            this.Text = "TKI ZOO";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.ToolStripButton btnHayvanlar;
        private System.Windows.Forms.ToolStripButton btnBakicilar;
        private System.Windows.Forms.ToolStripButton btnOdemeYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnBakiciDuzenle;
        private System.Windows.Forms.ToolStripButton btnBakiciSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnBakiciBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnOdemeDuzenle;
        private System.Windows.Forms.ToolStripButton btnOdemeSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnOdemeBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

