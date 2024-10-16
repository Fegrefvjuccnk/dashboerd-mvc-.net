using DAL.model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.context
{
  public class mvcdbcontext:IdentityDbContext<AuthAppliction>
    {

        public mvcdbcontext(DbContextOptions<mvcdbcontext> option):base(option)
        {
            
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("server=.;database=mvcproject;trusted_connection=true");
        public DbSet<Department>Departments{ get; set; }
        public DbSet<Employee>employees { get; set; }
    }
}
