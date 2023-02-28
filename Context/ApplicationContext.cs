using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLASSEM_MVC_PRO.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CLASSEM_MVC_PRO.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}