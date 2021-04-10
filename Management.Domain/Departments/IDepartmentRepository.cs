using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Departments
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department AddDepartment(string departmentName);
    }
}
