namespace TeslimatTakip
{
    partial class FormGonderiListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridGonderiListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGonderiListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 130);
            this.panel1.TabIndex = 0;
            // 
            // dataGridGonderiListele
            // 
            this.dataGridGonderiListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGonderiListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGonderiListele.Location = new System.Drawing.Point(0, 130);
            this.dataGridGonderiListele.Name = "dataGridGonderiListele";
            this.dataGridGonderiListele.Size = new System.Drawing.Size(844, 381);
            this.dataGridGonderiListele.TabIndex = 1;
            // 
            // FormGonderiListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.dataGridGonderiListele);
            this.Controls.Add(this.panel1);
            this.Name = "FormGonderiListele";
            this.Text = "Gonderi Listele";
            this.Load += new System.EventHandler(this.FormGonderiListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGonderiListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridGonderiListele;
    }
}