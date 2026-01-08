using Domain.Common;
using Domain.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    internal class User : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Email Email { get; set; }

    }
}
