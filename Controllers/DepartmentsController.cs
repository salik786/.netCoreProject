using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject1;
using MyProject1.Dtos;
using MyProject1.Services.Interface;

namespace MyProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly CompanyDataContext _context;
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(CompanyDataContext context, IDepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }

        // GET: api/Departments
        [HttpGet]
        public  ActionResult<GetDepartments> GetAllDepartments()
        {
            var depart = _departmentService.GetAllDepartments();
            return depart;
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public ActionResult<GetDepartments> GetDepartment(int id)
        {
            var department = _departmentService.GetDepartment(id);
            return department;
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, CreateDepartment department)
        {

            _departmentService.UpdateDepartment(id, department);

            return NoContent();
        }

        // POST: api/Departments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<bool> Create(CreateDepartment department)
        {
            return _departmentService.CreateDepartment(department);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteDepartment(int id)
        {
            return _departmentService.RemoveDepartment(id);
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
