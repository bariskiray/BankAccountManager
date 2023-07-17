using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerAccountService
    {
        void BLInsert(CustomerAccount t);
        void BLDelete(CustomerAccount t);
        void BLUpdate(CustomerAccount t);
        CustomerAccount BLGetByID(int id);
        List<CustomerAccount> BLGetList();
    }
}
