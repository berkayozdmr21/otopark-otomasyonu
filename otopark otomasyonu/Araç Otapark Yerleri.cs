using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace otopark_otomasyonu
{
    public partial class Araç_Otapark_Yerleri : Form
    {
        public Araç_Otapark_Yerleri()
        {
            InitializeComponent();
        }
        
        private void Araç_Otapark_Yerleri_Load(object sender, EventArgs e)
        {
            int sayac = 1;
            foreach ( Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "p-" + sayac;
                    item.Name = "p-" + sayac;
                    sayac++;
                }
            }
        }
    }
}
