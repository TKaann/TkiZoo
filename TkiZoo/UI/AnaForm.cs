using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TkiZoo.BL;
using TkiZoo.UI;

namespace TkiZoo
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.BakiciDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

            DataSet ds1 = BLogic.OdemeDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];


        }


        Musteriler mf = new Musteriler();
        Hayvanlar hf = new Hayvanlar();

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {
            hf.ShowDialog();
        }

        private void btnBakicilar_Click(object sender, EventArgs e)
        {
            FrmBakici frm = new FrmBakici()
            {
                Text = "Bakici",
                Bakici = new Bakici() 
                {
                    ID = Guid.NewGuid()
                }
            };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.BakiciEkle(frm.Bakici);

                    if (b)
                    {
                    DataSet ds2 = BLogic.BakiciDetay();
                    if (ds2 != null)
                        dataGridView2.DataSource = ds2.Tables[0];
                    }
                }

            
        }


        private void btnBakiciDuzenle_Click(object sender, EventArgs e)
        {

                DataGridViewRow row = dataGridView2.SelectedRows[0];
                FrmBakici frm = new FrmBakici()
                {
                    Text = "Bakici Duzenle",
                    Guncelleme = true,
                    Bakici = new Bakici()
                    {
                        ID = Guid.Parse(row.Cells[0].Value.ToString()),
                        HayvanID = Guid.Parse (row.Cells[1].Value.ToString()),
                        Ad = row.Cells[4].Value.ToString(),
                        Soyad = row.Cells[5].Value.ToString(),
                        Yas = row.Cells[6].Value.ToString(),
                        Cinsiyet = row.Cells[7].Value.ToString(),
                        Telefon = row.Cells[8].Value.ToString(),
                        Bakilan = row.Cells[9].Value.ToString(),



                    },

                };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.BakiciGuncelle(frm.Bakici);

                    if (b)
                    {
                        row.Cells[1].Value = frm.Bakici.HayvanID;
                        row.Cells[4].Value = frm.Bakici.Ad;
                        row.Cells[5].Value = frm.Bakici.Soyad;
                        row.Cells[6].Value = frm.Bakici.Yas;
                        row.Cells[7].Value = frm.Bakici.Cinsiyet;
                        row.Cells[8].Value = frm.Bakici.Telefon;
                        row.Cells[9].Value = frm.Bakici.Bakilan;





                    }


                }

        }

        private void btnBakiciSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Secili kayir silinsin mi", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.BakiciSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.BakiciDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }


            }

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Odeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.Odeme);

                if (b)
                {
                    DataSet ds2 = BLogic.OdemeDetay();
                    if (ds2 != null)
                    dataGridView1.DataSource = ds2.Tables[0];

                }
            }
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Odeme Duzenle",
                Guncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar = double.Parse (row.Cells[4].Value.ToString()),
                    OdemeTur = row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),

                },

            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGuncelle(frm.Odeme);

                if (b)
                {
                    row.Cells[1].Value = frm.Odeme.MusteriID;
                    row.Cells[3].Value = frm.Odeme.Tarih;
                    row.Cells[4].Value = frm.Odeme.Tutar;
                    row.Cells[5].Value = frm.Odeme.OdemeTur;
                    row.Cells[6].Value = frm.Odeme.Aciklama;


                }


            }

        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Secili kayir silinsin mi", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }


            }

        }
    }
}
