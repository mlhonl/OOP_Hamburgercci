namespace OOP_Hamburgerci_WFA
{
    partial class FormEkstra
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
            groupBox1 = new GroupBox();
            btnMalzemeEkle = new Button();
            nmrMalzemeFiyati = new NumericUpDown();
            label2 = new Label();
            txtMalzmeAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(nmrMalzemeFiyati);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMalzmeAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Bilgisi";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.BackColor = Color.LawnGreen;
            btnMalzemeEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMalzemeEkle.Location = new Point(115, 160);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(182, 50);
            btnMalzemeEkle.TabIndex = 4;
            btnMalzemeEkle.Text = "Ekstra Malzemeyi Kaydet";
            btnMalzemeEkle.UseVisualStyleBackColor = false;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // nmrMalzemeFiyati
            // 
            nmrMalzemeFiyati.Location = new Point(145, 93);
            nmrMalzemeFiyati.Name = "nmrMalzemeFiyati";
            nmrMalzemeFiyati.Size = new Size(152, 29);
            nmrMalzemeFiyati.TabIndex = 3;
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
            // txtMalzmeAdi
            // 
            txtMalzmeAdi.Location = new Point(145, 36);
            txtMalzmeAdi.Name = "txtMalzmeAdi";
            txtMalzmeAdi.Size = new Size(152, 29);
            txtMalzmeAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // FormEkstra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 227);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEkstra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEkstra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnMalzemeEkle;
        private NumericUpDown nmrMalzemeFiyati;
        private Label label2;
        private TextBox txtMalzmeAdi;
    }
}