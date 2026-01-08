using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    internal class AuditableEntity
    {
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }     //soft delete flag
        public DateTime DeletedAt { get; set; }
    }
}
