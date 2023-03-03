namespace AdvancedDBAndORM_Lab1.Models
{
    public class Address
    {
        public Address() { }
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }

        public HashSet<CustomerAddress> Addresses = new HashSet<CustomerAddress>();

    }
}