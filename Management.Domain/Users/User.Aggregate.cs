using Management.Domain.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Management.Domain.Users
{
    public partial class User
    {
        public User(string userName
            , string email
            , Department department) : base()
        {
            UserName = userName;
            Email = email;
            Department = department;
        }
        public bool ValidOnAdd()
        {
            return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Email) && new EmailAddressAttribute().IsValid(Email)
                && (Department != null || DepartmentId != 0);
        }
    }

}
