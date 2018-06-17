using MVC_SalesApp.Domain.Enums;
using System;

namespace MVC_SalesApp.Domain
{
  public class OrderViewModel
  {
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderSource OrderSource { get; set; }
    public int CustomerId { get; set; }
  }
}