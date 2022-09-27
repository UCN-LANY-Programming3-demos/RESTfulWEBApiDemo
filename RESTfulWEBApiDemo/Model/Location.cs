namespace RESTfulWEBApiDemo.Model
{
    public class Location
    {
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public Location(string address, string zip, string city, string phone)
        {
            Address = address;
            Zip = zip;
            City = city;
            Phone = phone;
        }
    }
}
