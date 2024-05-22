namespace OOPPROJECT
{
    public class Reservation
    {

        public string Staffname { get; set; }
        public string Customername { get; set; }
        public string Service { get; set; }
        public string State { get; }
        public Reservation(string sname, string cname, string service)
        {
            Staffname = sname;
            Customername = cname;
            Service=service;
            State = $"{sname} - {cname} - {service}";
        }

    }
}
