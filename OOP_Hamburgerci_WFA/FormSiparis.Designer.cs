namespace OOP_Hamburgerci_WFA
{
    partial class FormSiparis
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
            pblogo = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            grpBoyut = new GroupBox();
            rdbOrta = new RadioButton();
            rdbNuyuk = new RadioButton();
            rdbKucuk = new RadioButton();
            label2 = new Label();
            flwEkstraMalzemeler = new FlowLayoutPanel();
            label3 = new Label();
            nmrAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            label4 = new Label();
            lblToplamTutar = new Label();
            btnSiparisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // pblogo
            // 
            pblogo.Image = Properties.Resources.hamburger1;
            pblogo.Location = new Point(22, 12);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(202, 141);
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(75, 178);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(22, 215);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(202, 23);
            cmbMenuler.TabIndex = 2;
            // 
            // grpBoyut
            // 
            grpBoyut.BackColor = Color.LimeGreen;
            grpBoyut.Controls.Add(rdbOrta);
            grpBoyut.Controls.Add(rdbNuyuk);
            grpBoyut.Controls.Add(rdbKucuk);
            grpBoyut.Location = new Point(22, 255);
            grpBoyut.Name = "grpBoyut";
            grpBoyut.Size = new Size(202, 82);
            grpBoyut.TabIndex = 3;
            grpBoyut.TabStop = false;
            grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(79, 27);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(48, 19);
            rdbOrta.TabIndex = 2;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbNuyuk
            // 
            rdbNuyuk.AutoSize = true;
            rdbNuyuk.Location = new Point(133, 27);
            rdbNuyuk.Name = "rdbNuyuk";
            rdbNuyuk.Size = new Size(58, 19);
            rdbNuyuk.TabIndex = 1;
            rdbNuyuk.TabStop = true;
            rdbNuyuk.Text = "Büyük";
            rdbNuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(15, 27);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(58, 19);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(22, 353);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 4;
            label2.Text = "EKSTRA MALZEME SEÇİNİZ";
            // 
            // flwEkstraMalzemeler
            // 
            flwEkstraMalzemeler.Location = new Point(22, 371);
            flwEkstraMalzemeler.Name = "flwEkstraMalzemeler";
            flwEkstraMalzemeler.Size = new Size(202, 112);
            flwEkstraMalzemeler.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(22, 500);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "ADET";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(75, 498);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(149, 23);
            nmrAdet.TabIndex = 7;
            nmrAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.LimeGreen;
            btnSiparisEkle.Location = new Point(24, 527);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(200, 61);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(256, 12);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(546, 379);
            lstSiparisler.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(459, 423);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 10;
            label4.Text = "TOPLAM TUTAR";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(502, 457);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(14, 15);
            lblToplamTutar.TabIndex = 11;
            lblToplamTutar.Text = "0";
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.BackColor = Color.LimeGreen;
            btnSiparisTamamla.ForeColor = Color.Black;
            btnSiparisTamamla.Location = new Point(613, 423);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(189, 60);
            btnSiparisTamamla.TabIndex = 12;
            btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisTamamla.UseVisualStyleBackColor = false;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // FormSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 600);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(lblToplamTutar);
            Controls.Add(label4);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nmrAdet);
            Controls.Add(label3);
            Controls.Add(flwEkstraMalzemeler);
            Controls.Add(label2);
            Controls.Add(grpBoyut);
            Controls.Add(cmbMenuler);
            Controls.Add(label1);
            Controls.Add(pblogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSiparis";
            Load += FormSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            grpBoyut.ResumeLayout(false);
            grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pblogo;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox grpBoyut;
        private RadioButton rdbOrta;
        private RadioButton rdbNuyuk;
        private RadioButton rdbKucuk;
        private Label label2;
        private FlowLayoutPanel flwEkstraMalzemeler;
        private Label label3;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label label4;
        private Label lblToplamTutar;
        private Button btnSiparisTamamla;
    }
}