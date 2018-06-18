using MVC_SalesApp.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_SalesApp.Data.Core
{
   public interface IUnitOfWork : IDisposable
    {
        ICustomerDataRepository Customers { get; }
        void SaveChanges();
    }
}
