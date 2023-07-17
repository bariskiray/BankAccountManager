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
    public class CustomerAccountManager: ICustomerAccountService
    {
        public readonly ICustomerAccountDal _customerAccountDal;
        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void BLDelete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustomerAccount BLGetByID(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        public List<CustomerAccount> BLGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void BLInsert(CustomerAccount t)
        {
           _customerAccountDal.Insert(t);
        }

        public void BLUpdate(CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
