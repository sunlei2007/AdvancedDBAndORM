using AdvancedDBAndORM_Lab1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AdvancedDBAndORM_Lab1.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; } = default!;
        public virtual DbSet<Address> Address { get; set; } = default!;
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; } = default!;

    }
}
