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
    public partial class Musteriler : Form
    {
        public Musteri Musteri { get; set; }
        public Musteriler()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Musteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },

            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.Musteri);

                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Musteri Guncelle",
                Guncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Yas = row.Cells[3].Value.ToString(),
                    Cinsiyet = row.Cells[4].Value.ToString(),
                    Ziyaret = row.Cells[5].Value.ToString(),

                },

            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Yas;
                    row.Cells[4].Value = frmMusteri.Musteri.Cinsiyet;
                    row.Cells[5].Value = frmMusteri.Musteri.Ziyaret;

                }


            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

        }


        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Secili kayir silinsin mi", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }


            }

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MusteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Musteri = new Musteri()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Yas = row.Cells[3].Value.ToString(),
                Cinsiyet = row.Cells[4].Value.ToString(),
                Ziyaret = row.Cells[5].Value.ToString(),
            };




            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
