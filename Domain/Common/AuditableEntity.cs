using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IAuditableEntity
    {
    }
    public class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
    
    }
}
