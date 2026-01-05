using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class AuditableEntity
    {
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
