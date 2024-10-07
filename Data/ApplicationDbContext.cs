using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Data;

public class ApplicationDbContext : DbContext
{
    // Properties of ApplicationDbContext to reference our Model classes.
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Customer> Customers { get; set; }

    // Constructor of ApplicationDbContext.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

}
