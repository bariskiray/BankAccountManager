using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
   
    public class CustomerAccountRepo : ICustomerAccountDal
    {
        public void Delete(CustomerAccount t)
        {
            using var context = new Context();
            context.Set<CustomerAccount>().Remove(t);
            context.SaveChanges();
        }

        public CustomerAccount GetByID(int id)
        {
            using var context = new Context();
            return context.Set<CustomerAccount>().Find(id);

        }

        public List<CustomerAccount> GetList()
        {
            using var context = new Context();
            return context.Set<CustomerAccount>().ToList();
        }

        public void Insert(CustomerAccount t)
        {
            using var context = new Context();
            context.Set<CustomerAccount>().Add(t);
            context.SaveChanges();
        }

        public void Update(CustomerAccount t)
        {
            using var context = new Context();
            context.Set<CustomerAccount>().Update(t);
            context.SaveChanges();
        }
    }
}
