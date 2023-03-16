using Lab3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab3.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        public DbSet<Client> clients { get; set; } = default!;
        public DbSet<Room> rooms { get; set; } = default!;
      

    }
}
