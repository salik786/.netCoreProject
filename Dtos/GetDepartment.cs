﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1.Dtos
{
    public class GetDepartments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public CreateBuilding Building { get; set; }
    }
}
