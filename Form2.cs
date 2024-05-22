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
    public partial class Form2 : Form
    {
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        List<Service> Servicelist = DataStorage.GetServiceList();
        List<Staff> StaffList = DataStorage.GetStaffList();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            labelCustomerName.Text = CustomerName;
            labelCustomerLastN.Text = CustomerLastName;
            contactinfo.Text=CustomerName+CustomerLastName+"@hotmail.com";
            listView1.Columns.Add("Staff Name", 150);
            listView1.Columns.Add("Staff Last Name", 150);
            listView1.Columns.Add("Service", 150);
            listView1.Columns.Add("Description", 150);
            listView1.Columns.Add("Price", 150);
            StaffListInitialize();
        }


        public void StaffListInitialize()
        {

            foreach (Staff staff in StaffList)
            {
                foreach (Service service in Servicelist)
                {
                    string Pricetostring = service.Price.ToString();
                    ListViewItem item = new ListViewItem(new string[] { staff.StaffName, staff.StaffLastname, service.ServiceName, service.Description, Pricetostring });
                    listView1.Items.Add(item);
                }

            }
        }

    }


}

