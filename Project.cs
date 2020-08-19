using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1
{
    public class Project
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration{ get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<ProjectDepartment> projectDepartments { get; set; }
    }
}
