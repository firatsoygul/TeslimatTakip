namespace TeslimatTakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gönderiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderiListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderiOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimatİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimatListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimatOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriBildirimlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriBildirimListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriBildirimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniŞubeOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxToplamGeriBildirim = new System.Windows.Forms.ComboBox();
            this.comboBoxToplamTeslimat = new System.Windows.Forms.ComboBox();
            this.comboBoxToplamGonderi = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelToplamGeriBildirim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelToplamTeslimat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelToplamGonderi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderiİşlemleriToolStripMenuItem,
            this.teslimatİşlemleriToolStripMenuItem,
            this.geriBildirimlerToolStripMenuItem,
            this.şubelerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gönderiİşlemleriToolStripMenuItem
            // 
            this.gönderiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderiListeleToolStripMenuItem,
            this.gönderiOluşturToolStripMenuItem});
            this.gönderiİşlemleriToolStripMenuItem.Name = "gönderiİşlemleriToolStripMenuItem";
            this.gönderiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.gönderiİşlemleriToolStripMenuItem.Text = "Gönderi İşlemleri";
            // 
            // gönderiListeleToolStripMenuItem
            // 
            this.gönderiListeleToolStripMenuItem.Name = "gönderiListeleToolStripMenuItem";
            this.gönderiListeleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.gönderiListeleToolStripMenuItem.Text = "Gönderi Listele";
            this.gönderiListeleToolStripMenuItem.Click += new System.EventHandler(this.gönderiListeleToolStripMenuItem_Click);
            // 
            // gönderiOluşturToolStripMenuItem
            // 
            this.gönderiOluşturToolStripMenuItem.Name = "gönderiOluşturToolStripMenuItem";
            this.gönderiOluşturToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.gönderiOluşturToolStripMenuItem.Text = "Gönderi Oluştur";
            this.gönderiOluşturToolStripMenuItem.Click += new System.EventHandler(this.gönderiOluşturToolStripMenuItem_Click);
            // 
            // teslimatİşlemleriToolStripMenuItem
            // 
            this.teslimatİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimatListeleToolStripMenuItem,
            this.teslimatOluşturToolStripMenuItem});
            this.teslimatİşlemleriToolStripMenuItem.Name = "teslimatİşlemleriToolStripMenuItem";
            this.teslimatİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.teslimatİşlemleriToolStripMenuItem.Text = "Teslimat İşlemleri";
            // 
            // teslimatListeleToolStripMenuItem
            // 
            this.teslimatListeleToolStripMenuItem.Name = "teslimatListeleToolStripMenuItem";
            this.teslimatListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.teslimatListeleToolStripMenuItem.Text = "Teslimat Listele";
            this.teslimatListeleToolStripMenuItem.Click += new System.EventHandler(this.teslimatListeleToolStripMenuItem_Click);
            // 
            // teslimatOluşturToolStripMenuItem
            // 
            this.teslimatOluşturToolStripMenuItem.Name = "teslimatOluşturToolStripMenuItem";
            this.teslimatOluşturToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.teslimatOluşturToolStripMenuItem.Text = "Teslimat Ekle";
            this.teslimatOluşturToolStripMenuItem.Click += new System.EventHandler(this.teslimatOluşturToolStripMenuItem_Click);
            // 
            // geriBildirimlerToolStripMenuItem
            // 
            this.geriBildirimlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriBildirimListeleToolStripMenuItem,
            this.geriBildirimEkleToolStripMenuItem});
            this.geriBildirimlerToolStripMenuItem.Name = "geriBildirimlerToolStripMenuItem";
            this.geriBildirimlerToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.geriBildirimlerToolStripMenuItem.Text = "Geri Bildirimler";
            // 
            // geriBildirimListeleToolStripMenuItem
            // 
            this.geriBildirimListeleToolStripMenuItem.Name = "geriBildirimListeleToolStripMenuItem";
            this.geriBildirimListeleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.geriBildirimListeleToolStripMenuItem.Text = "Geri Bildirim Listele";
            this.geriBildirimListeleToolStripMenuItem.Click += new System.EventHandler(this.geriBildirimListeleToolStripMenuItem_Click);
            // 
            // geriBildirimEkleToolStripMenuItem
            // 
            this.geriBildirimEkleToolStripMenuItem.Name = "geriBildirimEkleToolStripMenuItem";
            this.geriBildirimEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.geriBildirimEkleToolStripMenuItem.Text = "Geri Bildirim Ekle";
            this.geriBildirimEkleToolStripMenuItem.Click += new System.EventHandler(this.geriBildirimEkleToolStripMenuItem_Click);
            // 
            // şubelerToolStripMenuItem
            // 
            this.şubelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şubeListeleToolStripMenuItem,
            this.yeniŞubeOluşturToolStripMenuItem});
            this.şubelerToolStripMenuItem.Name = "şubelerToolStripMenuItem";
            this.şubelerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.şubelerToolStripMenuItem.Text = "Şubeler";
            // 
            // şubeListeleToolStripMenuItem
            // 
            this.şubeListeleToolStripMenuItem.Name = "şubeListeleToolStripMenuItem";
            this.şubeListeleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.şubeListeleToolStripMenuItem.Text = "Şube Listele";
            this.şubeListeleToolStripMenuItem.Click += new System.EventHandler(this.şubeListeleToolStripMenuItem_Click);
            // 
            // yeniŞubeOluşturToolStripMenuItem
            // 
            this.yeniŞubeOluşturToolStripMenuItem.Name = "yeniŞubeOluşturToolStripMenuItem";
            this.yeniŞubeOluşturToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.yeniŞubeOluşturToolStripMenuItem.Text = "Şube Düzenle";
            this.yeniŞubeOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniŞubeOluşturToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxToplamGeriBildirim);
            this.panel1.Controls.Add(this.comboBoxToplamTeslimat);
            this.panel1.Controls.Add(this.comboBoxToplamGonderi);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 169);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxToplamGeriBildirim
            // 
            this.comboBoxToplamGeriBildirim.FormattingEnabled = true;
            this.comboBoxToplamGeriBildirim.Location = new System.Drawing.Point(432, 132);
            this.comboBoxToplamGeriBildirim.Name = "comboBoxToplamGeriBildirim";
            this.comboBoxToplamGeriBildirim.Size = new System.Drawing.Size(184, 21);
            this.comboBoxToplamGeriBildirim.TabIndex = 4;
            // 
            // comboBoxToplamTeslimat
            // 
            this.comboBoxToplamTeslimat.FormattingEnabled = true;
            this.comboBoxToplamTeslimat.Location = new System.Drawing.Point(220, 132);
            this.comboBoxToplamTeslimat.Name = "comboBoxToplamTeslimat";
            this.comboBoxToplamTeslimat.Size = new System.Drawing.Size(184, 21);
            this.comboBoxToplamTeslimat.TabIndex = 3;
            // 
            // comboBoxToplamGonderi
            // 
            this.comboBoxToplamGonderi.FormattingEnabled = true;
            this.comboBoxToplamGonderi.Location = new System.Drawing.Point(12, 132);
            this.comboBoxToplamGonderi.Name = "comboBoxToplamGonderi";
            this.comboBoxToplamGonderi.Size = new System.Drawing.Size(184, 21);
            this.comboBoxToplamGonderi.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelToplamGeriBildirim);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(432, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 105);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // labelToplamGeriBildirim
            // 
            this.labelToplamGeriBildirim.AutoSize = true;
            this.labelToplamGeriBildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamGeriBildirim.ForeColor = System.Drawing.Color.White;
            this.labelToplamGeriBildirim.Location = new System.Drawing.Point(52, 35);
            this.labelToplamGeriBildirim.Name = "labelToplamGeriBildirim";
            this.labelToplamGeriBildirim.Size = new System.Drawing.Size(87, 63);
            this.labelToplamGeriBildirim.TabIndex = 1;
            this.labelToplamGeriBildirim.Text = "00";
            this.labelToplamGeriBildirim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Kredi Kartı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelToplamTeslimat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(220, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelToplamTeslimat
            // 
            this.labelToplamTeslimat.AutoSize = true;
            this.labelToplamTeslimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTeslimat.ForeColor = System.Drawing.Color.White;
            this.labelToplamTeslimat.Location = new System.Drawing.Point(67, 35);
            this.labelToplamTeslimat.Name = "labelToplamTeslimat";
            this.labelToplamTeslimat.Size = new System.Drawing.Size(87, 63);
            this.labelToplamTeslimat.TabIndex = 1;
            this.labelToplamTeslimat.Text = "00";
            this.labelToplamTeslimat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Teslimat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelToplamGonderi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelToplamGonderi
            // 
            this.labelToplamGonderi.AutoSize = true;
            this.labelToplamGonderi.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamGonderi.ForeColor = System.Drawing.Color.White;
            this.labelToplamGonderi.Location = new System.Drawing.Point(40, 35);
            this.labelToplamGonderi.Name = "labelToplamGonderi";
            this.labelToplamGonderi.Size = new System.Drawing.Size(87, 63);
            this.labelToplamGonderi.TabIndex = 1;
            this.labelToplamGonderi.Text = "00";
            this.labelToplamGonderi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Gönderi";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1002, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Teslimat Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gönderiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gönderiListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gönderiOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimatİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimatListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimatOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriBildirimlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriBildirimListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriBildirimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubeListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniŞubeOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelToplamGonderi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelToplamGeriBildirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelToplamTeslimat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxToplamGeriBildirim;
        private System.Windows.Forms.ComboBox comboBoxToplamTeslimat;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ComboBox comboBoxToplamGonderi;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;

    }
}

