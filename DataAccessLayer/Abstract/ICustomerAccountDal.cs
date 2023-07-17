using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal
    {
        void Insert(CustomerAccount t);
        void Delete(CustomerAccount t);
        void Update(CustomerAccount t);
        CustomerAccount GetByID(int id);
        List<CustomerAccount> GetList();
    }
}
