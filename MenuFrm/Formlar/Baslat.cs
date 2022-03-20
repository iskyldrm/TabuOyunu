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

        #region Oyun ilk acýlýnca oyna kodlarý
        private void btnOyna_Click(object sender, EventArgs e)
        {
            Takým1KartSecme takým1KartSecme = new Takým1KartSecme();

            takým1KartSecme.Show();


            Baslat baslat = new Baslat();

            this.Hide();

            ///////////////////////////////////////////////
         

        }

        #endregion

        
    }
}