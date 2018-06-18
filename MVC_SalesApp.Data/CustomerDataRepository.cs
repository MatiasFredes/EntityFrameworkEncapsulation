using MVC_SalesApp.Data.Repository;
using MVC_SalesApp.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MVC_SalesApp.Data
{
    public class CustomerDataRepository : Repository<Customer>, ICustomerDataRepository
    {

        public CustomerDataRepository() : base(new OrderSystemContext())
        {

        }


    }
}





