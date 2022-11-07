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
            Araç_Otapark_Kaydý kayýt = new Araç_Otapark_Kaydý();
            kayýt.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araç_Otapark_Yerleri yer = new Araç_Otapark_Yerleri();
            yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Araç_Çýkýþý çýkýþ = new Araç_Çýkýþý();
            çýkýþ.ShowDialog();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}