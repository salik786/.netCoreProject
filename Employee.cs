using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1
{
 
    public class Employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }

}
