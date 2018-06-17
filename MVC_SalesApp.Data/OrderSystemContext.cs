using MVC_SalesApp.Domain;
using System.Data.Entity;

namespace MVC_SalesApp.Data
{
  public class OrderSystemContext : DbContext
  {
    public OrderSystemContext() : base("name=OrderSystemContext") {
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
  }
}