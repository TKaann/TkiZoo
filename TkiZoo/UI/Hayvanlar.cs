using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TkiZoo.BL;

namespace TkiZoo.UI
{
    public partial class Hayvanlar : Form
    {
        public Hayvanlar()
        {
            InitializeComponent();
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            FrmHayvan frm = new FrmHayvan()
            {
                Text = "Hayvan Ekle",
                Hayvan = new Hayvan() { ID = Guid.NewGuid() },

            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanEkle(frm.Hayvan);

                if (b)
                {
                    DataSet ds = BLogic.HayvanGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnHayvanBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.HayvanGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];

        }

        private void btnHayvanDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmHayvan frm = new FrmHayvan()
            {
                Text = "Hayvan Guncelle",
                Guncelleme = true,
                Hayvan = new Hayvan()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Tur = row.Cells[2].Value.ToString(),
                    Yas = row.Cells[3].Value.ToString(),
                    Cinsiyet = row.Cells[4].Value.ToString(),
                },

            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanGuncelle(frm.Hayvan);

                if (b)
                {
                    row.Cells[1].Value = frm.Hayvan.Ad;
                    row.Cells[2].Value = frm.Hayvan.Tur;
                    row.Cells[3].Value = frm.Hayvan.Yas;
                    row.Cells[4].Value = frm.Hayvan.Cinsiyet;

                }


            }
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Secili kayir silinsin mi", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.HayvanGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }


            }

        }

        private void Hayvanlar_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.HayvanGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

        }

        public Hayvan Hayvan { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Hayvan = new Hayvan()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Tur = row.Cells[2].Value.ToString(),
                Yas = row.Cells[3].Value.ToString(),
                Cinsiyet = row.Cells[4].Value.ToString(),
            };

            


            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
