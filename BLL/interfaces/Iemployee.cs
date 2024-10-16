using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface Iemployee : IGenericrepo<Employee>
    {
        //IQueryable<Employee> GetEmployeebyadders(string address);
        IQueryable<Employee>Searchname(string name);
    }
}
