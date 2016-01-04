using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            CheckForIllegalCrossThreadCalls = false;
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

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaporlar frmR = new FormRaporlar();
            frmR.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void AnaEkranGuncelle()
        {
            //Toplam gönderi sayısı ana forma yazdırılıyor.
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taToplamGonderiAl = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            comboBoxToplamGonderi.DataSource = taToplamGonderiAl.GetToplamGonderiSayisi();
            comboBoxToplamGonderi.DisplayMember = "Toplam Gönderi";
            labelToplamGonderi.Text = comboBoxToplamGonderi.Text;
            comboBoxToplamGonderi.Visible = false;
            //Toplam teslimat sayısı ana forma yazdırılıyor.
            DataSetTeslimatTableAdapters.TeslimatlarTableAdapter taToplamTeslimatAl = new DataSetTeslimatTableAdapters.TeslimatlarTableAdapter();
            comboBoxToplamTeslimat.DataSource = taToplamTeslimatAl.GetToplamTeslimatSayisi();
            comboBoxToplamTeslimat.DisplayMember = "Toplam Alıcı";
            labelToplamTeslimat.Text = comboBoxToplamTeslimat.Text;
            comboBoxToplamTeslimat.Visible = false;
            //Toplam geri bildirim sayısı ana forma yazdırılıyor.
            DataSetTeslimatTableAdapters.GonderilerTableAdapter taToplamGeriBildirimAl = new DataSetTeslimatTableAdapters.GonderilerTableAdapter();
            comboBoxToplamGeriBildirim.DataSource = taToplamGeriBildirimAl.GetToplamKrediKarti();
            comboBoxToplamGeriBildirim.DisplayMember = "Toplam";
            labelToplamGeriBildirim.Text = comboBoxToplamGeriBildirim.Text;
            comboBoxToplamGeriBildirim.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AnaEkranGuncelle();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYardim frmY = new FormYardim();
            frmY.ShowDialog();
        }

    }
}
