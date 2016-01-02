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
    public partial class FormGonderiListele : Form
    {
        public FormGonderiListele()
        {
            InitializeComponent();
        }

        private void FormGonderiListele_Load(object sender, EventArgs e)
        {
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiler = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            dataGridGonderiler.DataSource = taGonderiler.GetGonderiListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerGonderilerilk_ValueChanged(object sender, EventArgs e)
        {
            //Seçilen ilk tarihe göre gönderileri listele.
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiListeleTariheGore = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            dataGridGonderiler.DataSource = taGonderiListeleTariheGore.GetGonderiListeleTarihArasi(dateTimePickerGonderilerilk.Value.Date, dateTimePickerGonderilerSon.Value.Date);
        }

        private void dateTimePickerGonderilerSon_ValueChanged(object sender, EventArgs e)
        {
            //Seçilen ilk tarihe göre gönderileri listele.
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiListeleTariheGore = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            dataGridGonderiler.DataSource = taGonderiListeleTariheGore.GetGonderiListeleTarihArasi(dateTimePickerGonderilerilk.Value.Date, dateTimePickerGonderilerSon.Value.Date);
        }
    }
}
