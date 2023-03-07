namespace AdvancedDBAndORM_Lab1.Models
{
    public class CustomerAddress
    {
        public int Id { get; set; }
         public  Customer? Customer {get;set; }

        public int CustomerID { get; set; }
        public Address? Addresss { get; set; }
        public int AddresssID { get; set; }

    }
}
