using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerAccountProcessDal
    {
        void Insert(CustomerAccountProcess t);
        void Delete(CustomerAccountProcess t);
        void Update(CustomerAccountProcess t);
        CustomerAccountProcess GetByID(int id);
        List<CustomerAccountProcess> GetList();
    }
}
