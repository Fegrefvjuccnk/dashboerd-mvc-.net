using BLL.interfaces;
using DAL.context;
using DAL.model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.repstoriy
{
    public class Employeerepsotiry : Genericrepsotiery<Employee>,Iemployee
    {
        private readonly mvcdbcontext _dbcontext;

        public Employeerepsotiry( mvcdbcontext dbcontext):base(dbcontext) 
        {
           _dbcontext = dbcontext;
        }

        public IQueryable<Employee> Searchname(string name)
       => _dbcontext.employees.Where(E=>E.Name.ToLower().Contains(name.ToLower()));

       



        //public IQueryable<Employee> GetEmployeebyadders(string address)
        //{
        //    var result=_dbcontext.employees.Where(p=>p.Address == address).ToList();
        //    //return result;

        //}
    }
}
