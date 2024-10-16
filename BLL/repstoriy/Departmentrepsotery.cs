using BLL.interfaces;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.context;
using Microsoft.EntityFrameworkCore;

namespace BLL.repstoriy
{
  public class Departmentrepsotery : Genericrepsotiery<Department>,Idepartmentreprostory
    {
        public Departmentrepsotery(mvcdbcontext dbContext):base(dbContext)
        {
            
        }

    }
   
}
