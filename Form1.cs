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
    public static class DataStorage
    {
        private static List<Customer> customerList = new List<Customer>();
        private static List<Staff> staffList = new List<Staff>();
        private static List<Service> servicelist = new List<Service>();

        public static void AddCustomer()
        {
            Customer customer1 = new Customer("Sevil", "Artunç");
            Customer customer2 = new Customer("Beyza", "Artunç");
            customerList.Add(customer1);
            customerList.Add(customer2);

        }
        public static void AddStaff() 
        {
            staffList.Clear();
            Staff staff1 = new Staff("Selva", "Artunç", 1234);
            Staff staff2 = new Staff("Karsu", "Dönmez", 1234);
            staffList.Add(staff1);
            staffList.Add(staff2);
        }
        public static void AddService()
        {
            servicelist.Clear();
            Service service1 = new Service("Hair Care", "Haircuts & Styling etc.", 10);
            Service service2 = new Service("Facial Treatments", "Moisturizing Facials etc.", 20);
            servicelist.Add(service1);
            servicelist.Add(service2);
        }
        public static List<Customer> GetCustomerList()
        {
            customerList.Clear();
            AddCustomer();
            return customerList;
        }
        public static List<Staff> GetStaffList()
        {
            AddStaff();
            return staffList;
        }
        public static List<Service> GetServiceList()
        {
            AddService();
            return servicelist;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void StaffControl(string staffname, string staffLastname, int staffpassword)
        {
            List<Staff> staffList = DataStorage.GetStaffList();
            foreach (Staff s in staffList)
            {
                if (s.StaffName ==staffname&&s.StaffLastname==staffLastname&&s.StaffPassword==staffpassword)
                {
                    Form3 stafform = new Form3();
                    stafform.Show();
                    return;
                }
            }

            MessageBox.Show("Staff not found. Please enter a valid staff.");
        }

        public void CustomerControl(string customerName, string customerLastname)
        {
            List<Customer> customerList = DataStorage.GetCustomerList();
            foreach (Customer c in customerList)
            {
                if (c.CustomerName == customerName && c.CustomerLastname == customerLastname)
                {
                    Form2 customerform = new Form2();
                    customerform.CustomerName = customerName;
                    customerform.CustomerLastName = customerLastname;
                    customerform.Show();
                    return;
                }
            }

            MessageBox.Show("Customer not found. Please enter a valid customer.");
        }
        private void CustomerSearch_Click(object sender, EventArgs e)
        {
            string customerName = CustomerN.Text;
            string customerLastname = CustomerLastN.Text;
            CustomerControl(customerName, customerLastname);


        }
        private void StaffSearch_Click(object sender, EventArgs e)
        {
            string staffName = StaffN.Text;
            string staffLastname = StaffLastN.Text;
            int staffpassword = Convert.ToInt32(StaffP.Text);
            StaffControl(staffName, staffLastname, staffpassword);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
