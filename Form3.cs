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
using System.Globalization;

namespace OOPPROJECT
{
    public partial class Form3 : Form
    {
        int month, year;
        public static int static_month, static_year;
        public static string static_re;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayDays();
            Showres();
        }

        private void DisplayDays()
        {
            UserControlDays ucdays = new UserControlDays();
            UserControl1 userc = new UserControl1();
            DateTime now = DateTime.Now;
            month=now.Month;
            year=now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text=monthname+" "+year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i<daysoftheweek; i++)
            {
                flowLayoutPanel1.Controls.Add(userc);
            }
            for (int i = 1; i<=days; i++)
            {
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }


        }
        private void Showres()
        {
            UserControlDays ucdays = new UserControlDays();
            static_re=AddReservation.static_res;
            ucdays.AddReservation(static_re);
            flowLayoutPanel1.Controls.Add(ucdays);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text=monthname+" "+year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i<daysoftheweek; i++)
            {
                UserControl1 userc = new UserControl1();
                flowLayoutPanel1.Controls.Add(userc);
            }
            for (int i = 1; i<=days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labeldate.Text=monthname+" "+year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i<daysoftheweek; i++)
            {
                UserControl1 userc = new UserControl1();
                flowLayoutPanel1.Controls.Add(userc);
            }
            for (int i = 1; i<=days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }


    }
}
