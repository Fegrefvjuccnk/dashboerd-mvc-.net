using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace DAL.model
{
    public class Department:Baseclass
    {
       
         [Required]
         [StringLength(50)]
         public string Name { get; set; }
           [Required]
           public int code { get; set; }
        public DateTime datetimecatgorey { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
