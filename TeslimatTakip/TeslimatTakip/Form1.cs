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
    }
}
