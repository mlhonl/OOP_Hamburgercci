namespace OOP_Hamburgerci_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form children)
        {
            bool durum = false;
            this.Width = children.Width + 30;
            this.Height = children.Height + 80;

            foreach (Form form in this.MdiChildren)
            {
                if(form.Text==children.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                children.MdiParent = this;
                children.Show();

            }

            
        }
        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormSiparis());
        }

        private void sipari�BilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormTumSiparisler());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormMenu());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FormEkstra());
        }
    }
}
