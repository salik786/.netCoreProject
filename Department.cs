using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1
{
    public class Department : BaseEntity
    {

        public string Name { get; set; }

        public string Address { get; set; }
        public string ManagerName { get; set; }


        public int BuildingId { get; set; }
        public Building Building { get; set; }//suppose one Department have only one building
        //public ICollection<Employee> Employees { get; set; }

        //public ICollection<ProjectDepartment> projectDepartments { get; set; }

    }
}
