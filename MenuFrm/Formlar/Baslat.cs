using MenuFrm.Formlar;

namespace MenuFrm
{
    public partial class Baslat : Form
    {
        
        

        #region Initialize nesneleri

        public Baslat()
        {
            InitializeComponent();
        }
        #endregion

        #region Oyun ilk ac�l�nca oyna kodlar�
        private void btnOyna_Click(object sender, EventArgs e)
        {
            Tak�m1KartSecme tak�m1KartSecme = new Tak�m1KartSecme();

            tak�m1KartSecme.Show();


            Baslat baslat = new Baslat();

            this.Hide();

            ///////////////////////////////////////////////
         

        }

        #endregion

        
    }
}