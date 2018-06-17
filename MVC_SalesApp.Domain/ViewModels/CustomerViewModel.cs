using System.Collections.Generic;

namespace MVC_SalesApp.Domain
{
  public class CustomerViewModel
  {
    public CustomerViewModel() {
      Orders = new List<OrderViewModel>();
    }
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int OrderCount { get; set; }
    public List<OrderViewModel> Orders { get; set; }
  }
}