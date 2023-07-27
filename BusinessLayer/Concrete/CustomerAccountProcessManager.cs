using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager: ICustomerAccountProcessService
    {
        ICustomerAccountProcessDal _customerAccountProcessDal;
        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal; 
        }

        public void BLDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccountProcess BLGetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> BLGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void BLInsert(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void BLUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
