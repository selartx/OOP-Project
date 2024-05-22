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
    public partial class AddReservation : Form
    {
        public static string static_res;

        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            List<Service> Servicelist = DataStorage.GetServiceList();
            List<Staff> StaffList = DataStorage.GetStaffList();
            List<Customer> Customerlist = DataStorage.GetCustomerList();
            textdate.Text = UserControlDays.static_day+"/"+Form3.static_month+"/"+Form3.static_year;
            combostaff.Items.Clear();
            comboservice.Items.Clear();
            combocustomer.Items.Clear();
            foreach (Staff staff in StaffList)
            {
                combostaff.Items.Add(staff.StaffName);
            }
            foreach (Service service in Servicelist)
            {
                comboservice.Items.Add(service.ServiceName);
            }
            foreach (Customer customer in Customerlist)
            {
                combocustomer.Items.Add(customer.CustomerName);
            }
        }
        private UserControlDays userControlDays;

        public AddReservation(UserControlDays ucd)
        {
            InitializeComponent();
            userControlDays = ucd;
        }
        public void AddRes_Click_1(object sender, EventArgs e)
        {
            UserControlDays ucdays = new UserControlDays();
            if (combocustomer.SelectedIndex != -1 && combostaff.SelectedIndex != -1 && comboservice.SelectedIndex != -1)
            {
                // Seçili müşteri, personel ve hizmet isimlerini al
                string customerName = this.combocustomer.GetItemText(this.combocustomer.SelectedItem);
                string staffName = this.combostaff.GetItemText(this.combostaff.SelectedItem);
                string serviceName = this.comboservice.GetItemText(this.comboservice.SelectedItem);

                // Rezervasyon durumunu oluştur
                string reservationInfo = $"{customerName} - {staffName} - {serviceName}";

                userControlDays.AddReservation(reservationInfo);
                MessageBox.Show("Reservation added successfully.");
                Close();
            }
            else
            {
                MessageBox.Show("Please select a customer, a staff, and a service.");
            }

        }
    }
}
