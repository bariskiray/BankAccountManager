using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerAccountProcessService
    {
        void BLInsert(CustomerAccountProcess t);
        void BLDelete(CustomerAccountProcess t);
        void BLUpdate(CustomerAccountProcess t);
        CustomerAccountProcess BLGetByID(int id);
        List<CustomerAccountProcess> BLGetList();
    }
}
