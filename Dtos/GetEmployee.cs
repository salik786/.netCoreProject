using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1.Dtos
{
    public class GetEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
    }
}
