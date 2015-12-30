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
    public partial class FormGonderiOlustur : Form
    {
        public FormGonderiOlustur()
        {
            InitializeComponent();
        }

        private void FormGonderiOlustur_Load(object sender, EventArgs e)
        {
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiler = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            dataGridGonderiOlustur.DataSource = taGonderiler.GetGonderiListele();
        }

    }
}
