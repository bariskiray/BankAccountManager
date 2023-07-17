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
    public class CustomerAccountProcessRepo : ICustomerAccountProcessDal
    {
        public void Delete(CustomerAccountProcess t)
        {
            using var context = new Context();
            context.Set<CustomerAccountProcess>().Remove(t);
            context.SaveChanges();
        }

        public CustomerAccountProcess GetByID(int id)
        {
            using var context = new Context();
            return context.Set<CustomerAccountProcess>().Find(id);

        }

        public List<CustomerAccountProcess> GetList()
        {
            using var context = new Context();
            return context.Set<CustomerAccountProcess>().ToList();
        }

        public void Insert(CustomerAccountProcess t)
        {
            using var context = new Context();
            context.Set<CustomerAccountProcess>().Add(t);
            context.SaveChanges();

        }

        public void Update(CustomerAccountProcess t)
        {
            using var context = new Context();
            context.Set<CustomerAccountProcess>().Update(t);
            context.SaveChanges();
        }
    }
}
