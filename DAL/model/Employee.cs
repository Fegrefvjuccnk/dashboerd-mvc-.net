using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class Employee:Baseclass
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

     
        public int? Age { get; set; }

        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

       
        public string Eamil { get; set; }

        public bool IsActive { get; set; }
    
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public DateTime DateOfCreiton { get; set; } = DateTime.Now;
        public string ImageName { get; set; }


        public int ? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
