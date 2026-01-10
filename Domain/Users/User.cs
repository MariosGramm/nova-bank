using Domain.Common;
using Domain.Users.ValueObjects;
using NovaBank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    internal class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public PhoneNumber PhoneNumber { get; set; } 
        public Email Email { get; set; } 
        public DateOnly DateOfBirth { get; set; }
        public EmploymentType EmploymentType { get; set; }
        


    }
}
