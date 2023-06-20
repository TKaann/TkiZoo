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
    public partial class FrmBakici : Form
    {
        public FrmBakici()
        {
            InitializeComponent();
        }



        public Bakici Bakici { get; set; }

        public bool Guncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Bakici.Ad = txtBakiciAd.Text;
            Bakici.Soyad = txtBakiciSoyad.Text;
            Bakici.Yas = txtBakiciYas.Text;
            Bakici.Cinsiyet = txtBakiciCinsiyet.Text;
            Bakici.Telefon = txtBakiciTel.Text;
            Bakici.Bakilan = txtBakiciHayvan.Text;

            Bakici.HayvanID = Guid.Parse(txtHayvan.Text);

            DialogResult = DialogResult.OK;
        }

        private void FrmBakici_Load(object sender, EventArgs e)
        {
           txtID.Text = Bakici.ID.ToString();

            if (Guncelleme) 
            {
                txtHayvan.Text = Bakici.HayvanID.ToString();
                txtBakiciAd.Text = Bakici.Ad;
                txtBakiciSoyad.Text = Bakici.Soyad;
                txtBakiciYas.Text = Bakici.Yas;
                txtBakiciCinsiyet.Text = Bakici.Cinsiyet;
                txtBakiciTel.Text = Bakici.Telefon;
                txtBakiciHayvan.Text = Bakici.Bakilan;

            }
        }

        private void btnHayvanSec_Click(object sender, EventArgs e)
        {
            Hayvanlar frm = new Hayvanlar();

            if (frm.ShowDialog() == DialogResult.OK) 
            {
                //Hayvan = frm.Hayvan;
                txtHayvan.Text = frm.Hayvan.ID.ToString();

            }
        }
    }
}
