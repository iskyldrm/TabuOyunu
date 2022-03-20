using MenuFrm.Formlar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MenuFrm.AnlatmaFrm;

namespace MenuFrm
{

    public partial class AnlatmaFrm : Form
    {
        static public string Takım ="Takım1 Kart Seçme Sırası";
        static public string Takım2 = "Takım2 Kart Seçme Sırası";
        int skor1 = 0;
        int takımsırası=0;
        int pasHakkı=3; 
        public AnlatmaFrm()
        {
            InitializeComponent();
        }
        
        
        
        private void AnlatmaFrm_Load(object sender, EventArgs e)
        {

            timer1.Start();
            timer1.Interval = 1000;
            KelimeCagırma();
            takımsırası++;
            btnPas.Text = pasHakkı.ToString();
        }

        int geriSayim=20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            geriSayim -= 1;
            btnGeriSayım.Text = geriSayim.ToString();

            if (geriSayim == 0 & takımsırası==0)
            {
                timer1.Stop();
                
                Takım1KartSecme takım1KartSecme = new Takım1KartSecme();
                takım1KartSecme.Show();
                AnlatmaFrm anlatmaFrm = new AnlatmaFrm();    
                this.Hide();
            }
            else if(geriSayim == 0)
            {
                Takım1KartSecme takım1KartSecme = new Takım1KartSecme();
                takım1KartSecme.label1.Text = Takım2;
                takım1KartSecme.Show();
                AnlatmaFrm anlatmaFrm = new AnlatmaFrm();
                this.Hide();

            }
        }
        public void btnCorrect_Click(object sender, EventArgs e)
        {
            KelimeCagırma();

            Takım1KartSecme takım1Kart = new Takım1KartSecme();

            if (takım1Kart.label1.Text == "Takım1 Kart Seçme Sırası")
            {   skor1++;
                lblT1skor.Text = skor1.ToString();
            }
            else if(takım1Kart.takım2sayac==1)
            {
                skor1++;
                lblT2skor.Text = skor1.ToString();
            }

        }
        public void btnDecline_Click(object sender, EventArgs e)
        {
            KelimeCagırma();

            Takım1KartSecme takım1Kart = new Takım1KartSecme();

            if (takım1Kart.label1.Text == "Takım1 Kart Seçme Sırası")
            {
                skor1--;
                if (skor1<0)
                {
                    lblT1skor.Text = "0";
                    skor1 = 0;
                }else
                {
                    lblT1skor.Text = skor1.ToString();
                }
                
            }
            else
            {
                skor1--;
                lblT2skor.Text = skor1.ToString();
            }

        }

        private void KelimeCagırma()
        {
            

            Random r = new Random();

            var a = r.Next(0, 9);


            switch (a)
            {
                case 0:
                    {
                        btnAna.Text = myTuple1.Item1.ToString();
                        btnYasak1.Text = myTuple1.Item2.ToString();
                        btnYasak2.Text = myTuple1.Item3.ToString();
                        btnYasak3.Text = myTuple1.Item4.ToString();
                    }
                    break;

                case 1:
                    {
                        btnAna.Text = myTuple2.Item1.ToString();
                        btnYasak1.Text = myTuple2.Item2.ToString();
                        btnYasak2.Text = myTuple2.Item3.ToString();
                        btnYasak3.Text = myTuple2.Item4.ToString();
                    }
                    break;
                case 2:
                    {
                        btnAna.Text = myTuple3.Item1.ToString();
                        btnYasak1.Text = myTuple3.Item2.ToString();
                        btnYasak2.Text = myTuple3.Item3.ToString();
                        btnYasak3.Text = myTuple3.Item4.ToString();
                    }
                    break;
                case 3:
                    {
                        btnAna.Text = myTuple4.Item1.ToString();
                        btnYasak1.Text = myTuple4.Item2.ToString();
                        btnYasak2.Text = myTuple4.Item3.ToString();
                        btnYasak3.Text = myTuple4.Item4.ToString();
                    }
                    break;
                case 4:
                    {
                        btnAna.Text = myTuple5.Item1.ToString();
                        btnYasak1.Text = myTuple5.Item2.ToString();
                        btnYasak2.Text = myTuple5.Item3.ToString();
                        btnYasak3.Text = myTuple5.Item4.ToString();
                    }
                    break;
                case 5:
                    {
                        btnAna.Text = myTuple6.Item1.ToString();
                        btnYasak1.Text = myTuple6.Item2.ToString();
                        btnYasak2.Text = myTuple6.Item3.ToString();
                        btnYasak3.Text = myTuple6.Item4.ToString();
                    }
                    break;
                case 6:
                    {
                        btnAna.Text = myTuple7.Item1.ToString();
                        btnYasak1.Text = myTuple7.Item2.ToString();
                        btnYasak2.Text = myTuple7.Item3.ToString();
                        btnYasak3.Text = myTuple7.Item4.ToString();
                    }
                    break;
                case 7:
                    {
                        btnAna.Text = myTuple8.Item1.ToString();
                        btnYasak1.Text = myTuple8.Item2.ToString();
                        btnYasak2.Text = myTuple8.Item3.ToString();
                        btnYasak3.Text = myTuple8.Item4.ToString();
                    }
                    break;

                default:
                    break;
            }
        }


        static Tuple<string, string, string, string> myTuple1 = new Tuple<string, string, string, string>("HECE", "Kelime", "Harf", "Okumak");
        static Tuple<string, string, string, string> myTuple2 = new Tuple<string, string, string, string>("KÜSMEK", "Darılmak", "Kızmak", "Tartışmak");
        static Tuple<string, string, string, string> myTuple3 = new Tuple<string, string, string, string>("AVİZE", "Lamba", "Kristal", "Tavan");
        static Tuple<string, string, string, string> myTuple4 = new Tuple<string, string, string, string>("KOORDİNAT", "Yer", "Enlem", "Boylam");
        static Tuple<string, string, string, string> myTuple5 = new Tuple<string, string, string, string>("TERİM", "Kelime", "Anlam", "Fatih");
        static Tuple<string, string, string, string> myTuple6 = new Tuple<string, string, string, string>("BASKÜL", "Tartı", "Kilo", "Ağır");
        static Tuple<string, string, string, string> myTuple7 = new Tuple<string, string, string, string>("HALÜSİNASYON", "Hayal", "Gerçek", "Görmek");
        static Tuple<string, string, string, string> myTuple8 = new Tuple<string, string, string, string>("ANTİKA", "Müzayede", "Zengin", "Eski");

        private void button1_Click(object sender, EventArgs e)
        {
            
            pasHakkı--;
            btnPas.Text = pasHakkı.ToString();

            if (pasHakkı > -1)
            {
                KelimeCagırma();
            }
            else
            {
                MessageBox.Show("Pas hakkı yoktur");
            }
            


        }
    }
        

    
}
