using BLL.Ispecfaction;
using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
   public interface  IGenericrepo<T> where T : Baseclass
    {
         Task<IEnumerable<T>> getall();
        
        Task add(T Iteam);
        void update(T iteam);
        void delete(T iteam);
       Task<T>  get(int id);
        Task<IEnumerable<T>> getSpcall(Ispecfaction<T> spec);
        Task<T> getSpc(Ispecfaction<T> spec);
    }
}
