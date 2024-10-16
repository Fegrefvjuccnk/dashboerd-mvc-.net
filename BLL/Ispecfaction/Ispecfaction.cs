using DAL.model;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Ispecfaction
{
    public interface Ispecfaction<T> where T : Baseclass
    {
        public Expression<Func<T,bool>> Cartical { get; set; } //where
        public List<Expression<Func<T, object>> > Include { get; set; }

    }
}
