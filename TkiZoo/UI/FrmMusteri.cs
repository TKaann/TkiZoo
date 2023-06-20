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
    public partial class FrmMusteri : Form
    {


        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Musteri Musteri { get; set; }

        public bool Guncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!ErrorControl(txtAd)) return;
            if(!ErrorControl(txtSoyad)) return;
            if(!ErrorControl(txtYas)) return;
            if(!ErrorControl(txtCinsiyet)) return;
            if(!ErrorControl(txtZiyaret)) return;

            Musteri.Ad = txtAd.Text;
            Musteri.Soyad = txtSoyad.Text;
            Musteri.Yas = txtYas.Text;
            Musteri.Cinsiyet = txtCinsiyet.Text;
            Musteri.Ziyaret = txtZiyaret.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl (Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik Bilgi Girdiniz!");
                    c.Focus();
                    return false;

                }
                else 
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            
            
            }
            if (c is MaskedTextBox) 
            {
                if (!((MaskedTextBox)c).MaskFull) 
                {
                    errorProvider1.SetError(c, "Eksik bilgi girdiniz");
                    c.Focus();
                    return true;
                
                }
            }


            return true;



        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            txtID.Text = Musteri.ID.ToString();
            if (Guncelleme)
            {
                txtAd.Text = Musteri.Ad;
                txtSoyad.Text = Musteri.Soyad;
                txtYas.Text = Musteri.Yas;
                txtCinsiyet.Text = Musteri.Cinsiyet;
                txtZiyaret.Text = Musteri.Ziyaret;
            }
        }

    }
}
