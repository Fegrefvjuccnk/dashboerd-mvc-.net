using BLL.Ispecfaction;
using DAL.model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FristprojectPL.specfactionofproject
{
    public static class Equvalentspecfaction<T> where T : Baseclass
    {
        public static Task<IQueryable<T>> GetQuery(IQueryable<T> inputquery,Ispecfaction<T> spec)
        {
            var query = inputquery;
            if (spec.Cartical != null)
                query = query.Where(spec.Cartical);

            query = spec.Include.Aggregate(query, (inputquerys, Extantion) => inputquerys.Include(Extantion));

            return Task.FromResult(query);
        }
    }
}
