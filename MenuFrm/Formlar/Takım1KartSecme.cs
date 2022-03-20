using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuFrm.Formlar
{
    public partial class Takım1KartSecme : Form
    {
        public int takım2sayac = 0;

        #region Initialize nesneleri
        public Takım1KartSecme()
        {
            InitializeComponent();

        }
        int geriSayim = 4;
        #endregion

        #region Bekleme ekranı yüklenmesi
        
        private void Takım1KartSecme_Load(object sender, EventArgs e)
        {

            timer1.Start();
            timer1.Interval = 1000;
            label3.Hide();
            if (label1.Text == "Takım2 Kart Seçme Sırası")
            {
                takım2sayac++;
            }
                
        }

        #endregion

        #region Bekleme ekranı timer kodları
        private void timer1_Tick(object sender, EventArgs e)
        {

            geriSayim -= 1;
            lblSecmeSaniye.Text = geriSayim.ToString();

            if (geriSayim == 0)
            {
                AnlatmaFrm anlatmaFrm = new AnlatmaFrm();
                timer1.Stop();
                anlatmaFrm.Show();
                Takım1KartSecme takım1KartSecme1 = new Takım1KartSecme();
                this.Hide();
            }

        }
        #endregion

        #region Bekleme ekranı geri labelı kodları
        private void label2_Click(object sender, EventArgs e)
        {
            Takım1KartSecme takım1KartSecme = new Takım1KartSecme();
            timer1.Stop();
            this.Hide();

            Baslat baslat = new Baslat();

            baslat.Show();
        }

        #endregion

        private void label2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            lblPasue.Hide();
            label3.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Hide();
            lblPasue.Show();
        }

        
    }
}
