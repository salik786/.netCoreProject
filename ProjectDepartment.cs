using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1
{
    public class ProjectDepartment
    {
        public int ProjectDepartmentId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
