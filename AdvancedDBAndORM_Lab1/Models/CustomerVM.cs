using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing.Drawing2D;

namespace AdvancedDBAndORM_Lab1.Models
{
    public class CustomerVM
    {
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
        public string CustomerID { get; set; }


        public List<SelectListItem> Addresses { get; set; } = new List<SelectListItem>();
        public string AddressID { get; set; }

        public CustomerVM(List<Customer> customers, List<Address> addresses)
        {
            foreach (Customer a in customers)
            {
                Customers.Add(new SelectListItem(a.LastName+" "+a.FirstName, a.ID.ToString()));
            }
            foreach (Address a in addresses)
            {
                Addresses.Add(new SelectListItem(a.AddressLine1, a.ID.ToString()));
            }

        }
        public CustomerVM() { }
    }
}
