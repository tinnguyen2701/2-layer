using Management.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Salaries
{
    public interface ISalaryRepository
    {
        Salary AddUserSalary(User user, float coefficientsSalary, float workdays);
    }
}
