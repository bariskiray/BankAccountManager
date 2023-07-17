using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=IES01; initial catalog=EasyCashDb; integrated security=true;");
    }
        public Microsoft.EntityFrameworkCore.DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

    }
}
