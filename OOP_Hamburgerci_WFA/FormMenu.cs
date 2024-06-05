using OOP_Hamburgerci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci_WFA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            FormSiparis.menuler.Add(new Menu()
            {
                Ad = txtMenuAdi.Text,
                Fiyat = nmrMenuFiyati.Value,
            });
            Fonksiyonlar.Temizle(this.Controls);
            MessageBox.Show("Menü Başarılı bir şekilde eklendi");
        }
    }
}
