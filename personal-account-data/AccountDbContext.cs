using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using personal_account_data.DbEntities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_account_data
{
    public class AccountDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<User> Roles { get; set; }
    }
}
