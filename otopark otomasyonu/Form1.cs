namespace otopark_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ara�_Otapark_Kayd� kay�t = new Ara�_Otapark_Kayd�();
            kay�t.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ara�_Otapark_Yerleri yer = new Ara�_Otapark_Yerleri();
            yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ara�_��k��� ��k�� = new Ara�_��k���();
            ��k��.ShowDialog();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}