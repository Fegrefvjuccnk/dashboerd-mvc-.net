using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
 public interface Iunitofwork:IDisposable
    {
        public Idepartmentreprostory Departmentrepostry { get; set; }
        public Iemployee Employeerepsotiry { get; set; }
        public Task<int> complete();

    }
}
