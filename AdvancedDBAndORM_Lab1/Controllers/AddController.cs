using AdvancedDBAndORM_Lab1.Data;
using AdvancedDBAndORM_Lab1.Models;
using Microsoft.AspNetCore.Mvc;
 

namespace AdvancedDBAndORM_Lab1.Controllers
{
    public class AddController : Controller
    {
        private readonly DBContext _context;

        public AddController(DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Customer> customers = _context.Customer.ToList();
            List<Address> addresses = _context.Address.ToList();
            CustomerVM vm = new CustomerVM(customers, addresses);
            return View(vm);
        }
        [HttpPost]
        public IActionResult Add(int customerID,int addressID)
        {
            if (ModelState.IsValid)
            {
                CustomerAddress ca = new CustomerAddress();
                //ca.Customer= _context.Customer.First(e=>e.ID==customerID);
                //ca.Addresss = _context.Address.First(e => e.ID == addressID);
                ca.CustomerID= customerID;
                ca.AddresssID = addressID;
                _context.CustomerAddress.Add(ca);
                _context.SaveChanges();              
            }

           return View();
        }
    }
}
