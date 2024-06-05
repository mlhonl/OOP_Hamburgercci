namespace OOP_Hamburgerci_WFA
{
    partial class FormTumSiparisler
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
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            grpCiro = new GroupBox();
            lblCiro = new Label();
            grpToplamSiparisGeliri = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            groupBox1 = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            grpSatilanUrunAdedi = new GroupBox();
            lblSatilanUrunAdedi = new Label();
            grpCiro.SuspendLayout();
            grpToplamSiparisGeliri.SuspendLayout();
            groupBox1.SuspendLayout();
            grpSatilanUrunAdedi.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 15;
            lstTumSiparisler.Location = new Point(26, 27);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(167, 484);
            lstTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 5);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // grpCiro
            // 
            grpCiro.Controls.Add(lblCiro);
            grpCiro.Location = new Point(210, 31);
            grpCiro.Name = "grpCiro";
            grpCiro.Size = new Size(200, 100);
            grpCiro.TabIndex = 2;
            grpCiro.TabStop = false;
            grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(17, 33);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(17, 19);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0";
            // 
            // grpToplamSiparisGeliri
            // 
            grpToplamSiparisGeliri.Controls.Add(lblToplamSiparisSayisi);
            grpToplamSiparisGeliri.Location = new Point(210, 152);
            grpToplamSiparisGeliri.Name = "grpToplamSiparisGeliri";
            grpToplamSiparisGeliri.Size = new Size(200, 100);
            grpToplamSiparisGeliri.TabIndex = 3;
            grpToplamSiparisGeliri.TabStop = false;
            grpToplamSiparisGeliri.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(17, 33);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(17, 19);
            lblToplamSiparisSayisi.TabIndex = 0;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEkstraMalzemeGeliri);
            groupBox1.Location = new Point(210, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(17, 33);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(17, 19);
            lblEkstraMalzemeGeliri.TabIndex = 0;
            lblEkstraMalzemeGeliri.Text = "0";
            // 
            // grpSatilanUrunAdedi
            // 
            grpSatilanUrunAdedi.Controls.Add(lblSatilanUrunAdedi);
            grpSatilanUrunAdedi.Location = new Point(210, 405);
            grpSatilanUrunAdedi.Name = "grpSatilanUrunAdedi";
            grpSatilanUrunAdedi.Size = new Size(200, 106);
            grpSatilanUrunAdedi.TabIndex = 5;
            grpSatilanUrunAdedi.TabStop = false;
            grpSatilanUrunAdedi.Text = "Satılan Ürün Adeti";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(17, 33);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(17, 19);
            lblSatilanUrunAdedi.TabIndex = 0;
            lblSatilanUrunAdedi.Text = "0";
            // 
            // FormTumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(436, 536);
            Controls.Add(grpSatilanUrunAdedi);
            Controls.Add(groupBox1);
            Controls.Add(grpToplamSiparisGeliri);
            Controls.Add(grpCiro);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTumSiparisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTumSiparisler";
            Load += FormTumSiparisler_Load;
            grpCiro.ResumeLayout(false);
            grpCiro.PerformLayout();
            grpToplamSiparisGeliri.ResumeLayout(false);
            grpToplamSiparisGeliri.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSatilanUrunAdedi.ResumeLayout(false);
            grpSatilanUrunAdedi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTumSiparisler;
        private Label label1;
        private GroupBox grpCiro;
        private Label lblCiro;
        private GroupBox grpToplamSiparisGeliri;
        private Label lblToplamSiparisSayisi;
        private GroupBox groupBox1;
        private Label lblEkstraMalzemeGeliri;
        private GroupBox grpSatilanUrunAdedi;
        private Label lblSatilanUrunAdedi;
    }
}