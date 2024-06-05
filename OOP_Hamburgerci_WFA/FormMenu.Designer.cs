namespace OOP_Hamburgerci_WFA
{
    partial class FormMenu
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
            nmrMenuFiyati = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnMenuEkle = new Button();
            label2 = new Label();
            txtMenuAdi = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nmrMenuFiyati
            // 
            nmrMenuFiyati.Location = new Point(145, 93);
            nmrMenuFiyati.Name = "nmrMenuFiyati";
            nmrMenuFiyati.Size = new Size(152, 29);
            nmrMenuFiyati.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(nmrMenuFiyati);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 221);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.BackColor = Color.LawnGreen;
            btnMenuEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuEkle.Location = new Point(115, 160);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(182, 50);
            btnMenuEkle.TabIndex = 4;
            btnMenuEkle.Text = "Menu Kaydet";
            btnMenuEkle.UseVisualStyleBackColor = false;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Fiyat :";
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(145, 36);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(152, 29);
            txtMenuAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 246);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nmrMenuFiyati;
        private GroupBox groupBox1;
        private Button btnMenuEkle;
        private Label label2;
        private TextBox txtMenuAdi;
        private Label label1;
    }
}