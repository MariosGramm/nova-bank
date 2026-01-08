using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class User : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;

    }
}
