using Management.Domain.Departments;
using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Users
{
    public interface IUserRepository : IRepository<User>
    {
        User NewUser(string userName, string email, Department department);
    }
}
