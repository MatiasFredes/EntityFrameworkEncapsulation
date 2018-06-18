using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_SalesApp.Data.Repository;

namespace MVC_SalesApp.Data.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderSystemContext Context;

        public UnitOfWork()
        {
            this.Context = new OrderSystemContext();
            this.Customers = new CustomerDataRepository();
        }

        public ICustomerDataRepository Customers { get; private set; }

        public void Dispose()
        {
            this.Context.Dispose();
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }
    }
}
