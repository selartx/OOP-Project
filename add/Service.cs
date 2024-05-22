namespace OOPPROJECT
{
    public class Service
    {

        public string ServiceName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Service(string servicename, string description, double price)
        {
            ServiceName=servicename;
            Description=description;
            Price=price;
        }

    }
}
