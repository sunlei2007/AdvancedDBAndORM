using System.Numerics;

namespace AdvancedDBAndORM_Lab1.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public HashSet<CustomerAddress> CustomerAddresses = new HashSet<CustomerAddress>();
    }
}
