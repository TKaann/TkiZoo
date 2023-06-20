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
    public partial class FrmHayvan : Form
    {
        public FrmHayvan()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Hayvan Hayvan { get; set; }

        public bool Guncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtHayvanAd)) return;
            if (!ErrorControl(cbTur)) return;
            if (!ErrorControl(txtHayvanYas)) return;
            if (!ErrorControl(txtHayvanCinsiyet)) return;
            DialogResult =DialogResult.OK;

            Hayvan.Ad = txtHayvanAd.Text;
            Hayvan.Tur = cbTur.Text;
            Hayvan.Yas = txtHayvanYas.Text;
            Hayvan.Cinsiyet = txtHayvanCinsiyet.Text;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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


            return true;



        }

        private void FrmHayvan_Load(object sender, EventArgs e)
        {
            txtID.Text = Hayvan.ID.ToString();
            if (Guncelleme) 
            {
                txtHayvanAd.Text = Hayvan.Ad;
                cbTur.Text= Hayvan.Tur;
                txtHayvanYas.Text = Hayvan.Yas;
                txtHayvanCinsiyet.Text = Hayvan.Cinsiyet;

            }
        }
    }
}
