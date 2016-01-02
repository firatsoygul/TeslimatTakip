using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeslimatTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gönderiOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGonderiOlustur frmge = new FormGonderiOlustur();
            frmge.ShowDialog();
        }

        private void gönderiListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGonderiListele frmgl = new FormGonderiListele();
            frmgl.ShowDialog();
        }

        private void yeniŞubeOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubeEkle frmSE = new FormSubeEkle();
            frmSE.ShowDialog();
        }

        private void şubeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubeListele frmSL = new FormSubeListele();
            frmSL.ShowDialog();
        }

        private void teslimatListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeslimatListele frmTL = new FormTeslimatListele();
            frmTL.ShowDialog();
        }

        private void teslimatOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeslimatEkle frmTE = new FormTeslimatEkle();
            frmTE.ShowDialog();
        }

        private void geriBildirimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGeriBildirimEkle frmGBE = new FormGeriBildirimEkle();
            frmGBE.ShowDialog();
        }

        private void geriBildirimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGeriBildirimListele frmGBL = new FormGeriBildirimListele();
            frmGBL.ShowDialog();
        }
    }
}
