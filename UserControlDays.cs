/****************************************************************************
**					     SAKARYA UNIVERSITESI
**				BILGISAYAR VE BILISIM BILIMLERI FAKULTESI
**				    BILGISAYAR MUHENDISLIGI BOLUMU
**				   NESNEYE DAYALI PROGRAMLAMA DERSI
**					  2023-2024 BAHAR DONEMI
**	
**				ODEV NUMARASI:Nesneye Dayali Programlama Projesi
**				OGRENCI ADI:Selva
**				OGRENCI NUMARASI:Artunc
**              DERSIN ALINDIGI GRUP:1/C
****************************************************************************/
namespace OOPPROJECT
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays)
        {
            labeldays.Text=numdays+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day=labeldays.Text;
            AddReservation addReservationForm = new AddReservation(this);
            addReservationForm.Show();


        }
        public void AddReservation(string reservationInfo)
        {
            textres.Text=reservationInfo;
        }

    }
}
