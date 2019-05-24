using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.IsArchived = false;
            this.DateCreated = DateTime.UtcNow;
            this.DateModified = DateTime.UtcNow;
        }
        public bool IsArchived { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
