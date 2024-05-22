namespace OOPPROJECT
{
    public class Customer
    {

        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }

        public Customer(string name, string lastname)
        {
            CustomerName = name;
            CustomerLastname = lastname;
        }

    }

}
