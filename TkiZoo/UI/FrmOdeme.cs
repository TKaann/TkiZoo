using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TkiZoo.UI
{
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }

        public Odeme Odeme { get; set; }

        public bool Guncelleme { get; set; } = false;


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lutfen Fiyat Giriniz!");
                nmTutar.Focus();
                return;
            }
            else 
            {
                errorProvider1.SetError(nmTutar, "");
            
            }
            Odeme.MusteriID = Guid.Parse (txtMusteri.Text);
            Odeme.Tarih = txtTarih.Value;
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.OdemeTur = cbOdemeTuru.Text;
            Odeme.Aciklama = txtOdemeAciklama.Text;

            DialogResult= DialogResult.OK;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Odeme.ID.ToString();

            if (Guncelleme)
            {
                txtMusteri.Text = Odeme.MusteriID.ToString();
                nmTutar.Value = (decimal)Odeme.Tutar;
                cbOdemeTuru.Text = Odeme.OdemeTur; 
                txtOdemeAciklama.Text = Odeme.Aciklama;

            }

        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }
    }
}
