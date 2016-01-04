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
            //Form açılışında gönderiler listeleniyor.
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiler = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            dataGridGonderiOlustur.DataSource = taGonderiler.GetGonderiListele();
            //Şubeler comboboxa alınıyor
            DataSetTeslimatTableAdapters.SubelerTableAdapter taSubeCek = new DataSetTeslimatTableAdapters.SubelerTableAdapter();
            comboBoxSube.DataSource = taSubeCek.GetSubeListele();
            comboBoxSube.DisplayMember = "Şube İsmi";
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                //Ekle butonu ile yeni gönderi ekleniyor.
                DataSetTeslimatTableAdapters.GonderilerTableAdapter taGonderiler = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
                //Girilen içerik datasete yükleniyor.
                taGonderiler.InsertGonderiEkle(textBoxisim.Text, DateTime.Now, textBoxTelefon.Text, textBoxAdres.Text, textBoxicerik.Text, Convert.ToDecimal(textBoxUcret.Text), textBoxAlici.Text,comboBoxSube.Text);
                dataGridGonderiOlustur.DataSource = taGonderiler.GetGonderiListele();
            }
                catch (Exception)
            {
                //Herhangi bir değer girilmezse uyarı veriyor.
                MessageBox.Show("Geçerli bir değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGonderiOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

    }
}
